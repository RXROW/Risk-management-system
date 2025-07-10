using Microsoft.Extensions.Localization;
using MyApiApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyApiApp;

[Dependency(ReplaceServices = true)]
public class MyApiAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyApiAppResource> _localizer;

    public MyApiAppBrandingProvider(IStringLocalizer<MyApiAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
