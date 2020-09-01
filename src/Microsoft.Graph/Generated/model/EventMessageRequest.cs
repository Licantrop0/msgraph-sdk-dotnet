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
    /// The type Event Message Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EventMessageRequestObject : EventMessage
    {
    
		///<summary>
		/// The EventMessageRequest constructor
		///</summary>
        public EventMessageRequestObject()
        {
            this.ODataType = "microsoft.graph.eventMessageRequest";
        }
	
        /// <summary>
        /// Gets or sets allow new time proposals.
        /// True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowNewTimeProposals", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowNewTimeProposals { get; set; }
    
        /// <summary>
        /// Gets or sets meeting request type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingRequestType", Required = Newtonsoft.Json.Required.Default)]
        public MeetingRequestType? MeetingRequestType { get; set; }
    
        /// <summary>
        /// Gets or sets previous end date time.
        /// If the meeting update changes the meeting end time, this property specifies the previous meeting end time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone PreviousEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets previous location.
        /// If the meeting update changes the meeting location, this property specifies the previous meeting location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousLocation", Required = Newtonsoft.Json.Required.Default)]
        public Location PreviousLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous start date time.
        /// If the meeting update changes the meeting start time, this property specifies the previous meeting start time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone PreviousStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// Set to true if the sender would like the invitee to send a response to the requested meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseRequested", Required = Newtonsoft.Json.Required.Default)]
        public bool? ResponseRequested { get; set; }
    
    }
}

