/* 
 * Authorization API
 *
 * Authorization API
 *
 * OpenAPI spec version: 9.0.000.00.662
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
    /// ClientDetails
    /// </summary>
    [DataContract]
    public partial class ClientDetails :  IEquatable<ClientDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDetails" /> class.
        /// </summary>
        /// <param name="AccessTokenValiditySeconds">AccessTokenValiditySeconds.</param>
        /// <param name="Authorities">Authorities.</param>
        /// <param name="AuthorizedGrantTypes">AuthorizedGrantTypes.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="ClientSecret">ClientSecret.</param>
        /// <param name="RefreshTokenValiditySeconds">RefreshTokenValiditySeconds.</param>
        /// <param name="RegisteredRedirectUri">RegisteredRedirectUri.</param>
        /// <param name="ResourceIds">ResourceIds.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="Scoped">Scoped.</param>
        /// <param name="SecretRequired">SecretRequired.</param>
        public ClientDetails(int? AccessTokenValiditySeconds = default(int?), GrantedAuthority Authorities = default(GrantedAuthority), List<string> AuthorizedGrantTypes = default(List<string>), string ClientId = default(string), string ClientSecret = default(string), int? RefreshTokenValiditySeconds = default(int?), List<string> RegisteredRedirectUri = default(List<string>), List<string> ResourceIds = default(List<string>), List<string> Scope = default(List<string>), bool? Scoped = default(bool?), bool? SecretRequired = default(bool?))
        {
            this.AccessTokenValiditySeconds = AccessTokenValiditySeconds;
            this.Authorities = Authorities;
            this.AuthorizedGrantTypes = AuthorizedGrantTypes;
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.RefreshTokenValiditySeconds = RefreshTokenValiditySeconds;
            this.RegisteredRedirectUri = RegisteredRedirectUri;
            this.ResourceIds = ResourceIds;
            this.Scope = Scope;
            this.Scoped = Scoped;
            this.SecretRequired = SecretRequired;
        }
        
        /// <summary>
        /// Gets or Sets AccessTokenValiditySeconds
        /// </summary>
        [DataMember(Name="accessTokenValiditySeconds", EmitDefaultValue=false)]
        public int? AccessTokenValiditySeconds { get; set; }

        /// <summary>
        /// Gets or Sets Authorities
        /// </summary>
        [DataMember(Name="authorities", EmitDefaultValue=false)]
        public GrantedAuthority Authorities { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedGrantTypes
        /// </summary>
        [DataMember(Name="authorizedGrantTypes", EmitDefaultValue=false)]
        public List<string> AuthorizedGrantTypes { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenValiditySeconds
        /// </summary>
        [DataMember(Name="refreshTokenValiditySeconds", EmitDefaultValue=false)]
        public int? RefreshTokenValiditySeconds { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredRedirectUri
        /// </summary>
        [DataMember(Name="registeredRedirectUri", EmitDefaultValue=false)]
        public List<string> RegisteredRedirectUri { get; set; }

        /// <summary>
        /// Gets or Sets ResourceIds
        /// </summary>
        [DataMember(Name="resourceIds", EmitDefaultValue=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// Gets or Sets Scoped
        /// </summary>
        [DataMember(Name="scoped", EmitDefaultValue=false)]
        public bool? Scoped { get; set; }

        /// <summary>
        /// Gets or Sets SecretRequired
        /// </summary>
        [DataMember(Name="secretRequired", EmitDefaultValue=false)]
        public bool? SecretRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientDetails {\n");
            sb.Append("  AccessTokenValiditySeconds: ").Append(AccessTokenValiditySeconds).Append("\n");
            sb.Append("  Authorities: ").Append(Authorities).Append("\n");
            sb.Append("  AuthorizedGrantTypes: ").Append(AuthorizedGrantTypes).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RefreshTokenValiditySeconds: ").Append(RefreshTokenValiditySeconds).Append("\n");
            sb.Append("  RegisteredRedirectUri: ").Append(RegisteredRedirectUri).Append("\n");
            sb.Append("  ResourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Scoped: ").Append(Scoped).Append("\n");
            sb.Append("  SecretRequired: ").Append(SecretRequired).Append("\n");
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
            return this.Equals(obj as ClientDetails);
        }

        /// <summary>
        /// Returns true if ClientDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessTokenValiditySeconds == other.AccessTokenValiditySeconds ||
                    this.AccessTokenValiditySeconds != null &&
                    this.AccessTokenValiditySeconds.Equals(other.AccessTokenValiditySeconds)
                ) && 
                (
                    this.Authorities == other.Authorities ||
                    this.Authorities != null &&
                    this.Authorities.Equals(other.Authorities)
                ) && 
                (
                    this.AuthorizedGrantTypes == other.AuthorizedGrantTypes ||
                    this.AuthorizedGrantTypes != null &&
                    this.AuthorizedGrantTypes.SequenceEqual(other.AuthorizedGrantTypes)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    this.RefreshTokenValiditySeconds == other.RefreshTokenValiditySeconds ||
                    this.RefreshTokenValiditySeconds != null &&
                    this.RefreshTokenValiditySeconds.Equals(other.RefreshTokenValiditySeconds)
                ) && 
                (
                    this.RegisteredRedirectUri == other.RegisteredRedirectUri ||
                    this.RegisteredRedirectUri != null &&
                    this.RegisteredRedirectUri.SequenceEqual(other.RegisteredRedirectUri)
                ) && 
                (
                    this.ResourceIds == other.ResourceIds ||
                    this.ResourceIds != null &&
                    this.ResourceIds.SequenceEqual(other.ResourceIds)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.SequenceEqual(other.Scope)
                ) && 
                (
                    this.Scoped == other.Scoped ||
                    this.Scoped != null &&
                    this.Scoped.Equals(other.Scoped)
                ) && 
                (
                    this.SecretRequired == other.SecretRequired ||
                    this.SecretRequired != null &&
                    this.SecretRequired.Equals(other.SecretRequired)
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
                if (this.AccessTokenValiditySeconds != null)
                    hash = hash * 59 + this.AccessTokenValiditySeconds.GetHashCode();
                if (this.Authorities != null)
                    hash = hash * 59 + this.Authorities.GetHashCode();
                if (this.AuthorizedGrantTypes != null)
                    hash = hash * 59 + this.AuthorizedGrantTypes.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                if (this.RefreshTokenValiditySeconds != null)
                    hash = hash * 59 + this.RefreshTokenValiditySeconds.GetHashCode();
                if (this.RegisteredRedirectUri != null)
                    hash = hash * 59 + this.RegisteredRedirectUri.GetHashCode();
                if (this.ResourceIds != null)
                    hash = hash * 59 + this.ResourceIds.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.Scoped != null)
                    hash = hash * 59 + this.Scoped.GetHashCode();
                if (this.SecretRequired != null)
                    hash = hash * 59 + this.SecretRequired.GetHashCode();
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
