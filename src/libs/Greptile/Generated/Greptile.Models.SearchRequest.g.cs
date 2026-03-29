
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// The search query formatted as a messages array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Greptile.QueryMessage> Messages { get; set; }

        /// <summary>
        /// The repositories to search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> Repositories { get; set; }

        /// <summary>
        /// An optional session identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Enable genius mode for more thorough search<br/>
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
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// The search query formatted as a messages array
        /// </param>
        /// <param name="repositories">
        /// The repositories to search
        /// </param>
        /// <param name="sessionId">
        /// An optional session identifier
        /// </param>
        /// <param name="genius">
        /// Enable genius mode for more thorough search<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest(
            global::System.Collections.Generic.IList<global::Greptile.QueryMessage> messages,
            global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> repositories,
            string? sessionId,
            bool? genius)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.SessionId = sessionId;
            this.Genius = genius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}