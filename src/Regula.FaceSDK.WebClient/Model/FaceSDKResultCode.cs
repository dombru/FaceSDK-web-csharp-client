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
    /// Result codes from core lib.
public class FaceSDKResultCode
{
    
        
        public const int FACER_OK = 0;
    
        
        public const int FACER_NO_LICENSE = 200;
    
        
        public const int FACER_IS_NOT_INITIALIZED = 201;
    
        
        public const int FACER_COMMAND_IS_NOT_SUPPORTED = 202;
    
        
        public const int FACER_COMMAND_PARAMS_READ_ERROR = 203;
    
        
        public const int FACER_SEARCHER_INDEX_FILE_NOT_EXIST = 204;
    
        
        public const int FACER_SEARCHER_INDEX_FILE_READ_ERROR = 205;
    
        
        public const int FACER_SEARCHER_INDEX_FILE_DECRYPTION_ERROR = 206;
    
        
        public const int FACER_SEARCHER_INDEX_LOAD_ERROR = 207;
    
        
        public const int FACER_SEARCHER_WRONG_DESCRIPTOR_VERSION = 208;
    
        
        public const int FACER_SEARCHER_INDEX_FILE_ENCRYPTION_ERROR = 209;
    
        
        public const int FACER_SEARCHER_INDEX_FILE_SAVE_ERROR = 210;
    
        
        public const int FACER_SEARCHER_IMAGE_DECODE_ERROR = 211;
    
        
        public const int FACER_SEARCHER_ID_EXISTS_IN_INDEX = 212;
    
        
        public const int FACER_SEARCHER_ID_NOT_IN_INDEX = 213;
    
        
        public const int FACER_SEARCHER_NO_FACES = 214;
    
        
        public const int FACER_SEARCHER_DESCRIPTOR_EXTRACTOR_ERROR = 215;
    
        
        public const int FACER_SEARCHER_METADATA_READ_ERROR = 216;
    
        
        public const int FACER_SEARCHER_NO_SEARCH_LICENSE = 217;
    
        
        public const int FACER_SEARCHER_DESCRIPTOR_DECODE_ERROR = 218;
    
        
        public const int FACER_SEARCHER_DESCRIPTOR_WRONG_SIZE = 219;
    
        
        public const int FACER_SEARCHER_ZIP_IMAGE_READ_ERROR = 220;
    
        
        public const int FACER_SEARCHER_ZIP_META_READ_ERROR = 221;
    
        
        public const int FACER_SEARCHER_SIMILAR_PHOTOS_EXIST = 222;
    
        
        public const int FACER_SEARCHER_PERSON_ZIP_READ_ERROR = 223;
    
        
        public const int FACER_LESS_THAN_TWO_IMAGES_IN_REQUEST = 224;
    
        
        public const int FACER_SEARCHER_WRONG_ID = 225;
    
        
        public const int FACER_SEARCHER_ID_EXISTS_IN_DELETED = 226;
    
        
        public const int FACER_VIDEO_DECODE_ERROR = 227;
    
        
        public const int FACER_NOT_ENOUGH_FRAMES = 228;
    
        
        public const int FACER_OUTPUT_IS_NOT_DEFINED = 229;
    
}
}
