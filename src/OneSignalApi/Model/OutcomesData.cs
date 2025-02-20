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
    /// OutcomesData
    /// </summary>
    [DataContract(Name = "OutcomesData")]
    public partial class OutcomesData : IEquatable<OutcomesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomesData" /> class.
        /// </summary>
        /// <param name="outcomes">outcomes.</param>
        public OutcomesData(List<OutcomeData> outcomes = default(List<OutcomeData>))
        {
            this.Outcomes = outcomes;
        }

        /// <summary>
        /// Gets or Sets Outcomes
        /// </summary>
        [DataMember(Name = "outcomes", EmitDefaultValue = false)]
        public List<OutcomeData> Outcomes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutcomesData {\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
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
            return this.Equals(input as OutcomesData);
        }

        /// <summary>
        /// Returns true if OutcomesData instances are equal
        /// </summary>
        /// <param name="input">Instance of OutcomesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomesData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Outcomes == input.Outcomes ||
                    this.Outcomes != null &&
                    input.Outcomes != null &&
                    this.Outcomes.SequenceEqual(input.Outcomes)
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
                if (this.Outcomes != null)
                {
                    hashCode = (hashCode * 59) + this.Outcomes.GetHashCode();
                }
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
