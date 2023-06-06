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
    /// WebhookListenerEntity
    /// </summary>
    [DataContract]
    public partial class WebhookListenerEntity :  IEquatable<WebhookListenerEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WebhookListenerEntity()
        {
        }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name used to identify the webhook listener entity.
        /// </summary>
        /// <value>The name used to identify the webhook listener entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// The name used to programmatically identify the webhook listener entity.
        /// </summary>
        /// <value>The name used to programmatically identify the webhook listener entity.</value>
        [DataMember(Name="technicalName", EmitDefaultValue=false)]
        public string TechnicalName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookListenerEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TechnicalName: ").Append(TechnicalName).Append("\n");
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
            return this.Equals(input as WebhookListenerEntity);
        }

        /// <summary>
        /// Returns true if WebhookListenerEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookListenerEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListenerEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.TechnicalName == input.TechnicalName ||
                    (this.TechnicalName != null &&
                    this.TechnicalName.Equals(input.TechnicalName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TechnicalName != null)
                    hashCode = hashCode * 59 + this.TechnicalName.GetHashCode();
                return hashCode;
            }
        }

    }

}
