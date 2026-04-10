#nullable enable

namespace Greptile
{
    public partial interface IGreptileClient
    {
        /// <summary>
        /// Search a codebase<br/>
        /// Search repositories in natural language and get back a list of relevant code files, functions, and snippets. Similar to the query endpoint but without the AI-generated answer. Use this endpoint when you only need the source references.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Greptile.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.SearchResponse> SearchCodebaseAsync(

            global::Greptile.SearchRequest request,
            global::Greptile.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a codebase<br/>
        /// Search repositories in natural language and get back a list of relevant code files, functions, and snippets. Similar to the query endpoint but without the AI-generated answer. Use this endpoint when you only need the source references.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.SearchResponse> SearchCodebaseAsync(
            global::System.Collections.Generic.IList<global::Greptile.QueryMessage> messages,
            global::System.Collections.Generic.IList<global::Greptile.RepositoryRef> repositories,
            string? sessionId = default,
            bool? genius = default,
            global::Greptile.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}