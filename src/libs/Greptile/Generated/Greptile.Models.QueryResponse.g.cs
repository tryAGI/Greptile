
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResponse
    {
        /// <summary>
        /// The AI-generated answer to the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The relevant source code locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Greptile.Source>? Sources { get; set; }

        /// <summary>
        /// The session identifier for conversation continuity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The AI-generated answer to the query
        /// </param>
        /// <param name="sources">
        /// The relevant source code locations
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for conversation continuity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryResponse(
            string? message,
            global::System.Collections.Generic.IList<global::Greptile.Source>? sources,
            string? sessionId)
        {
            this.Message = message;
            this.Sources = sources;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponse" /> class.
        /// </summary>
        public QueryResponse()
        {
        }
    }
}