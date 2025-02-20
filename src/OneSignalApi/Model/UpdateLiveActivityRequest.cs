/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.4.0
 * Contact: devrel@onesignal.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OneSignalApi.Client.OpenAPIDateConverter;

namespace OneSignalApi.Model
{
    /// <summary>
    /// UpdateLiveActivityRequest
    /// </summary>
    [DataContract(Name = "UpdateLiveActivityRequest")]
    public partial class UpdateLiveActivityRequest : IEquatable<UpdateLiveActivityRequest>, IValidatableObject
    {
        /// <summary>
        /// Type of live activity
        /// </summary>
        /// <value>Type of live activity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Headings for value: headings
            /// </summary>
            [EnumMember(Value = "headings")]
            Headings = 1,

            /// <summary>
            /// Enum Contents for value: contents
            /// </summary>
            [EnumMember(Value = "contents")]
            Contents = 2,

            /// <summary>
            /// Enum IosSound for value: ios_sound
            /// </summary>
            [EnumMember(Value = "ios_sound")]
            IosSound = 3,

            /// <summary>
            /// Enum PriorityLevel for value: priority_level
            /// </summary>
            [EnumMember(Value = "priority_level")]
            PriorityLevel = 4

        }


        /// <summary>
        /// Type of live activity
        /// </summary>
        /// <value>Type of live activity</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Defines Event
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 1,

            /// <summary>
            /// Enum End for value: end
            /// </summary>
            [EnumMember(Value = "end")]
            End = 2

        }


        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveActivityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateLiveActivityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveActivityRequest" /> class.
        /// </summary>
        /// <param name="name">Type of live activity (required).</param>
        /// <param name="_event">_event (required).</param>
        /// <param name="eventUpdates">eventUpdates (required).</param>
        /// <param name="dismissAt">Timestamp; only allowed if event is \&quot;end\&quot;.</param>
        public UpdateLiveActivityRequest(NameEnum name = default(NameEnum), EventEnum _event = default(EventEnum), Object eventUpdates = default(Object), decimal dismissAt = default(decimal))
        {
            this.Name = name;
            this.Event = _event;
            // to ensure "eventUpdates" is required (not null)
            if (eventUpdates == null)
            {
                throw new ArgumentNullException("eventUpdates is a required property for UpdateLiveActivityRequest and cannot be null");
            }
            this.EventUpdates = eventUpdates;
            this.DismissAt = dismissAt;
        }

        /// <summary>
        /// Gets or Sets EventUpdates
        /// </summary>
        [DataMember(Name = "event_updates", IsRequired = true, EmitDefaultValue = false)]
        public Object EventUpdates { get; set; }

        /// <summary>
        /// Timestamp; only allowed if event is \&quot;end\&quot;
        /// </summary>
        /// <value>Timestamp; only allowed if event is \&quot;end\&quot;</value>
        [DataMember(Name = "dismiss_at", EmitDefaultValue = false)]
        public decimal DismissAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateLiveActivityRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  EventUpdates: ").Append(EventUpdates).Append("\n");
            sb.Append("  DismissAt: ").Append(DismissAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLiveActivityRequest);
        }

        /// <summary>
        /// Returns true if UpdateLiveActivityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLiveActivityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLiveActivityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Event == input.Event ||
                    this.Event.Equals(input.Event)
                ) && 
                (
                    this.EventUpdates == input.EventUpdates ||
                    (this.EventUpdates != null &&
                    this.EventUpdates.Equals(input.EventUpdates))
                ) && 
                (
                    this.DismissAt == input.DismissAt ||
                    this.DismissAt.Equals(input.DismissAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                hashCode = (hashCode * 59) + this.Event.GetHashCode();
                if (this.EventUpdates != null)
                {
                    hashCode = (hashCode * 59) + this.EventUpdates.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DismissAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
