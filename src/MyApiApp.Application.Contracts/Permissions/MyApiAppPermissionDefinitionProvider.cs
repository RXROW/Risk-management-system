using MyApiApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyApiApp.Permissions;

public class MyApiAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyApiAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyApiAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyApiAppResource>(name);
    }
}
