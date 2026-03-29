#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Greptile;

public static class GreptileClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that queries a codebase using natural language
    /// and returns an AI-generated answer with relevant source references.
    /// </summary>
    public static AIFunction AsQueryCodebaseTool(this GreptileClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The natural language question to ask about the codebase")] string query,
                   [Description("Comma-separated list of repositories in the format remote:branch:owner/repo (e.g., github:main:owner/repo)")] string repositories,
                   [Description("Optional session ID for conversation continuity")] string? sessionId,
                   [Description("Enable genius mode for more thorough analysis (slower but smarter)")] bool? genius,
                   CancellationToken cancellationToken) =>
            {
                var repoRefs = ParseRepositories(repositories);

                var response = await client.QueryCodebaseAsync(
                    messages: [new QueryMessage
                    {
                        Content = query,
                        Role = QueryMessageRole.User,
                    }],
                    repositories: repoRefs,
                    sessionId: sessionId,
                    genius: genius,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Message,
                    Sources = response.Sources?.Select(s => new
                    {
                        s.Repository,
                        s.Remote,
                        s.Branch,
                        s.Filepath,
                        s.Linestart,
                        s.Lineend,
                        s.Summary,
                    }),
                };
            },
            name: "Greptile_QueryCodebase",
            description: "Ask a natural language question about a codebase and get an AI-powered answer with relevant source code references.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches a codebase using natural language
    /// and returns relevant code locations without an AI-generated answer.
    /// </summary>
    public static AIFunction AsSearchCodebaseTool(this GreptileClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The natural language search query")] string query,
                   [Description("Comma-separated list of repositories in the format remote:branch:owner/repo (e.g., github:main:owner/repo)")] string repositories,
                   [Description("Enable genius mode for more thorough search")] bool? genius,
                   CancellationToken cancellationToken) =>
            {
                var repoRefs = ParseRepositories(repositories);

                var response = await client.SearchCodebaseAsync(
                    messages: [new QueryMessage
                    {
                        Content = query,
                        Role = QueryMessageRole.User,
                    }],
                    repositories: repoRefs,
                    genius: genius,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Sources = response.Sources?.Select(s => new
                    {
                        s.Repository,
                        s.Remote,
                        s.Branch,
                        s.Filepath,
                        s.Linestart,
                        s.Lineend,
                        s.Summary,
                    }),
                };
            },
            name: "Greptile_SearchCodebase",
            description: "Search a codebase using natural language and get relevant code file locations, functions, and snippets without an AI explanation.");
    }

    /// <summary>
    /// Creates an AIFunction tool that submits a repository for indexing.
    /// The repository must be indexed before it can be queried or searched.
    /// </summary>
    public static AIFunction AsIndexRepositoryTool(this GreptileClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The remote service: 'github' or 'gitlab'")] string remote,
                   [Description("The repository in owner/repo format (e.g., 'greptileai/examples')")] string repository,
                   [Description("The branch to index (e.g., 'main')")] string branch,
                   [Description("Whether to force re-indexing if already indexed")] bool? reload,
                   CancellationToken cancellationToken) =>
            {
                var remoteEnum = string.Equals(remote, "gitlab", StringComparison.OrdinalIgnoreCase)
                    ? IndexRepositoryRequestRemote.Gitlab
                    : IndexRepositoryRequestRemote.Github;

                var response = await client.IndexRepositoryAsync(
                    remote: remoteEnum,
                    repository: repository,
                    branch: branch,
                    reload: reload,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Message,
                    response.StatusEndpoint,
                    response.RepositoryId,
                };
            },
            name: "Greptile_IndexRepository",
            description: "Submit a repository for indexing. The repository must be indexed before it can be queried or searched. Indexing may take time for large repositories.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the current status and information
    /// about a repository's index.
    /// </summary>
    public static AIFunction AsGetRepositoryStatusTool(this GreptileClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The repository ID in the format remote:branch:owner/repo (e.g., 'github:main:greptileai/examples')")] string repositoryId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetRepositoryInfoAsync(
                    repositoryId: repositoryId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Repository,
                    response.Remote,
                    response.Branch,
                    response.Private,
                    response.Status,
                    response.FilesProcessed,
                    response.NumFiles,
                    response.Sha,
                };
            },
            name: "Greptile_GetRepositoryStatus",
            description: "Get the current indexing status and information about a repository including files processed, total files, and Git SHA.");
    }

    private static List<RepositoryRef> ParseRepositories(string repositories)
    {
        var repos = new List<RepositoryRef>();
        foreach (var repo in repositories.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            var parts = repo.Split(':', 3);
            if (parts.Length == 3)
            {
                var remoteEnum = string.Equals(parts[0], "gitlab", StringComparison.OrdinalIgnoreCase)
                    ? RepositoryRefRemote.Gitlab
                    : RepositoryRefRemote.Github;

                repos.Add(new RepositoryRef
                {
                    Remote = remoteEnum,
                    Branch = parts[1],
                    Repository = parts[2],
                });
            }
        }

        return repos;
    }
}
