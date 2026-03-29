# Microsoft.Extensions.AI Integration

The Greptile SDK provides `AIFunction` tools that can be used with any `IChatClient` from the Microsoft.Extensions.AI ecosystem.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsQueryCodebaseTool()` | Ask natural language questions about a codebase and get AI-powered answers with source code references |
| `AsSearchCodebaseTool()` | Search a codebase for relevant code files, functions, and snippets without an AI explanation |
| `AsIndexRepositoryTool()` | Submit a repository for indexing (required before querying/searching) |
| `AsGetRepositoryStatusTool()` | Check the indexing status of a repository |

## Usage Example

```csharp
using Greptile;
using Microsoft.Extensions.AI;

// Create Greptile client
var greptileClient = new GreptileClient(apiKey);
greptileClient.WithGitHubToken(githubToken);

// Create tools
var tools = new[]
{
    greptileClient.AsQueryCodebaseTool(),
    greptileClient.AsSearchCodebaseTool(),
    greptileClient.AsIndexRepositoryTool(),
    greptileClient.AsGetRepositoryStatusTool(),
};

// Use with any IChatClient that supports tool calling
var chatClient = ...; // Your IChatClient implementation
var response = await chatClient.GetResponseAsync(
    "What does the greptileai/examples repository do?",
    new ChatOptions { Tools = tools });
```

## Authentication

The Greptile API requires two tokens:

1. **Greptile API Key** (required): Obtain from [app.greptile.com](https://app.greptile.com/login)
2. **GitHub/GitLab Token** (optional): Personal access token for private repository access

```csharp
var client = new GreptileClient(greptileApiKey);
client.WithGitHubToken(githubToken); // Optional
```

## Repository Format

Tools that accept repositories use a comma-separated format: `remote:branch:owner/repo`

Examples:
- `github:main:owner/repo`
- `gitlab:develop:org/project`
- `github:main:owner/repo1,github:main:owner/repo2` (multiple repos)
