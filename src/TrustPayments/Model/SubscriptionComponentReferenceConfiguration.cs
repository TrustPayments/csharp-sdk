using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TrustPayments.Client.SwaggerDateConverter;

namespace TrustPayments.Model
{
    /// <summary>
    /// The component reference configuration adjusts the product component for a particular subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionComponentReferenceConfiguration :  IEquatable<SubscriptionComponentReferenceConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentReferenceConfiguration" /> class.
        /// </summary>
        public SubscriptionComponentReferenceConfiguration()
        {
        }

        /// <summary>
        /// Gets or Sets ProductComponentReferenceId
        /// </summary>
        [DataMember(Name="productComponentReferenceId", EmitDefaultValue=true)]
        public long? ProductComponentReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionComponentReferenceConfiguration {\n");
            sb.Append("  ProductComponentReferenceId: ").Append(ProductComponentReferenceId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionComponentReferenceConfiguration);
        }

        /// <summary>
        /// Returns true if SubscriptionComponentReferenceConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionComponentReferenceConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionComponentReferenceConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductComponentReferenceId == input.ProductComponentReferenceId ||
                    (this.ProductComponentReferenceId != null &&
                    this.ProductComponentReferenceId.Equals(input.ProductComponentReferenceId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.ProductComponentReferenceId != null)
                    hashCode = hashCode * 59 + this.ProductComponentReferenceId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                return hashCode;
            }
        }

    }

}
