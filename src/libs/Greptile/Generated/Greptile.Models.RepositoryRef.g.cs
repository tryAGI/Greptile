
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRef
    {
        /// <summary>
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Greptile.JsonConverters.RepositoryRefRemoteJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Greptile.RepositoryRefRemote Remote { get; set; }

        /// <summary>
        /// The repository identifier in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </summary>
        /// <example>greptileai/examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        /// The branch to query<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRef" /> class.
        /// </summary>
        /// <param name="remote">
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </param>
        /// <param name="repository">
        /// The repository identifier in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </param>
        /// <param name="branch">
        /// The branch to query<br/>
        /// Example: main
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRef(
            global::Greptile.RepositoryRefRemote remote,
            string repository,
            string branch)
        {
            this.Remote = remote;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRef" /> class.
        /// </summary>
        public RepositoryRef()
        {
        }
    }
}