// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store filesystem file status list information response.
    /// </summary>
    public partial class FileStatusesResult
    {
        /// <summary>
        /// Initializes a new instance of the FileStatusesResult class.
        /// </summary>
        public FileStatusesResult() { }

        /// <summary>
        /// Initializes a new instance of the FileStatusesResult class.
        /// </summary>
        public FileStatusesResult(FileStatuses fileStatuses = default(FileStatuses))
        {
            FileStatuses = fileStatuses;
        }

        /// <summary>
        /// Gets or sets the object representing the list of file statuses
        /// </summary>
        [JsonProperty(PropertyName = "FileStatuses")]
        public FileStatuses FileStatuses { get; set; }

    }
}