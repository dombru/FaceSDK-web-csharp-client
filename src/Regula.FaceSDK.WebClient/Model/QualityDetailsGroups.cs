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
    /// QualityDetailsGroups
    /// </summary>
    [DataContract]
    public partial class QualityDetailsGroups :  IEquatable<QualityDetailsGroups>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="QualityDetailsGroups" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="name">name.</param>
        /// <param name="totalCount">The total number of characteristics in the group..</param>
        /// <param name="compliantCount">The number of compliant characteristics in the group..</param>
        public QualityDetailsGroups(FaceImageQualityGroups? groupId = default(FaceImageQualityGroups?), FaceQualityConfigName? name = default(FaceQualityConfigName?), int totalCount = default(int), int compliantCount = default(int))
        {
            this.GroupId = groupId;
            this.Name = name;
            this.TotalCount = totalCount;
            this.CompliantCount = compliantCount;
        }



        /// <summary>
        /// The total number of characteristics in the group.
        /// </summary>
        /// <value>The total number of characteristics in the group.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// The number of compliant characteristics in the group.
        /// </summary>
        /// <value>The number of compliant characteristics in the group.</value>
        [DataMember(Name="compliantCount", EmitDefaultValue=false)]
        public int CompliantCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityDetailsGroups {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  CompliantCount: ").Append(CompliantCount).Append("\n");
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
            return this.Equals(input as QualityDetailsGroups);
        }

        /// <summary>
        /// Returns true if QualityDetailsGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityDetailsGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityDetailsGroups input)
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
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.CompliantCount == input.CompliantCount ||
                    (this.CompliantCount != null &&
                    this.CompliantCount.Equals(input.CompliantCount))
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.CompliantCount != null)
                    hashCode = hashCode * 59 + this.CompliantCount.GetHashCode();
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
