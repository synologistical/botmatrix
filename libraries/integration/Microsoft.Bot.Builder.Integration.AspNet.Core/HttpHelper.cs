﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.Integration.AspNet.Core
{
    internal static class HttpHelper
    {
        public static readonly JsonSerializer BotMessageSerializer = JsonSerializer.Create(new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            ContractResolver = new ReadOnlyJsonContractResolver(),
            Converters = new List<JsonConverter> { new Iso8601TimeSpanConverter() },
        });

        public static async Task<Activity> ReadRequestAsync(HttpRequest request)
        public static T ReadRequest<T>(HttpRequest request)
        {
            try
            {
                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var activity = default(Activity);

                using (var memoryStream = new MemoryStream())
                using (var bodyReader = new JsonTextReader(new StreamReader(request.Body, Encoding.UTF8)))
                {
                    await request.Body.CopyToAsync(memoryStream).ConfigureAwait(false);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    using (var bodyReader = new JsonTextReader(new StreamReader(memoryStream, Encoding.UTF8)))
                    {
                        activity = BotMessageSerializer.Deserialize<Activity>(bodyReader);
                    }
                }

                return activity;
                    return BotMessageSerializer.Deserialize<T>(bodyReader);
                }
            }
            catch (JsonException)
            {
                return default;
            }
        }

        public static async Task WriteResponseAsync(HttpResponse response, InvokeResponse invokeResponse)
        {
            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            if (invokeResponse == null)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = invokeResponse.Status;

                if (invokeResponse.Body != null)
                {
                    response.ContentType = "application/json";

                    using (var writer = new StreamWriter(response.Body))
                    {
                        using (var jsonWriter = new JsonTextWriter(writer))
                        {
                            BotMessageSerializer.Serialize(jsonWriter, invokeResponse.Body);
                        }
                    }
                }
            }
        }

        public static void WriteResponse(HttpResponse response, int statusCode, object body = null)
        {
            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            if (body == null)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = statusCode;
                response.ContentType = "application/json";

                using (var writer = new StreamWriter(response.Body))
                {
                    using (var jsonWriter = new JsonTextWriter(writer))
                    {
                        BotMessageSerializer.Serialize(jsonWriter, body);
                    }
                }
            }
        }
    }
}
