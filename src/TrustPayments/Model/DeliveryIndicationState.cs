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
using SwaggerDateConverter = TrustPayments.Client.SwaggerDateConverter;

namespace TrustPayments.Model
{
    /// <summary>
    /// Defines DeliveryIndicationState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DeliveryIndicationState
    {
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum NOT_SUITABLE for value: NOT_SUITABLE
        /// </summary>
        [EnumMember(Value = "NOT_SUITABLE")]
        NOT_SUITABLE,
        
        /// <summary>
        /// Enum MANUAL_CHECK_REQUIRED for value: MANUAL_CHECK_REQUIRED
        /// </summary>
        [EnumMember(Value = "MANUAL_CHECK_REQUIRED")]
        MANUAL_CHECK_REQUIRED,
        
        /// <summary>
        /// Enum SUITABLE for value: SUITABLE
        /// </summary>
        [EnumMember(Value = "SUITABLE")]
        SUITABLE
    }

}
