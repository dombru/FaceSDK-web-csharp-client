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
    /// MatchAndSearchResponse
    /// </summary>
    [DataContract]
    public partial class MatchAndSearchResponse :  IEquatable<MatchAndSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public FaceSDKResultCode Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAndSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchAndSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAndSearchResponse" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="results">results.</param>
        /// <param name="elapsedTime">elapsedTime.</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        /// <param name="detections">detections.</param>
        public MatchAndSearchResponse(FaceSDKResultCode code = default(FaceSDKResultCode), List<MatchImageResult> results = default(List<MatchImageResult>), float elapsedTime = default(float), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<MatchAndSearchResponseAllOfDetections> detections = default(List<MatchAndSearchResponseAllOfDetections>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for MatchAndSearchResponse and cannot be null");
            }
            else
            {
                this.Code = code;
            }

            this.Results = results;
            this.ElapsedTime = elapsedTime;
            this.Metadata = metadata;
            this.Detections = detections;
        }


        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<MatchImageResult> Results { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedTime
        /// </summary>
        [DataMember(Name="elapsedTime", EmitDefaultValue=false)]
        public float ElapsedTime { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Detections
        /// </summary>
        [DataMember(Name="detections", EmitDefaultValue=false)]
        public List<MatchAndSearchResponseAllOfDetections> Detections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchAndSearchResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Detections: ").Append(Detections).Append("\n");
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
            return this.Equals(input as MatchAndSearchResponse);
        }

        /// <summary>
        /// Returns true if MatchAndSearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchAndSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchAndSearchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.ElapsedTime == input.ElapsedTime ||
                    (this.ElapsedTime != null &&
                    this.ElapsedTime.Equals(input.ElapsedTime))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Detections == input.Detections ||
                    this.Detections != null &&
                    input.Detections != null &&
                    this.Detections.SequenceEqual(input.Detections)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.ElapsedTime != null)
                    hashCode = hashCode * 59 + this.ElapsedTime.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Detections != null)
                    hashCode = hashCode * 59 + this.Detections.GetHashCode();
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
