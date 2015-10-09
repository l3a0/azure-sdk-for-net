namespace Microsoft.Azure.Management.Scheduler.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class JobCollectionQuota
    {
        /// <summary>
        /// Gets or set the maximum job count.
        /// </summary>
        [JsonProperty(PropertyName = "maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum job occurrence.
        /// </summary>
        [JsonProperty(PropertyName = "maxJobOccurrence")]
        public int? MaxJobOccurrence { get; set; }

        /// <summary>
        /// Gets or set the maximum recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "maxRecurrence")]
        public JobMaxRecurrence MaxRecurrence { get; set; }

    }
}