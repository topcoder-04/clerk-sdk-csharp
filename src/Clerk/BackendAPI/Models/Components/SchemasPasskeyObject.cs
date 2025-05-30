//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Components
{
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// String representing the object&apos;s type. Objects of the same type share the same value.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasPasskeyObject
    {
        [JsonProperty("passkey")]
        Passkey,
    }

    public static class SchemasPasskeyObjectExtension
    {
        public static string Value(this SchemasPasskeyObject value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasPasskeyObject ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasPasskeyObject).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is SchemasPasskeyObject)
                    {
                        return (SchemasPasskeyObject)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasPasskeyObject");
        }
    }

}