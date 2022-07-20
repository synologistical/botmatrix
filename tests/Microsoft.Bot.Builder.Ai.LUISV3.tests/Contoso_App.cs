﻿// <auto-generated>
// Code generated by LUISGen Contoso App.json -cs Microsoft.Bot.Builder.AI.LuisV3.Tests.Contoso_App -o 
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Microsoft.Bot.Builder.AI.LuisV3.Tests
{
    public partial class Contoso_App: IRecognizerConvert
    {

    [JsonProperty("text")]
    public string Text;

    [JsonProperty("alteredText")]
    public string AlteredText;

    public enum Intent {
        Cancel, 
        Delivery, 
        EntityTests, 
        Greeting, 
        Help, 
        None, 
        Roles, 
        search, 
        SpecifyName, 
        Travel, 
        Weather_GetForecast
    };
    [JsonProperty("intents")]
    public Dictionary<Intent, IntentScore> Intents;

    public class _Entities
    {
        // Simple entities
        public string[] City;
        public string[] To;
        public string[] From;

        public string[] Name;
        public string[] likee;
        public string[] liker;

        public string[] State;

        public string[] Weather_Location;
        public string[] destination;
        public string[] source;

        // Built-in entities
        public Age[] age;
        public Age[] begin;
        public Age[] end;

        public DateTimeSpec[] datetime;
        public DateTimeSpec[] arrive;
        public DateTimeSpec[] leave;

        public Dimension[] dimension;
        public Dimension[] length;
        public Dimension[] width;

        public string[] email;
        public string[] receiver;
        public string[] sender;

        public GeographyV2[] geographyV2;
        public GeographyV2[] endloc;
        public GeographyV2[] startloc;

        public Money[] money;
        public Money[] max;
        public Money[] min;

        public double[] number;

        public OrdinalV2[] ordinalV2;
        public OrdinalV2[] endpos;
        public OrdinalV2[] startpos;

        public double[] percentage;
        public double[] maximum;
        public double[] minimum;

        public string[] personName;
        public string[] child;
        public string[] parent;

        public string[] phonenumber;
        public string[] newPhone;
        public string[] old;

        public Temperature[] temperature;
        public Temperature[] a;
        public Temperature[] b;

        public string[] url;
        public string[] oldURL;

        // Lists
        public string[][] Airline;
        public string[][] Buyer;
        public string[][] Seller;

        // Regex entities
        public string[] Part;
        public string[] buy;
        public string[] sell;

        // Pattern.any
        public string[] person;
        public string[] from;
        public string[] to;

        public string[] subject;
        public string[] extra;

        // Composites
        public class _InstanceAddress
        {
            public InstanceData[] number;
            public InstanceData[] State;
        }
        public class AddressClass
        {
            public double[] number;
            public string[] State;
            [JsonProperty("$instance")]
            public _InstanceAddress _instance;
        }
        public AddressClass[] Address;

        public class _InstanceComposite1
        {
            public InstanceData[] age;
            public InstanceData[] datetime;
            public InstanceData[] dimension;
            public InstanceData[] email;
            public InstanceData[] money;
            public InstanceData[] number;
            public InstanceData[] percentage;
            public InstanceData[] phonenumber;
            public InstanceData[] temperature;
        }
        public class Composite1Class
        {
            public Age[] age;
            public DateTimeSpec[] datetime;
            public Dimension[] dimension;
            public string[] email;
            public Money[] money;
            public double[] number;
            public double[] percentage;
            public string[] phonenumber;
            public Temperature[] temperature;
            [JsonProperty("$instance")]
            public _InstanceComposite1 _instance;
        }
        public Composite1Class[] Composite1;

        public class _InstanceComposite2
        {
            public InstanceData[] Airline;
            public InstanceData[] City;
            public InstanceData[] url;
            public InstanceData[] From;
            public InstanceData[] To;
            public InstanceData[] Weather_Location;
        }
        public class Composite2Class
        {
            public string[][] Airline;
            public string[] City;
            public string[] url;
            public string[] From;
            public string[] To;
            public string[] Weather_Location;
            [JsonProperty("$instance")]
            public _InstanceComposite2 _instance;
        }
        public Composite2Class[] Composite2;

        // Instance
        public class _Instance
        {
            public InstanceData[] Address;
            public InstanceData[] Destination;
            public InstanceData[] Source;
            public InstanceData[] Airline;
            public InstanceData[] Buyer;
            public InstanceData[] Seller;
            public InstanceData[] City;
            public InstanceData[] Composite1;
            public InstanceData[] Composite2;
            public InstanceData[] Name;
            public InstanceData[] likee;
            public InstanceData[] liker;
            public InstanceData[] Part;
            public InstanceData[] buy;
            public InstanceData[] sell;
            public InstanceData[] State;
            public InstanceData[] Weather_Location;
            public InstanceData[] destination;
            public InstanceData[] source;
            public InstanceData[] age;
            public InstanceData[] begin;
            public InstanceData[] end;
            public InstanceData[] datetime;
            public InstanceData[] arrive;
            public InstanceData[] leave;
            public InstanceData[] dimension;
            public InstanceData[] length;
            public InstanceData[] width;
            public InstanceData[] email;
            public InstanceData[] receiver;
            public InstanceData[] sender;
            public InstanceData[] geographyV2;
            public InstanceData[] endloc;
            public InstanceData[] startloc;
            public InstanceData[] money;
            public InstanceData[] max;
            public InstanceData[] min;
            public InstanceData[] number;
            public InstanceData[] start;
            public InstanceData[] ordinalV2;
            public InstanceData[] endpos;
            public InstanceData[] startpos;
            public InstanceData[] percentage;
            public InstanceData[] maximum;
            public InstanceData[] minimum;
            public InstanceData[] person;
            public InstanceData[] from;
            public InstanceData[] to;
            public InstanceData[] personName;
            public InstanceData[] child;
            public InstanceData[] parent;
            public InstanceData[] phonenumber;
            public InstanceData[] newPhone;
            public InstanceData[] old;
            public InstanceData[] subject;
            public InstanceData[] extra;
            public InstanceData[] temperature;
            public InstanceData[] a;
            public InstanceData[] b;
            public InstanceData[] url;
            public InstanceData[] oldURL;
        }
        [JsonProperty("$instance")]
        public _Instance _instance;
    }
    [JsonProperty("entities")]
    public _Entities Entities;

    [JsonExtensionData(ReadData = true, WriteData = true)]
    public IDictionary<string, object> Properties {get; set; }

    public void Convert(dynamic result)
    {
        var app = JsonConvert.DeserializeObject<Contoso_App>(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MaxDepth = null }));
        Text = app.Text;
        AlteredText = app.AlteredText;
        Intents = app.Intents;
        Entities = app.Entities;
        Properties = app.Properties;
    }

    public (Intent intent, double score) TopIntent()
    {
        Intent maxIntent = Intent.None;
        var max = 0.0;
        foreach (var entry in Intents)
        {
            if (entry.Value.Score > max)
            {
                maxIntent = entry.Key;
                max = entry.Value.Score.Value;
            }
        }
        return (maxIntent, max);
    }
}
}
