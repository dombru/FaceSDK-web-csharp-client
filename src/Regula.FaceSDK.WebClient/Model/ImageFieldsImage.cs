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
    /// Uploaded image.
    /// </summary>
    [DataContract]
    public partial class ImageFieldsImage :  IEquatable<ImageFieldsImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFieldsImage" /> class.
        /// </summary>
        /// <param name="contentType">Original media type of the uploaded image..</param>
        /// <param name="content">Base64 encoded image..</param>
        /// <param name="imageUrl">Image URL, can be a link to Amazon S3, Google Storage, File System, or HTTP(S)..</param>
        /// <param name="resizeOptions">resizeOptions.</param>
        public ImageFieldsImage(string contentType = default(string), byte[] content = default(byte[]), string imageUrl = default(string), ResizeOptions resizeOptions = default(ResizeOptions))
        {
            this.ContentType = contentType;
            this.Content = content;
            this.ImageUrl = imageUrl;
            this.ResizeOptions = resizeOptions;
        }

        /// <summary>
        /// Original media type of the uploaded image.
        /// </summary>
        /// <value>Original media type of the uploaded image.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Base64 encoded image.
        /// </summary>
        /// <value>Base64 encoded image.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Image URL, can be a link to Amazon S3, Google Storage, File System, or HTTP(S).
        /// </summary>
        /// <value>Image URL, can be a link to Amazon S3, Google Storage, File System, or HTTP(S).</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets ResizeOptions
        /// </summary>
        [DataMember(Name="resizeOptions", EmitDefaultValue=false)]
        public ResizeOptions ResizeOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageFieldsImage {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ResizeOptions: ").Append(ResizeOptions).Append("\n");
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
            return this.Equals(input as ImageFieldsImage);
        }

        /// <summary>
        /// Returns true if ImageFieldsImage instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageFieldsImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageFieldsImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ResizeOptions == input.ResizeOptions ||
                    (this.ResizeOptions != null &&
                    this.ResizeOptions.Equals(input.ResizeOptions))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ResizeOptions != null)
                    hashCode = hashCode * 59 + this.ResizeOptions.GetHashCode();
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
