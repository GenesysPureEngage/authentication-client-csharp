/* 
 * Authorization API
 *
 * Authorization API
 *
 * OpenAPI spec version: 9.0.000.00.687
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
using SwaggerDateConverter = Genesys.Authorization.Client.SwaggerDateConverter;

namespace Genesys.Authorization.Model
{
    /// <summary>
    /// ChangePasswordOperation
    /// </summary>
    [DataContract]
    public partial class ChangePasswordOperation :  IEquatable<ChangePasswordOperation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordOperation" /> class.
        /// </summary>
        /// <param name="NewPassword">NewPassword.</param>
        /// <param name="OldPassword">OldPassword.</param>
        /// <param name="UserName">UserName.</param>
        public ChangePasswordOperation(string NewPassword = default(string), string OldPassword = default(string), string UserName = default(string))
        {
            this.NewPassword = NewPassword;
            this.OldPassword = OldPassword;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="oldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordOperation {\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ChangePasswordOperation);
        }

        /// <summary>
        /// Returns true if ChangePasswordOperation instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePasswordOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordOperation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.OldPassword == other.OldPassword ||
                    this.OldPassword != null &&
                    this.OldPassword.Equals(other.OldPassword)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                if (this.OldPassword != null)
                    hash = hash * 59 + this.OldPassword.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
