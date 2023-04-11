/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.1.0
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
    /// TransactionInfo
    /// </summary>
    [DataContract]
    public partial class TransactionInfo :  IEquatable<TransactionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfo" /> class.
        /// </summary>
        /// <param name="code">The result code, one of the FaceSDKResultCode enum values. See the enum: https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/.</param>
        /// <param name="status">Whether the liveness detection is confirmed (0) or not (1)..</param>
        /// <param name="sessionId">Session ID, one session may include many transactions..</param>
        /// <param name="transactionId">Transaction ID, there can be several transactions within one session..</param>
        /// <param name="video">An S3 link to the session video..</param>
        /// <param name="portrait">An S3 link to the portrait..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        public TransactionInfo(int code = default(int), int status = default(int), int sessionId = default(int), string transactionId = default(string), string video = default(string), string portrait = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Code = code;
            this.Status = status;
            this.SessionId = sessionId;
            this.TransactionId = transactionId;
            this.Video = video;
            this.Portrait = portrait;
            this.Metadata = metadata;
        }

        /// <summary>
        /// The result code, one of the FaceSDKResultCode enum values. See the enum: https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/
        /// </summary>
        /// <value>The result code, one of the FaceSDKResultCode enum values. See the enum: https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int Code { get; set; }

        /// <summary>
        /// Whether the liveness detection is confirmed (0) or not (1).
        /// </summary>
        /// <value>Whether the liveness detection is confirmed (0) or not (1).</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// Session ID, one session may include many transactions.
        /// </summary>
        /// <value>Session ID, one session may include many transactions.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public int SessionId { get; set; }

        /// <summary>
        /// Transaction ID, there can be several transactions within one session.
        /// </summary>
        /// <value>Transaction ID, there can be several transactions within one session.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// An S3 link to the session video.
        /// </summary>
        /// <value>An S3 link to the session video.</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }

        /// <summary>
        /// An S3 link to the portrait.
        /// </summary>
        /// <value>An S3 link to the portrait.</value>
        [DataMember(Name="portrait", EmitDefaultValue=false)]
        public string Portrait { get; set; }

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
            sb.Append("class TransactionInfo {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Portrait: ").Append(Portrait).Append("\n");
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
            return this.Equals(input as TransactionInfo);
        }

        /// <summary>
        /// Returns true if TransactionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInfo input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Portrait == input.Portrait ||
                    (this.Portrait != null &&
                    this.Portrait.Equals(input.Portrait))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Portrait != null)
                    hashCode = hashCode * 59 + this.Portrait.GetHashCode();
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
