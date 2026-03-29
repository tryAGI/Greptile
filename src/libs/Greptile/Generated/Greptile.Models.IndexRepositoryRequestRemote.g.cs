
#nullable enable

namespace Greptile
{
    /// <summary>
    /// The remote service hosting the repository<br/>
    /// Example: github
    /// </summary>
    public enum IndexRepositoryRequestRemote
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
    public static class IndexRepositoryRequestRemoteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexRepositoryRequestRemote value)
        {
            return value switch
            {
                IndexRepositoryRequestRemote.Github => "github",
                IndexRepositoryRequestRemote.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexRepositoryRequestRemote? ToEnum(string value)
        {
            return value switch
            {
                "github" => IndexRepositoryRequestRemote.Github,
                "gitlab" => IndexRepositoryRequestRemote.Gitlab,
                _ => null,
            };
        }
    }
}