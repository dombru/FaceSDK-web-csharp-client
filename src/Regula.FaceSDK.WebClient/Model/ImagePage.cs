/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 4.1.3
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
    /// ImagePage
    /// </summary>
    [DataContract]
    public partial class ImagePage :  IEquatable<ImagePage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePage" /> class.
        /// </summary>
        /// <param name="page">Current page number..</param>
        /// <param name="totalPages">Total number of pages..</param>
        /// <param name="items">items.</param>
        public ImagePage(int page = default(int), int totalPages = default(int), List<Image> items = default(List<Image>))
        {
            this.Page = page;
            this.TotalPages = totalPages;
            this.Items = items;
        }

        /// <summary>
        /// Current page number.
        /// </summary>
        /// <value>Current page number.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int Page { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        /// <value>Total number of pages.</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Image> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImagePage {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ImagePage);
        }

        /// <summary>
        /// Returns true if ImagePage instances are equal
        /// </summary>
        /// <param name="input">Instance of ImagePage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImagePage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
