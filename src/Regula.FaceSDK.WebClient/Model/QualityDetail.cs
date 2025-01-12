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
    /// QualityDetail
    /// </summary>
    [DataContract]
    public partial class QualityDetail :  IEquatable<QualityDetail>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public FaceImageQualityGroups? GroupId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public FaceQualityConfigName? Name { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public FaceImageQualityStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityDetail" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="name">name.</param>
        /// <param name="range">The range of set values for this characteristic..</param>
        /// <param name="status">status.</param>
        /// <param name="value">The assessed value for the characteristic, returned in the set units..</param>
        public QualityDetail(FaceImageQualityGroups? groupId = default(FaceImageQualityGroups?), FaceQualityConfigName? name = default(FaceQualityConfigName?), List<float> range = default(List<float>), FaceImageQualityStatus? status = default(FaceImageQualityStatus?), float value = default(float))
        {
            this.GroupId = groupId;
            this.Name = name;
            this.Range = range;
            this.Status = status;
            this.Value = value;
        }



        /// <summary>
        /// The range of set values for this characteristic.
        /// </summary>
        /// <value>The range of set values for this characteristic.</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public List<float> Range { get; set; }


        /// <summary>
        /// The assessed value for the characteristic, returned in the set units.
        /// </summary>
        /// <value>The assessed value for the characteristic, returned in the set units.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityDetail {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as QualityDetail);
        }

        /// <summary>
        /// Returns true if QualityDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Range == input.Range ||
                    this.Range != null &&
                    input.Range != null &&
                    this.Range.SequenceEqual(input.Range)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
