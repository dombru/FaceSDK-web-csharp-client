/* 
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API
 *
 * The version of the OpenAPI document: 0.1.0
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
    /// DetectResult
    /// </summary>
    [DataContract]
    public partial class DetectResult :  IEquatable<DetectResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DetectResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectResult" /> class.
        /// </summary>
        /// <param name="detections">detections (required).</param>
        /// <param name="detectorType">Internal..</param>
        /// <param name="landmarksType">Internal..</param>
        public DetectResult(List<Detection> detections = default(List<Detection>), int detectorType = default(int), int landmarksType = default(int))
        {
            // to ensure "detections" is required (not null)
            if (detections == null)
            {
                throw new InvalidDataException("detections is a required property for DetectResult and cannot be null");
            }
            else
            {
                this.Detections = detections;
            }
            
            this.DetectorType = detectorType;
            this.LandmarksType = landmarksType;
        }
        
        /// <summary>
        /// Gets or Sets Detections
        /// </summary>
        [DataMember(Name="detections", EmitDefaultValue=true)]
        public List<Detection> Detections { get; set; }

        /// <summary>
        /// Internal.
        /// </summary>
        /// <value>Internal.</value>
        [DataMember(Name="detectorType", EmitDefaultValue=false)]
        public int DetectorType { get; set; }

        /// <summary>
        /// Internal.
        /// </summary>
        /// <value>Internal.</value>
        [DataMember(Name="landmarksType", EmitDefaultValue=false)]
        public int LandmarksType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectResult {\n");
            sb.Append("  Detections: ").Append(Detections).Append("\n");
            sb.Append("  DetectorType: ").Append(DetectorType).Append("\n");
            sb.Append("  LandmarksType: ").Append(LandmarksType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as DetectResult);
        }

        /// <summary>
        /// Returns true if DetectResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detections == input.Detections ||
                    this.Detections != null &&
                    input.Detections != null &&
                    this.Detections.SequenceEqual(input.Detections)
                ) && 
                (
                    this.DetectorType == input.DetectorType ||
                    (this.DetectorType != null &&
                    this.DetectorType.Equals(input.DetectorType))
                ) && 
                (
                    this.LandmarksType == input.LandmarksType ||
                    (this.LandmarksType != null &&
                    this.LandmarksType.Equals(input.LandmarksType))
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
                if (this.Detections != null)
                    hashCode = hashCode * 59 + this.Detections.GetHashCode();
                if (this.DetectorType != null)
                    hashCode = hashCode * 59 + this.DetectorType.GetHashCode();
                if (this.LandmarksType != null)
                    hashCode = hashCode * 59 + this.LandmarksType.GetHashCode();
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
