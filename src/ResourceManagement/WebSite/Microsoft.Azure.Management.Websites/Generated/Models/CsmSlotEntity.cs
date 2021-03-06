// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing deployment slot parameters
    /// </summary>
    public partial class CsmSlotEntity
    {
        /// <summary>
        /// Initializes a new instance of the CsmSlotEntity class.
        /// </summary>
        public CsmSlotEntity() { }

        /// <summary>
        /// Initializes a new instance of the CsmSlotEntity class.
        /// </summary>
        public CsmSlotEntity(string targetSlot = default(string), bool? preserveVnet = default(bool?))
        {
            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
        }

        /// <summary>
        /// Set the destination deployment slot during swap operation
        /// </summary>
        [JsonProperty(PropertyName = "targetSlot")]
        public string TargetSlot { get; set; }

        /// <summary>
        /// Get or set the flag indicating it should preserve VNet to the slot
        /// during swap
        /// </summary>
        [JsonProperty(PropertyName = "preserveVnet")]
        public bool? PreserveVnet { get; set; }

    }
}
