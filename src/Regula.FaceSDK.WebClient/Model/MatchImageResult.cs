/* 
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API
 *
 * The version of the OpenAPI document: 3.2.0
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
    /// MatchImageResult
    /// </summary>
    [DataContract]
    public partial class MatchImageResult :  IEquatable<MatchImageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchImageResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchImageResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchImageResult" /> class.
        /// </summary>
        /// <param name="firstIndex">Image index used to identify input photos between themselves. If not specified, than input list index is used (required).</param>
        /// <param name="firstFaceIndex">Faces index used to identify faces in scope of one photo..</param>
        /// <param name="secondIndex">Image index used to identify input photos between themselves. If not specified, than input list index is used (required).</param>
        /// <param name="secondFaceIndex">Faces index used to identify faces in scope of one photo..</param>
        /// <param name="score">score.</param>
        /// <param name="similarity">similarity.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMsg">errorMsg.</param>
        public MatchImageResult(int firstIndex = default(int), int firstFaceIndex = default(int), int secondIndex = default(int), int secondFaceIndex = default(int), decimal score = default(decimal), decimal similarity = default(decimal), int errorCode = default(int), string errorMsg = default(string))
        {
            // to ensure "firstIndex" is required (not null)
            if (firstIndex == null)
            {
                throw new InvalidDataException("firstIndex is a required property for MatchImageResult and cannot be null");
            }
            else
            {
                this.FirstIndex = firstIndex;
            }
            
            // to ensure "secondIndex" is required (not null)
            if (secondIndex == null)
            {
                throw new InvalidDataException("secondIndex is a required property for MatchImageResult and cannot be null");
            }
            else
            {
                this.SecondIndex = secondIndex;
            }
            
            this.FirstFaceIndex = firstFaceIndex;
            this.SecondFaceIndex = secondFaceIndex;
            this.Score = score;
            this.Similarity = similarity;
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
        }
        
        /// <summary>
        /// Image index used to identify input photos between themselves. If not specified, than input list index is used
        /// </summary>
        /// <value>Image index used to identify input photos between themselves. If not specified, than input list index is used</value>
        [DataMember(Name="firstIndex", EmitDefaultValue=true)]
        public int FirstIndex { get; set; }

        /// <summary>
        /// Faces index used to identify faces in scope of one photo.
        /// </summary>
        /// <value>Faces index used to identify faces in scope of one photo.</value>
        [DataMember(Name="firstFaceIndex", EmitDefaultValue=false)]
        public int FirstFaceIndex { get; set; }

        /// <summary>
        /// Image index used to identify input photos between themselves. If not specified, than input list index is used
        /// </summary>
        /// <value>Image index used to identify input photos between themselves. If not specified, than input list index is used</value>
        [DataMember(Name="secondIndex", EmitDefaultValue=true)]
        public int SecondIndex { get; set; }

        /// <summary>
        /// Faces index used to identify faces in scope of one photo.
        /// </summary>
        /// <value>Faces index used to identify faces in scope of one photo.</value>
        [DataMember(Name="secondFaceIndex", EmitDefaultValue=false)]
        public int SecondFaceIndex { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public decimal Score { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name="similarity", EmitDefaultValue=false)]
        public decimal Similarity { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name="errorMsg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchImageResult {\n");
            sb.Append("  FirstIndex: ").Append(FirstIndex).Append("\n");
            sb.Append("  FirstFaceIndex: ").Append(FirstFaceIndex).Append("\n");
            sb.Append("  SecondIndex: ").Append(SecondIndex).Append("\n");
            sb.Append("  SecondFaceIndex: ").Append(SecondFaceIndex).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
            return this.Equals(input as MatchImageResult);
        }

        /// <summary>
        /// Returns true if MatchImageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchImageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchImageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstIndex == input.FirstIndex ||
                    (this.FirstIndex != null &&
                    this.FirstIndex.Equals(input.FirstIndex))
                ) && 
                (
                    this.FirstFaceIndex == input.FirstFaceIndex ||
                    (this.FirstFaceIndex != null &&
                    this.FirstFaceIndex.Equals(input.FirstFaceIndex))
                ) && 
                (
                    this.SecondIndex == input.SecondIndex ||
                    (this.SecondIndex != null &&
                    this.SecondIndex.Equals(input.SecondIndex))
                ) && 
                (
                    this.SecondFaceIndex == input.SecondFaceIndex ||
                    (this.SecondFaceIndex != null &&
                    this.SecondFaceIndex.Equals(input.SecondFaceIndex))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Similarity == input.Similarity ||
                    (this.Similarity != null &&
                    this.Similarity.Equals(input.Similarity))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.FirstIndex != null)
                    hashCode = hashCode * 59 + this.FirstIndex.GetHashCode();
                if (this.FirstFaceIndex != null)
                    hashCode = hashCode * 59 + this.FirstFaceIndex.GetHashCode();
                if (this.SecondIndex != null)
                    hashCode = hashCode * 59 + this.SecondIndex.GetHashCode();
                if (this.SecondFaceIndex != null)
                    hashCode = hashCode * 59 + this.SecondFaceIndex.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Similarity != null)
                    hashCode = hashCode * 59 + this.Similarity.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
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
