#nullable enable

namespace Greptile.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryInfoStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Greptile.RepositoryInfoStatus>
    {
        /// <inheritdoc />
        public override global::Greptile.RepositoryInfoStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Greptile.RepositoryInfoStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Greptile.RepositoryInfoStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Greptile.RepositoryInfoStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Greptile.RepositoryInfoStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Greptile.RepositoryInfoStatusExtensions.ToValueString(value));
        }
    }
}
