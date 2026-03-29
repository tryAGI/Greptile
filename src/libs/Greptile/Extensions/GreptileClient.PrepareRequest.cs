#nullable enable

namespace Greptile;

public partial class GreptileClient
{
    private string? _githubToken;

    /// <summary>
    /// Sets the GitHub/GitLab personal access token used to authenticate
    /// repository access. Required for accessing private repositories.
    /// </summary>
    /// <param name="githubToken">A GitHub or GitLab personal access token with repository read access.</param>
    /// <returns>The client instance for chaining.</returns>
    public GreptileClient WithGitHubToken(string githubToken)
    {
        _githubToken = githubToken;
        return this;
    }

    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (!string.IsNullOrEmpty(_githubToken))
        {
            request.Headers.TryAddWithoutValidation("X-GitHub-Token", _githubToken);
        }
    }
}
