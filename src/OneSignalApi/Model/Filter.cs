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
    /// Filter
    /// </summary>
    [DataContract(Name = "Filter")]
    public partial class Filter : IEquatable<Filter>, IValidatableObject
    {
        /// <summary>
        /// Operator of a filter expression.
        /// </summary>
        /// <value>Operator of a filter expression.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelationEnum
        {
            /// <summary>
            /// Enum GreaterThan for value: &gt;
            /// </summary>
            [EnumMember(Value = ">")]
            GreaterThan = 1,

            /// <summary>
            /// Enum LessThan for value: &lt;
            /// </summary>
            [EnumMember(Value = "<")]
            LessThan = 2,

            /// <summary>
            /// Enum Equal for value: &#x3D;
            /// </summary>
            [EnumMember(Value = "=")]
            Equal = 3,

            /// <summary>
            /// Enum NotEqual for value: !&#x3D;
            /// </summary>
            [EnumMember(Value = "!=")]
            NotEqual = 4,

            /// <summary>
            /// Enum Exists for value: exists
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists = 5,

            /// <summary>
            /// Enum NotExists for value: not_exists
            /// </summary>
            [EnumMember(Value = "not_exists")]
            NotExists = 6,

            /// <summary>
            /// Enum TimeElapsedGt for value: time_elapsed_gt
            /// </summary>
            [EnumMember(Value = "time_elapsed_gt")]
            TimeElapsedGt = 7,

            /// <summary>
            /// Enum TimeElapsedLt for value: time_elapsed_lt
            /// </summary>
            [EnumMember(Value = "time_elapsed_lt")]
            TimeElapsedLt = 8

        }


        /// <summary>
        /// Operator of a filter expression.
        /// </summary>
        /// <value>Operator of a filter expression.</value>
        [DataMember(Name = "relation", IsRequired = true, EmitDefaultValue = false)]
        public RelationEnum Relation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Filter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="field">Name of the field to use as the first operand in the filter expression. (required).</param>
        /// <param name="key">If &#x60;field&#x60; is &#x60;tag&#x60;, this field is *required* to specify &#x60;key&#x60; inside the tags..</param>
        /// <param name="value">Constant value to use as the second operand in the filter expression. This value is *required* when the relation operator is a binary operator..</param>
        /// <param name="relation">Operator of a filter expression. (required).</param>
        public Filter(string field = default(string), string key = default(string), string value = default(string), RelationEnum relation = default(RelationEnum))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for Filter and cannot be null");
            }
            this.Field = field;
            this.Relation = relation;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Name of the field to use as the first operand in the filter expression.
        /// </summary>
        /// <value>Name of the field to use as the first operand in the filter expression.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// If &#x60;field&#x60; is &#x60;tag&#x60;, this field is *required* to specify &#x60;key&#x60; inside the tags.
        /// </summary>
        /// <value>If &#x60;field&#x60; is &#x60;tag&#x60;, this field is *required* to specify &#x60;key&#x60; inside the tags.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Constant value to use as the second operand in the filter expression. This value is *required* when the relation operator is a binary operator.
        /// </summary>
        /// <value>Constant value to use as the second operand in the filter expression. This value is *required* when the relation operator is a binary operator.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
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
            return this.Equals(input as Filter);
        }

        /// <summary>
        /// Returns true if Filter instances are equal
        /// </summary>
        /// <param name="input">Instance of Filter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Relation == input.Relation ||
                    this.Relation.Equals(input.Relation)
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
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Relation.GetHashCode();
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
