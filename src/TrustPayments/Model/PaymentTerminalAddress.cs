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
    /// PaymentTerminalAddress
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalAddress :  IEquatable<PaymentTerminalAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalAddress()
        {
        }

        /// <summary>
        /// The city, town or village.
        /// </summary>
        /// <value>The city, town or village.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; private set; }

        /// <summary>
        /// The two-letter country code (ISO 3166 format).
        /// </summary>
        /// <value>The two-letter country code (ISO 3166 format).</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; private set; }

        /// <summary>
        /// The dependent locality which is a sub-division of the state.
        /// </summary>
        /// <value>The dependent locality which is a sub-division of the state.</value>
        [DataMember(Name="dependentLocality", EmitDefaultValue=false)]
        public string DependentLocality { get; private set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// The family or last name.
        /// </summary>
        /// <value>The family or last name.</value>
        [DataMember(Name="familyName", EmitDefaultValue=false)]
        public string FamilyName { get; private set; }

        /// <summary>
        /// The given or first name.
        /// </summary>
        /// <value>The given or first name.</value>
        [DataMember(Name="givenName", EmitDefaultValue=false)]
        public string GivenName { get; private set; }

        /// <summary>
        /// The phone number of a mobile phone.
        /// </summary>
        /// <value>The phone number of a mobile phone.</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; private set; }

        /// <summary>
        /// The organization&#39;s name.
        /// </summary>
        /// <value>The organization&#39;s name.</value>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; private set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// The name of the region, typically a state, county, province or prefecture.
        /// </summary>
        /// <value>The name of the region, typically a state, county, province or prefecture.</value>
        [DataMember(Name="postalState", EmitDefaultValue=false)]
        public string PostalState { get; private set; }

        /// <summary>
        /// The postal code, also known as ZIP, postcode, etc.
        /// </summary>
        /// <value>The postal code, also known as ZIP, postcode, etc.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; private set; }

        /// <summary>
        /// The salutation e.g. Mrs, Mr, Dr.
        /// </summary>
        /// <value>The salutation e.g. Mrs, Mr, Dr.</value>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; private set; }

        /// <summary>
        /// The sorting code identifying the post office where the PO Box is located.
        /// </summary>
        /// <value>The sorting code identifying the post office where the PO Box is located.</value>
        [DataMember(Name="sortingCode", EmitDefaultValue=false)]
        public string SortingCode { get; private set; }

        /// <summary>
        /// The street or PO Box.
        /// </summary>
        /// <value>The street or PO Box.</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DependentLocality: ").Append(DependentLocality).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalState: ").Append(PostalState).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  SortingCode: ").Append(SortingCode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return this.Equals(input as PaymentTerminalAddress);
        }

        /// <summary>
        /// Returns true if PaymentTerminalAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.DependentLocality == input.DependentLocality ||
                    (this.DependentLocality != null &&
                    this.DependentLocality.Equals(input.DependentLocality))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PostalState == input.PostalState ||
                    (this.PostalState != null &&
                    this.PostalState.Equals(input.PostalState))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.SortingCode == input.SortingCode ||
                    (this.SortingCode != null &&
                    this.SortingCode.Equals(input.SortingCode))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.DependentLocality != null)
                    hashCode = hashCode * 59 + this.DependentLocality.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PostalState != null)
                    hashCode = hashCode * 59 + this.PostalState.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Salutation != null)
                    hashCode = hashCode * 59 + this.Salutation.GetHashCode();
                if (this.SortingCode != null)
                    hashCode = hashCode * 59 + this.SortingCode.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                return hashCode;
            }
        }

    }

}
