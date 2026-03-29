
#nullable enable

namespace Greptile
{
    /// <summary>
    /// The current indexing status
    /// </summary>
    public enum RepositoryInfoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cloning,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Indexed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryInfoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryInfoStatus value)
        {
            return value switch
            {
                RepositoryInfoStatus.Cloning => "cloning",
                RepositoryInfoStatus.Completed => "completed",
                RepositoryInfoStatus.Failed => "failed",
                RepositoryInfoStatus.Indexed => "indexed",
                RepositoryInfoStatus.Processing => "processing",
                RepositoryInfoStatus.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryInfoStatus? ToEnum(string value)
        {
            return value switch
            {
                "cloning" => RepositoryInfoStatus.Cloning,
                "completed" => RepositoryInfoStatus.Completed,
                "failed" => RepositoryInfoStatus.Failed,
                "indexed" => RepositoryInfoStatus.Indexed,
                "processing" => RepositoryInfoStatus.Processing,
                "submitted" => RepositoryInfoStatus.Submitted,
                _ => null,
            };
        }
    }
}