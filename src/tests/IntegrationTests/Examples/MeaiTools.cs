/*
order: 20
title: MEAI Tools
slug: meai-tools

Examples showing how to use Greptile as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Greptile.IntegrationTests;

public partial class Tests
{
    //// ## Register Greptile Tools
    //// Create AIFunction tools that can be used with any IChatClient for tool calling.
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Greptile client:
        var queryTool = client.AsQueryCodebaseTool();
        var searchTool = client.AsSearchCodebaseTool();
        var indexTool = client.AsIndexRepositoryTool();
        var statusTool = client.AsGetRepositoryStatusTool();

        queryTool.Name.Should().Be("Greptile_QueryCodebase");
        searchTool.Name.Should().Be("Greptile_SearchCodebase");
        indexTool.Name.Should().Be("Greptile_IndexRepository");
        statusTool.Name.Should().Be("Greptile_GetRepositoryStatus");
    }
}
