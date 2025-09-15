using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Cns.Module.Ai.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
