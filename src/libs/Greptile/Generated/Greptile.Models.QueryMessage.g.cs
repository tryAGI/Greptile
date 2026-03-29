
#nullable enable

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryMessage
    {
        /// <summary>
        /// A unique identifier for the message<br/>
        /// Example: msg_1
        /// </summary>
        /// <example>msg_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The content of the message<br/>
        /// Example: What does this repository do?
        /// </summary>
        /// <example>What does this repository do?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The role of the message sender<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Greptile.JsonConverters.QueryMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Greptile.QueryMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message<br/>
        /// Example: What does this repository do?
        /// </param>
        /// <param name="role">
        /// The role of the message sender<br/>
        /// Example: user
        /// </param>
        /// <param name="id">
        /// A unique identifier for the message<br/>
        /// Example: msg_1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryMessage(
            string content,
            global::Greptile.QueryMessageRole role,
            string? id)
        {
            this.Id = id;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryMessage" /> class.
        /// </summary>
        public QueryMessage()
        {
        }
    }
}