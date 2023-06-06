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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public AccountState? State { get; private set; }
        /// <summary>
        /// The account&#39;s type which defines its role and capabilities.
        /// </summary>
        /// <value>The account&#39;s type which defines its role and capabilities.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public AccountType? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Account()
        {
        }

        /// <summary>
        /// Whether this account and all its parent accounts are active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }

        /// <summary>
        /// Whether this account and all its parent accounts are active or restricted active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active or restricted active.</value>
        [DataMember(Name="activeOrRestrictedActive", EmitDefaultValue=false)]
        public bool? ActiveOrRestrictedActive { get; private set; }

        /// <summary>
        /// The ID of the user the account was created by.
        /// </summary>
        /// <value>The ID of the user the account was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the account was created.
        /// </summary>
        /// <value>The date and time when the account was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID of a user the account was deleted by.
        /// </summary>
        /// <value>The ID of a user the account was deleted by.</value>
        [DataMember(Name="deletedBy", EmitDefaultValue=false)]
        public long? DeletedBy { get; private set; }

        /// <summary>
        /// The date and time when the account was deleted.
        /// </summary>
        /// <value>The date and time when the account was deleted.</value>
        [DataMember(Name="deletedOn", EmitDefaultValue=false)]
        public DateTime? DeletedOn { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The date and time when the object was last modified.
        /// </summary>
        /// <value>The date and time when the object was last modified.</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// The name used to identify the account.
        /// </summary>
        /// <value>The name used to identify the account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The parent account responsible for administering this account.
        /// </summary>
        /// <value>The parent account responsible for administering this account.</value>
        [DataMember(Name="parentAccount", EmitDefaultValue=false)]
        public Account ParentAccount { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Whether this account and all its parent accounts are active or restricted active. There is at least one account that is restricted active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active or restricted active. There is at least one account that is restricted active.</value>
        [DataMember(Name="restrictedActive", EmitDefaultValue=false)]
        public bool? RestrictedActive { get; private set; }

        /// <summary>
        /// The scope that the account belongs to.
        /// </summary>
        /// <value>The scope that the account belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public long? Scope { get; private set; }


        /// <summary>
        /// The number of sub-accounts that can be created within this account.
        /// </summary>
        /// <value>The number of sub-accounts that can be created within this account.</value>
        [DataMember(Name="subaccountLimit", EmitDefaultValue=false)]
        public long? SubaccountLimit { get; private set; }


        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ActiveOrRestrictedActive: ").Append(ActiveOrRestrictedActive).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeletedOn: ").Append(DeletedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  RestrictedActive: ").Append(RestrictedActive).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ActiveOrRestrictedActive == input.ActiveOrRestrictedActive ||
                    (this.ActiveOrRestrictedActive != null &&
                    this.ActiveOrRestrictedActive.Equals(input.ActiveOrRestrictedActive))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeletedOn == input.DeletedOn ||
                    (this.DeletedOn != null &&
                    this.DeletedOn.Equals(input.DeletedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentAccount == input.ParentAccount ||
                    (this.ParentAccount != null &&
                    this.ParentAccount.Equals(input.ParentAccount))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.RestrictedActive == input.RestrictedActive ||
                    (this.RestrictedActive != null &&
                    this.RestrictedActive.Equals(input.RestrictedActive))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SubaccountLimit == input.SubaccountLimit ||
                    (this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(input.SubaccountLimit))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ActiveOrRestrictedActive != null)
                    hashCode = hashCode * 59 + this.ActiveOrRestrictedActive.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DeletedBy != null)
                    hashCode = hashCode * 59 + this.DeletedBy.GetHashCode();
                if (this.DeletedOn != null)
                    hashCode = hashCode * 59 + this.DeletedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentAccount != null)
                    hashCode = hashCode * 59 + this.ParentAccount.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.RestrictedActive != null)
                    hashCode = hashCode * 59 + this.RestrictedActive.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubaccountLimit != null)
                    hashCode = hashCode * 59 + this.SubaccountLimit.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
