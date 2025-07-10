using MyApiApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyApiApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyApiAppController : AbpControllerBase
{
    protected MyApiAppController()
    {
        LocalizationResource = typeof(MyApiAppResource);
    }
}
