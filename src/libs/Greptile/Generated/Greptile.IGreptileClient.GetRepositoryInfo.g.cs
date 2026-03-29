#nullable enable

namespace Greptile
{
    public partial interface IGreptileClient
    {
        /// <summary>
        /// Get repository information<br/>
        /// Retrieves the current status and information about a repository's index. The repositoryId should be URL-encoded in the format remote:branch:owner/repository.
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Greptile.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.RepositoryInfo> GetRepositoryInfoAsync(
            string repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}