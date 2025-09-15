using Volo.Abp.Settings;

namespace AbpSolution3.Settings;

public class AbpSolution3SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpSolution3Settings.MySetting1));
    }
}
