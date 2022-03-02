﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Microsoft.Bot.Connector.Schema
{
    /// <summary>
    /// A receipt card.
    /// </summary>
    public partial class ReceiptCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptCard"/> class.
        /// </summary>
        public ReceiptCard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptCard"/> class.
        /// </summary>
        /// <param name="title">Title of the card.</param>
        /// <param name="facts">Array of Fact objects.</param>
        /// <param name="items">Array of Receipt Items.</param>
        /// <param name="tap">This action will be activated when user taps on
        /// the card.</param>
        /// <param name="total">Total amount of money paid (or to be
        /// paid).</param>
        /// <param name="tax">Total amount of tax paid (or to be paid).</param>
        /// <param name="vat">Total amount of VAT paid (or to be paid).</param>
        /// <param name="buttons">Set of actions applicable to the current
        /// card.</param>
        public ReceiptCard(string title = default, IList<Fact> facts = default, IList<ReceiptItem> items = default, CardAction tap = default, string total = default, string tax = default, string vat = default, IList<CardAction> buttons = default)
        {
            Title = title;
            Facts = facts;
            Items = items;
            Tap = tap;
            Total = total;
            Tax = tax;
            Vat = vat;
            Buttons = buttons;
            CustomInit();
        }

        /// <summary>
        /// Gets or sets title of the card.
        /// </summary>
        /// <value>The title of the card.</value>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets array of Fact objects.
        /// </summary>
        /// <value>The collection of <see cref="Fact"/>'s.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("facts")]
        public IList<Fact> Facts { get; set; }

        /// <summary>
        /// Gets or sets array of Receipt Items.
        /// </summary>
        /// <value>The receipt items.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("items")]
        public IList<ReceiptItem> Items { get; set; }

        /// <summary>
        /// Gets or sets this action will be activated when user taps on the
        /// card.
        /// </summary>
        /// <value>The card action that will be activated when the user taps on the card.</value>
        [JsonPropertyName("tap")]
        public CardAction Tap { get; set; }

        /// <summary>
        /// Gets or sets total amount of money paid (or to be paid).
        /// </summary>
        /// <value>The total amount of money paid (or to be paid).</value>
        [JsonPropertyName("total")]
        public string Total { get; set; }

        /// <summary>
        /// Gets or sets total amount of tax paid (or to be paid).
        /// </summary>
        /// <value>The total amount of tax.</value>
        [JsonPropertyName("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// Gets or sets total amount of VAT paid (or to be paid).
        /// </summary>
        /// <value>The total amount of VAT.</value>
        [JsonPropertyName("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// Gets or sets set of actions applicable to the current card.
        /// </summary>
        /// <value>The actions applicable to the current card.</value>
        [SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Property setter is required for the collection to be deserialized")]
        [JsonPropertyName("buttons")]
        public IList<CardAction> Buttons { get; set; }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        private void CustomInit()
        {
        }
    }
}