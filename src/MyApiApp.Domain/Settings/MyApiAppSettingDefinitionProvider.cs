using Volo.Abp.Settings;

namespace MyApiApp.Settings;

public class MyApiAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyApiAppSettings.MySetting1));
    }
}
