using Cns.Module.Ai.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cns.Module.Ai.Permissions;

public class AiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AiPermissions.GroupName, L("Permission:Ai"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AiResource>(name);
    }
}
