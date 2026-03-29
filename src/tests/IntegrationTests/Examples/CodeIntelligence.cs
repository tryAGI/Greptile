/*
order: 10
title: Code Intelligence
slug: code-intelligence

Examples showing how to query and search codebases using Greptile's AI-powered code intelligence API.
*/

namespace Greptile.IntegrationTests;

public partial class Tests
{
    //// ## Index a Repository
    //// Before querying or searching, you must index a repository.
    [TestMethod]
    public async Task Example_IndexRepository()
    {
        using var client = GetAuthenticatedClient();

        //// Submit a repository for indexing:
        var response = await client.IndexRepositoryAsync(
            remote: IndexRepositoryRequestRemote.Github,
            repository: "greptileai/examples",
            branch: "main",
            reload: false);

        response.Message.Should().NotBeNullOrEmpty();
    }

    //// ## Get Repository Status
    //// Check the indexing status of a repository.
    [TestMethod]
    public async Task Example_GetRepositoryStatus()
    {
        using var client = GetAuthenticatedClient();

        //// Get repository indexing status using the format remote:branch:owner/repo:
        var info = await client.GetRepositoryInfoAsync(
            repositoryId: "github:main:greptileai/examples");

        info.Repository.Should().NotBeNullOrEmpty();
        info.Status.Should().NotBeNull();
    }

    //// ## Query a Codebase
    //// Ask a natural language question and get an AI-generated answer with source references.
    [TestMethod]
    public async Task Example_QueryCodebase()
    {
        using var client = GetAuthenticatedClient();

        //// Query a codebase with a natural language question:
        var response = await client.QueryCodebaseAsync(
            messages:
            [
                new QueryMessage
                {
                    Content = "What does this repository do?",
                    Role = QueryMessageRole.User,
                },
            ],
            repositories:
            [
                new RepositoryRef
                {
                    Remote = RepositoryRefRemote.Github,
                    Repository = "greptileai/examples",
                    Branch = "main",
                },
            ]);

        response.Message.Should().NotBeNullOrEmpty();
    }

    //// ## Search a Codebase
    //// Search for relevant code without generating an AI answer.
    [TestMethod]
    public async Task Example_SearchCodebase()
    {
        using var client = GetAuthenticatedClient();

        //// Search for code relevant to a natural language query:
        var response = await client.SearchCodebaseAsync(
            messages:
            [
                new QueryMessage
                {
                    Content = "API authentication",
                    Role = QueryMessageRole.User,
                },
            ],
            repositories:
            [
                new RepositoryRef
                {
                    Remote = RepositoryRefRemote.Github,
                    Repository = "greptileai/examples",
                    Branch = "main",
                },
            ]);

        response.Sources.Should().NotBeNull();
    }
}
