//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Operations
{
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    
    public class CreateSignInTokenRequestBody
    {

        /// <summary>
        /// The ID of the user that can use the newly created sign in token
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Optional parameter to specify the life duration of the sign in token in seconds.<br/>
        /// 
        /// <remarks>
        /// By default, the duration is 30 days.
        /// </remarks>
        /// </summary>
        [JsonProperty("expires_in_seconds")]
        public long? ExpiresInSeconds { get; set; } = 2592000;
    }
}