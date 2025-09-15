using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Cns.Module.Ai.Blazor.Menus;

public class AiMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(AiMenus.Prefix, displayName: "Ai", "/Chat", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
