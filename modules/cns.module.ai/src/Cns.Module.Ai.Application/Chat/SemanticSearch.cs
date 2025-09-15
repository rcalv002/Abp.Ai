using Microsoft.Extensions.VectorData;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cns.Module.Ai.Chat;

public class SemanticSearch(
    VectorStoreCollection<string, IngestedChunk> vectorCollection)
{
    public async Task<IReadOnlyList<IngestedChunk>> SearchAsync(string text, string? documentIdFilter, int maxResults)
    {
        var nearest = vectorCollection.SearchAsync(text, maxResults, new VectorSearchOptions<IngestedChunk>
        {
            Filter = documentIdFilter is { Length: > 0 } ? record => record.DocumentId == documentIdFilter : null,
        });

        return await nearest.Select(result => result.Record).ToListAsync();
    }
}
