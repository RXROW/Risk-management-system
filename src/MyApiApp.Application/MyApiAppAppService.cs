using System;
using System.Collections.Generic;
using System.Text;
using MyApiApp.Localization;
using Volo.Abp.Application.Services;

namespace MyApiApp;

/* Inherit your application services from this class.
 */
public abstract class MyApiAppAppService : ApplicationService
{
    protected MyApiAppAppService()
    {
        LocalizationResource = typeof(MyApiAppResource);
    }
}
