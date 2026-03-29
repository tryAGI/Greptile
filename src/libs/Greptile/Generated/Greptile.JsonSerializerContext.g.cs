
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Greptile
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Greptile.JsonConverters.IndexRepositoryRequestRemoteJsonConverter),

            typeof(global::Greptile.JsonConverters.IndexRepositoryRequestRemoteNullableJsonConverter),

            typeof(global::Greptile.JsonConverters.RepositoryInfoStatusJsonConverter),

            typeof(global::Greptile.JsonConverters.RepositoryInfoStatusNullableJsonConverter),

            typeof(global::Greptile.JsonConverters.QueryMessageRoleJsonConverter),

            typeof(global::Greptile.JsonConverters.QueryMessageRoleNullableJsonConverter),

            typeof(global::Greptile.JsonConverters.RepositoryRefRemoteJsonConverter),

            typeof(global::Greptile.JsonConverters.RepositoryRefRemoteNullableJsonConverter),

            typeof(global::Greptile.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.IndexRepositoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.IndexRepositoryRequestRemote), TypeInfoPropertyName = "IndexRepositoryRequestRemote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.IndexRepositoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.RepositoryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.RepositoryInfoStatus), TypeInfoPropertyName = "RepositoryInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.QueryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.QueryMessageRole), TypeInfoPropertyName = "QueryMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.RepositoryRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.RepositoryRefRemote), TypeInfoPropertyName = "RepositoryRefRemote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.QueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Greptile.QueryMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Greptile.RepositoryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.QueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Greptile.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Greptile.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Greptile.QueryMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Greptile.RepositoryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Greptile.Source>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}