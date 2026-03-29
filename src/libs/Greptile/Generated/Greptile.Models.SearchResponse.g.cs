
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// The relevant source code locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Greptile.Source>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="sources">
        /// The relevant source code locations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            global::System.Collections.Generic.IList<global::Greptile.Source>? sources)
        {
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}