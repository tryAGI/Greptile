
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// The repository name in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </summary>
        /// <example>greptileai/examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// The remote service<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote")]
        public string? Remote { get; set; }

        /// <summary>
        /// The branch<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The file path within the repository<br/>
        /// Example: src/core/main.js
        /// </summary>
        /// <example>src/core/main.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filepath")]
        public string? Filepath { get; set; }

        /// <summary>
        /// The starting line number of the relevant code<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linestart")]
        public int? Linestart { get; set; }

        /// <summary>
        /// The ending line number of the relevant code<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineend")]
        public int? Lineend { get; set; }

        /// <summary>
        /// A brief summary of the relevant code section<br/>
        /// Example: Core functionality implementation
        /// </summary>
        /// <example>Core functionality implementation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The relevance distance score. Lower values indicate higher relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="repository">
        /// The repository name in owner/repository format<br/>
        /// Example: greptileai/examples
        /// </param>
        /// <param name="remote">
        /// The remote service<br/>
        /// Example: github
        /// </param>
        /// <param name="branch">
        /// The branch<br/>
        /// Example: main
        /// </param>
        /// <param name="filepath">
        /// The file path within the repository<br/>
        /// Example: src/core/main.js
        /// </param>
        /// <param name="linestart">
        /// The starting line number of the relevant code<br/>
        /// Example: 10
        /// </param>
        /// <param name="lineend">
        /// The ending line number of the relevant code<br/>
        /// Example: 45
        /// </param>
        /// <param name="summary">
        /// A brief summary of the relevant code section<br/>
        /// Example: Core functionality implementation
        /// </param>
        /// <param name="distance">
        /// The relevance distance score. Lower values indicate higher relevance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Source(
            string? repository,
            string? remote,
            string? branch,
            string? filepath,
            int? linestart,
            int? lineend,
            string? summary,
            double? distance)
        {
            this.Repository = repository;
            this.Remote = remote;
            this.Branch = branch;
            this.Filepath = filepath;
            this.Linestart = linestart;
            this.Lineend = lineend;
            this.Summary = summary;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }
    }
}