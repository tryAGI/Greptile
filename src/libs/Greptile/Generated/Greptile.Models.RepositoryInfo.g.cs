
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryInfo
    {
        /// <summary>
        /// The repository name in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </summary>
        /// <example>greptileai/examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote")]
        public string? Remote { get; set; }

        /// <summary>
        /// The branch that was indexed<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Whether the repository is private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// The current indexing status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Greptile.JsonConverters.RepositoryInfoStatusJsonConverter))]
        public global::Greptile.RepositoryInfoStatus? Status { get; set; }

        /// <summary>
        /// The number of files that have been processed<br/>
        /// Example: 256
        /// </summary>
        /// <example>256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesProcessed")]
        public int? FilesProcessed { get; set; }

        /// <summary>
        /// The total number of files in the repository<br/>
        /// Example: 256
        /// </summary>
        /// <example>256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numFiles")]
        public int? NumFiles { get; set; }

        /// <summary>
        /// The Git commit SHA of the indexed version<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Sample questions that can be asked about the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleQuestions")]
        public global::System.Collections.Generic.IList<string>? SampleQuestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInfo" /> class.
        /// </summary>
        /// <param name="repository">
        /// The repository name in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </param>
        /// <param name="remote">
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </param>
        /// <param name="branch">
        /// The branch that was indexed<br/>
        /// Example: main
        /// </param>
        /// <param name="private">
        /// Whether the repository is private
        /// </param>
        /// <param name="status">
        /// The current indexing status
        /// </param>
        /// <param name="filesProcessed">
        /// The number of files that have been processed<br/>
        /// Example: 256
        /// </param>
        /// <param name="numFiles">
        /// The total number of files in the repository<br/>
        /// Example: 256
        /// </param>
        /// <param name="sha">
        /// The Git commit SHA of the indexed version<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="sampleQuestions">
        /// Sample questions that can be asked about the repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryInfo(
            string? repository,
            string? remote,
            string? branch,
            bool? @private,
            global::Greptile.RepositoryInfoStatus? status,
            int? filesProcessed,
            int? numFiles,
            string? sha,
            global::System.Collections.Generic.IList<string>? sampleQuestions)
        {
            this.Repository = repository;
            this.Remote = remote;
            this.Branch = branch;
            this.Private = @private;
            this.Status = status;
            this.FilesProcessed = filesProcessed;
            this.NumFiles = numFiles;
            this.Sha = sha;
            this.SampleQuestions = sampleQuestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInfo" /> class.
        /// </summary>
        public RepositoryInfo()
        {
        }
    }
}