
#nullable enable

namespace Greptile
{
    /// <summary>
    /// The remote service hosting the repository<br/>
    /// Example: github
    /// </summary>
    public enum RepositoryRefRemote
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRefRemoteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRefRemote value)
        {
            return value switch
            {
                RepositoryRefRemote.Github => "github",
                RepositoryRefRemote.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRefRemote? ToEnum(string value)
        {
            return value switch
            {
                "github" => RepositoryRefRemote.Github,
                "gitlab" => RepositoryRefRemote.Gitlab,
                _ => null,
            };
        }
    }
}