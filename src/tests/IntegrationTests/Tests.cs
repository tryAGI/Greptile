namespace Greptile.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GreptileClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GREPTILE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GREPTILE_API_KEY environment variable is not found.");

        var githubToken =
            Environment.GetEnvironmentVariable("GITHUB_TOKEN") is { Length: > 0 } githubTokenValue
                ? githubTokenValue
                : null;

        var client = new GreptileClient(apiKey);

        if (githubToken != null)
        {
            client.WithGitHubToken(githubToken);
        }

        return client;
    }
}
