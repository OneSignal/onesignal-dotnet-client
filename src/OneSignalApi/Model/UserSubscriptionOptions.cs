/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.3.0
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
    /// UserSubscriptionOptions
    /// </summary>
    [DataContract(Name = "User_subscription_options")]
    public partial class UserSubscriptionOptions : IEquatable<UserSubscriptionOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscriptionOptions" /> class.
        /// </summary>
        /// <param name="retainPreviousOwner">retainPreviousOwner.</param>
        public UserSubscriptionOptions(bool retainPreviousOwner = default(bool))
        {
            this.RetainPreviousOwner = retainPreviousOwner;
        }

        /// <summary>
        /// Gets or Sets RetainPreviousOwner
        /// </summary>
        [DataMember(Name = "retain_previous_owner", EmitDefaultValue = true)]
        public bool RetainPreviousOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSubscriptionOptions {\n");
            sb.Append("  RetainPreviousOwner: ").Append(RetainPreviousOwner).Append("\n");
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
            return this.Equals(input as UserSubscriptionOptions);
        }

        /// <summary>
        /// Returns true if UserSubscriptionOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSubscriptionOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSubscriptionOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RetainPreviousOwner == input.RetainPreviousOwner ||
                    this.RetainPreviousOwner.Equals(input.RetainPreviousOwner)
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
                hashCode = (hashCode * 59) + this.RetainPreviousOwner.GetHashCode();
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
