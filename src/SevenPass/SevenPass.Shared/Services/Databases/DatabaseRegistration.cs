﻿using System;

namespace SevenPass.Services.Databases
{
    public sealed class DatabaseRegistration
    {
        /// <summary>
        /// Gets or sets the database ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the database name.
        /// </summary>
        public string Name { get; set; }
    }
}