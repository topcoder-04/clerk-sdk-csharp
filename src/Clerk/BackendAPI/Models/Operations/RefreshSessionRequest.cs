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
    using Clerk.BackendAPI.Models.Operations;
    using Clerk.BackendAPI.Utils;
    
    public class RefreshSessionRequest
    {

        /// <summary>
        /// The ID of the session
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=session_id")]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// Refresh session parameters
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public RefreshSessionRequestBody? RequestBody { get; set; }
    }
}