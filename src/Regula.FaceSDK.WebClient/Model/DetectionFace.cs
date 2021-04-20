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
    /// DetectionFace
    /// </summary>
    [DataContract]
    public partial class DetectionFace :  IEquatable<DetectionFace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionFace" /> class.
        /// </summary>
        /// <param name="faceIndex">Faces index used to identify faces in scope of one photo..</param>
        /// <param name="landmarks">Main coordinates of the detected face (eyes, nose, lips, ears and etc.)..</param>
        /// <param name="roi">Rectangular area of the detected face. First element - X-axis coordinate. Second element - Y-axis coordinate. (X, Y) - left top point. Third element - rectangular width. Fourth element - rectangular height..</param>
        /// <param name="thumbnail">Formatted base64 face detection image..</param>
        public DetectionFace(int faceIndex = default(int), List<List<decimal>> landmarks = default(List<List<decimal>>), List<decimal> roi = default(List<decimal>), byte[] thumbnail = default(byte[]))
        {
            this.FaceIndex = faceIndex;
            this.Landmarks = landmarks;
            this.Roi = roi;
            this.Thumbnail = thumbnail;
        }
        
        /// <summary>
        /// Faces index used to identify faces in scope of one photo.
        /// </summary>
        /// <value>Faces index used to identify faces in scope of one photo.</value>
        [DataMember(Name="faceIndex", EmitDefaultValue=false)]
        public int FaceIndex { get; set; }

        /// <summary>
        /// Main coordinates of the detected face (eyes, nose, lips, ears and etc.).
        /// </summary>
        /// <value>Main coordinates of the detected face (eyes, nose, lips, ears and etc.).</value>
        [DataMember(Name="landmarks", EmitDefaultValue=false)]
        public List<List<decimal>> Landmarks { get; set; }

        /// <summary>
        /// Rectangular area of the detected face. First element - X-axis coordinate. Second element - Y-axis coordinate. (X, Y) - left top point. Third element - rectangular width. Fourth element - rectangular height.
        /// </summary>
        /// <value>Rectangular area of the detected face. First element - X-axis coordinate. Second element - Y-axis coordinate. (X, Y) - left top point. Third element - rectangular width. Fourth element - rectangular height.</value>
        [DataMember(Name="roi", EmitDefaultValue=false)]
        public List<decimal> Roi { get; set; }

        /// <summary>
        /// Formatted base64 face detection image.
        /// </summary>
        /// <value>Formatted base64 face detection image.</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public byte[] Thumbnail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectionFace {\n");
            sb.Append("  FaceIndex: ").Append(FaceIndex).Append("\n");
            sb.Append("  Landmarks: ").Append(Landmarks).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
            return this.Equals(input as DetectionFace);
        }

        /// <summary>
        /// Returns true if DetectionFace instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectionFace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectionFace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceIndex == input.FaceIndex ||
                    (this.FaceIndex != null &&
                    this.FaceIndex.Equals(input.FaceIndex))
                ) && 
                (
                    this.Landmarks == input.Landmarks ||
                    this.Landmarks != null &&
                    input.Landmarks != null &&
                    this.Landmarks.SequenceEqual(input.Landmarks)
                ) && 
                (
                    this.Roi == input.Roi ||
                    this.Roi != null &&
                    input.Roi != null &&
                    this.Roi.SequenceEqual(input.Roi)
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
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
                if (this.FaceIndex != null)
                    hashCode = hashCode * 59 + this.FaceIndex.GetHashCode();
                if (this.Landmarks != null)
                    hashCode = hashCode * 59 + this.Landmarks.GetHashCode();
                if (this.Roi != null)
                    hashCode = hashCode * 59 + this.Roi.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
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
