/* 
 * Authentication API
 *
 * Authentication API
 *
 * OpenAPI spec version: 9.0.000.00.859
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
using SwaggerDateConverter = Genesys.Authentication.Client.SwaggerDateConverter;

namespace Genesys.Authentication.Model
{
    /// <summary>
    /// DefaultOAuth2AccessToken
    /// </summary>
    [DataContract]
    public partial class DefaultOAuth2AccessToken :  IEquatable<DefaultOAuth2AccessToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultOAuth2AccessToken" /> class.
        /// </summary>
        /// <param name="AccessToken">the access token.</param>
        /// <param name="ExpiresIn">timeout (in seconds) before token expiration.</param>
        /// <param name="RefreshToken">the refresh token.</param>
        /// <param name="Scope">scope of token.</param>
        /// <param name="TokenType">the type of access token, always &#39;bearer&#39;.</param>
        public DefaultOAuth2AccessToken(string AccessToken = default(string), int? ExpiresIn = default(int?), string RefreshToken = default(string), string Scope = default(string), string TokenType = default(string))
        {
            this.AccessToken = AccessToken;
            this.ExpiresIn = ExpiresIn;
            this.RefreshToken = RefreshToken;
            this.Scope = Scope;
            this.TokenType = TokenType;
        }
        
        /// <summary>
        /// the access token
        /// </summary>
        /// <value>the access token</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// timeout (in seconds) before token expiration
        /// </summary>
        /// <value>timeout (in seconds) before token expiration</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// the refresh token
        /// </summary>
        /// <value>the refresh token</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// scope of token
        /// </summary>
        /// <value>scope of token</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// the type of access token, always &#39;bearer&#39;
        /// </summary>
        /// <value>the type of access token, always &#39;bearer&#39;</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultOAuth2AccessToken {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefaultOAuth2AccessToken);
        }

        /// <summary>
        /// Returns true if DefaultOAuth2AccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of DefaultOAuth2AccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultOAuth2AccessToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                return hashCode;
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
