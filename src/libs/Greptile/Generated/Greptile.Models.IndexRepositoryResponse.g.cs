
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexRepositoryResponse
    {
        /// <summary>
        /// A message indicating the status of the indexing request<br/>
        /// Example: Repository indexing initiated
        /// </summary>
        /// <example>Repository indexing initiated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// URL to check the status of the indexing operation<br/>
        /// Example: https://api.greptile.com/v2/repositories/github%3Amain%3Agreptileai%2Fexamples
        /// </summary>
        /// <example>https://api.greptile.com/v2/repositories/github%3Amain%3Agreptileai%2Fexamples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusEndpoint")]
        public string? StatusEndpoint { get; set; }

        /// <summary>
        /// The unique identifier for the repository<br/>
        /// Example: github:main:greptileai/examples
        /// </summary>
        /// <example>github:main:greptileai/examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryId")]
        public string? RepositoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexRepositoryResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A message indicating the status of the indexing request<br/>
        /// Example: Repository indexing initiated
        /// </param>
        /// <param name="statusEndpoint">
        /// URL to check the status of the indexing operation<br/>
        /// Example: https://api.greptile.com/v2/repositories/github%3Amain%3Agreptileai%2Fexamples
        /// </param>
        /// <param name="repositoryId">
        /// The unique identifier for the repository<br/>
        /// Example: github:main:greptileai/examples
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexRepositoryResponse(
            string? message,
            string? statusEndpoint,
            string? repositoryId)
        {
            this.Message = message;
            this.StatusEndpoint = statusEndpoint;
            this.RepositoryId = repositoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexRepositoryResponse" /> class.
        /// </summary>
        public IndexRepositoryResponse()
        {
        }
    }
}