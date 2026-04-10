#nullable enable

namespace Greptile
{
    public partial interface IGreptileClient
    {
        /// <summary>
        /// Index a repository<br/>
        /// Initiates processing or reprocessing of a specified repository. The repository must be indexed before it can be queried or searched. Indexing may take some time for large repositories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Greptile.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.IndexRepositoryResponse> IndexRepositoryAsync(

            global::Greptile.IndexRepositoryRequest request,
            global::Greptile.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index a repository<br/>
        /// Initiates processing or reprocessing of a specified repository. The repository must be indexed before it can be queried or searched. Indexing may take some time for large repositories.
        /// </summary>
        /// <param name="remote">
        /// The remote service hosting the repository<br/>
        /// Example: github
        /// </param>
        /// <param name="repository">
        /// The repository identifier in the format owner/repository<br/>
        /// Example: greptileai/examples
        /// </param>
        /// <param name="branch">
        /// The branch to index<br/>
        /// Example: main
        /// </param>
        /// <param name="reload">
        /// Whether to force re-indexing if the repository has already been indexed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="notify">
        /// Whether to receive an email notification upon completion<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Greptile.IndexRepositoryResponse> IndexRepositoryAsync(
            global::Greptile.IndexRepositoryRequestRemote remote,
            string repository,
            string branch,
            bool? reload = default,
            bool? notify = default,
            global::Greptile.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}