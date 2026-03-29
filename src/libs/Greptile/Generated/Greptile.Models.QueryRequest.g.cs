
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRequest
    {
        /// <summary>
        /// The query messages in OpenAI Chat format. Can be a single message or a conversation history for multi-turn queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Greptile.QueryMessage> Messages { get; set; }

        /// <summary>
        /// The repositories to query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> Repositories { get; set; }

        /// <summary>
        /// An optional session identifier for conversation continuity. Use the same sessionId across queries to maintain context.<br/>
        /// Example: test-session-id
        /// </summary>
        /// <example>test-session-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Whether to stream the response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Enable genius mode for more thorough analysis. Results are smarter but may take longer to generate.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genius")]
        public bool? Genius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// The query messages in OpenAI Chat format. Can be a single message or a conversation history for multi-turn queries.
        /// </param>
        /// <param name="repositories">
        /// The repositories to query
        /// </param>
        /// <param name="sessionId">
        /// An optional session identifier for conversation continuity. Use the same sessionId across queries to maintain context.<br/>
        /// Example: test-session-id
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="genius">
        /// Enable genius mode for more thorough analysis. Results are smarter but may take longer to generate.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRequest(
            global::System.Collections.Generic.IList<global::Greptile.QueryMessage> messages,
            global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> repositories,
            string? sessionId,
            bool? stream,
            bool? genius)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.SessionId = sessionId;
            this.Stream = stream;
            this.Genius = genius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        public QueryRequest()
        {
        }
    }
}