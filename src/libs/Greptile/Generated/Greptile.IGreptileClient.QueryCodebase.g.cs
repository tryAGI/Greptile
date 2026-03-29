#nullable enable

namespace Greptile
{
    public partial interface IGreptileClient
    {
        /// <summary>
        /// Query a codebase<br/>
        /// Query repositories in natural language and get back an AI-generated answer along with a list of relevant source files, functions, and classes. The query must be formatted as a messages array following the OpenAI Chat format.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Greptile.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.QueryResponse> QueryCodebaseAsync(

            global::Greptile.QueryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query a codebase<br/>
        /// Query repositories in natural language and get back an AI-generated answer along with a list of relevant source files, functions, and classes. The query must be formatted as a messages array following the OpenAI Chat format.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.QueryResponse> QueryCodebaseAsync(
            global::System.Collections.Generic.IList<global::Greptile.QueryMessage> messages,
            global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> repositories,
            string? sessionId = default,
            bool? stream = default,
            bool? genius = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}