using Cns.Module.Ai.Blazor.Menus;
using Cns.Module.Ai.Chat;
using Cns.Module.Ai.Chat.Ingestion;

using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

using OllamaSharp;

using System;
using System.IO;

using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Cns.Module.Ai.Blazor;

[DependsOn(
    typeof(AiApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class AiBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AiBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<AiBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new AiMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AiBlazorModule).Assembly);
        });

        IChatClient chatClient = new OllamaApiClient(new Uri("http://localhost:11435"), "llama3.2");
        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = new OllamaApiClient(new Uri("http://localhost:11434"), "all-minilm");

        var vectorStorePath = Path.Combine(AppContext.BaseDirectory, "vector-store.db");
        var vectorStoreConnectionString = $"Data Source={vectorStorePath}";
        context.Services.AddSqliteCollection<string, IngestedChunk>("data-chatapp1-chunks", vectorStoreConnectionString);
        context.Services.AddSqliteCollection<string, IngestedDocument>("data-chatapp1-documents", vectorStoreConnectionString);
        context.Services.AddScoped<DataIngestor>();
        context.Services.AddSingleton<SemanticSearch>();
        context.Services.AddChatClient(chatClient).UseFunctionInvocation().UseLogging();
        context.Services.AddEmbeddingGenerator(embeddingGenerator);
    }
}
