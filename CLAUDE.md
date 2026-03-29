# CLAUDE.md -- Greptile SDK

## Overview

Auto-generated C# SDK for [Greptile](https://www.greptile.com/) -- AI-powered codebase intelligence with natural language Q&A, code search, and repository indexing.
OpenAPI spec manually created from Greptile API documentation (no public spec exists).

## Build & Test

```bash
dotnet build Greptile.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key via Bearer token. Optional GitHub/GitLab token for private repo access:

```csharp
var client = new GreptileClient(apiKey);       // GREPTILE_API_KEY env var
client.WithGitHubToken(githubToken);           // Optional: GITHUB_TOKEN env var
```

## Key Files

- `src/libs/Greptile/openapi.yaml` -- Manually created OpenAPI 3.0.3 spec
- `src/libs/Greptile/generate.sh` -- Runs autosdk to generate code
- `src/libs/Greptile/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Greptile/Extensions/GreptileClient.PrepareRequest.cs` -- X-GitHub-Token header hook
- `src/libs/Greptile/Extensions/GreptileClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints

```csharp
var client = new GreptileClient(apiKey);

// Index a repository (must be done before querying)
await client.IndexRepositoryAsync(remote, repository, branch, reload);

// Get repository indexing status
await client.GetRepositoryInfoAsync(repositoryId);

// Query a codebase (AI answer + source references)
await client.QueryCodebaseAsync(messages, repositories, sessionId, stream, genius);

// Search a codebase (source references only, no AI answer)
await client.SearchCodebaseAsync(messages, repositories, sessionId, genius);
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsQueryCodebaseTool()` -- Ask natural language questions and get AI answers with source references
- `AsSearchCodebaseTool()` -- Search for relevant code without an AI explanation
- `AsIndexRepositoryTool()` -- Submit a repository for indexing
- `AsGetRepositoryStatusTool()` -- Check repository indexing status

## Spec Notes

- Base URL: `https://api.greptile.com/v2`
- Auth: Bearer token (Greptile API key) + optional `X-GitHub-Token` header
- Query format follows OpenAI Chat format (messages array with role/content)
- Repository IDs use `remote:branch:owner/repo` format (URL-encoded in path params)
- Genius mode: smarter but slower analysis (optional boolean on query/search)
