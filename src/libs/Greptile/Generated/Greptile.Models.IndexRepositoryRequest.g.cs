
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexRepositoryRequest
    {
        /// <summary>
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Greptile.JsonConverters.IndexRepositoryRequestRemoteJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Greptile.IndexRepositoryRequestRemote Remote { get; set; }

        /// <summary>
        /// The repository identifier in the format owner/repository<br/>
        /// Example: greptileai/examples
        /// </summary>
        /// <example>greptileai/examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        /// The branch to index<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// Whether to force re-indexing if the repository has already been indexed<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reload")]
        public bool? Reload { get; set; }

        /// <summary>
        /// Whether to receive an email notification upon completion<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notify")]
        public bool? Notify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexRepositoryRequest" /> class.
        /// </summary>
        /// <param name="remote">
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </param>
        /// <param name="repository">
        /// The repository identifier in the format owner/repository<br/>
        /// Example: greptileai/examples
        /// </param>
        /// <param name="branch">
        /// The branch to index<br/>
        /// Example: main
        /// </param>
        /// <param name="reload">
        /// Whether to force re-indexing if the repository has already been indexed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="notify">
        /// Whether to receive an email notification upon completion<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexRepositoryRequest(
            global::Greptile.IndexRepositoryRequestRemote remote,
            string repository,
            string branch,
            bool? reload,
            bool? notify)
        {
            this.Remote = remote;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.Reload = reload;
            this.Notify = notify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexRepositoryRequest" /> class.
        /// </summary>
        public IndexRepositoryRequest()
        {
        }
    }
}