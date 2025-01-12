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
    /// Face detection scenario.
    /// </summary>
    /// <value>Face detection scenario.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FaceQualityScenarios
    {
        /// <summary>
        /// Enum OLD_MODE for value: OldMode
        /// </summary>
        [EnumMember(Value = "OldMode")]
        OLD_MODE = 1,

        /// <summary>
        /// Enum QUALITY_FULL for value: QualityFull
        /// </summary>
        [EnumMember(Value = "QualityFull")]
        QUALITY_FULL = 2,

        /// <summary>
        /// Enum QUALITY_ICAO for value: QualityICAO
        /// </summary>
        [EnumMember(Value = "QualityICAO")]
        QUALITY_ICAO = 3,

        /// <summary>
        /// Enum QUALITY_VISA_SCHENGEN for value: QualityVisaSchengen
        /// </summary>
        [EnumMember(Value = "QualityVisaSchengen")]
        QUALITY_VISA_SCHENGEN = 4,

        /// <summary>
        /// Enum QUALITY_VISA_USA for value: QualityVisaUSA
        /// </summary>
        [EnumMember(Value = "QualityVisaUSA")]
        QUALITY_VISA_USA = 5,

        /// <summary>
        /// Enum CROP_CENTRAL_FACE for value: CropCentralFace
        /// </summary>
        [EnumMember(Value = "CropCentralFace")]
        CROP_CENTRAL_FACE = 6,

        /// <summary>
        /// Enum CROP_ALL_FACES for value: CropAllFaces
        /// </summary>
        [EnumMember(Value = "CropAllFaces")]
        CROP_ALL_FACES = 7,

        /// <summary>
        /// Enum THUMBNAIL for value: Thumbnail
        /// </summary>
        [EnumMember(Value = "Thumbnail")]
        THUMBNAIL = 8

    }

}
