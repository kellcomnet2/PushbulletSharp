﻿using System;

namespace PushbulletSharp.Models.Responses
{
    public class Subscription
    {
        /// <summary>
        /// Gets or sets the iden.
        /// </summary>
        /// <value>
        /// The iden.
        /// </value>
        public string iden { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public DateTime created { get; set; }

        /// <summary>
        /// Gets or sets the modified.
        /// </summary>
        /// <value>
        /// The modified.
        /// </value>
        public DateTime modified { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Subscription"/> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool active { get; set; }

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>
        /// The channel.
        /// </value>
        public Channel channel { get; set; }
    }
}