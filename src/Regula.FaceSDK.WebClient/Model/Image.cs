/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Regula.FaceSDK.WebClient.Client.OpenAPIDateConverter;

namespace Regula.FaceSDK.WebClient.Model
{
    /// <summary>
    /// Image in the response.
    /// </summary>
    [DataContract]
    public partial class Image :  IEquatable<Image>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="id">Response image ID. The list is sorted by decreasing ID value..</param>
        /// <param name="contentType">Original media type of the returned image..</param>
        /// <param name="createdAt">Returned image creation date..</param>
        /// <param name="updatedAt">Returned image update date..</param>
        /// <param name="path">Returned image path..</param>
        /// <param name="url">Returned image URL..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        public Image(string id = default(string), string contentType = default(string), string createdAt = default(string), string updatedAt = default(string), string path = default(string), string url = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.ContentType = contentType;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Path = path;
            this.Url = url;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Response image ID. The list is sorted by decreasing ID value.
        /// </summary>
        /// <value>Response image ID. The list is sorted by decreasing ID value.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Original media type of the returned image.
        /// </summary>
        /// <value>Original media type of the returned image.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returned image creation date.
        /// </summary>
        /// <value>Returned image creation date.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returned image update date.
        /// </summary>
        /// <value>Returned image update date.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returned image path.
        /// </summary>
        /// <value>Returned image path.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returned image URL.
        /// </summary>
        /// <value>Returned image URL.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as Image);
        }

        /// <summary>
        /// Returns true if Image instances are equal
        /// </summary>
        /// <param name="input">Instance of Image to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Image input)
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
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
