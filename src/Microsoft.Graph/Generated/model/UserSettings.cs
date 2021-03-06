// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User Settings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserSettings : Entity
    {
    
		///<summary>
		/// The UserSettings constructor
		///</summary>
        public UserSettings()
        {
            this.ODataType = "microsoft.graph.userSettings";
        }
	
        /// <summary>
        /// Gets or sets contribution to content discovery as organization disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contributionToContentDiscoveryAsOrganizationDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets contribution to content discovery disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contributionToContentDiscoveryDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets shift preferences.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shiftPreferences", Required = Newtonsoft.Json.Required.Default)]
        public ShiftPreferences ShiftPreferences { get; set; }
    
    }
}

