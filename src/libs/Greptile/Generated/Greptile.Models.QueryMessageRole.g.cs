
#nullable enable

namespace Greptile
{
    /// <summary>
    /// The role of the message sender<br/>
    /// Example: user
    /// </summary>
    public enum QueryMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryMessageRole value)
        {
            return value switch
            {
                QueryMessageRole.Assistant => "assistant",
                QueryMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => QueryMessageRole.Assistant,
                "user" => QueryMessageRole.User,
                _ => null,
            };
        }
    }
}