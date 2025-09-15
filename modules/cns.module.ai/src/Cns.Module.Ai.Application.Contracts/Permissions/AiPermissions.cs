using Volo.Abp.Reflection;

namespace Cns.Module.Ai.Permissions;

public class AiPermissions
{
    public const string GroupName = "Ai";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AiPermissions));
    }
}
