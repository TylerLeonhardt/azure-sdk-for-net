// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Qos Traffic Profiler IP Range properties.
    /// </summary>
    public partial class QosIpRange
    {
        /// <summary>
        /// Initializes a new instance of the QosIpRange class.
        /// </summary>
        public QosIpRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QosIpRange class.
        /// </summary>
        /// <param name="startIP">Start IP Address.</param>
        /// <param name="endIP">End IP Address.</param>
        public QosIpRange(string startIP = default(string), string endIP = default(string))
        {
            StartIP = startIP;
            EndIP = endIP;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start IP Address.
        /// </summary>
        [JsonProperty(PropertyName = "startIP")]
        public string StartIP { get; set; }

        /// <summary>
        /// Gets or sets end IP Address.
        /// </summary>
        [JsonProperty(PropertyName = "endIP")]
        public string EndIP { get; set; }

    }
}
