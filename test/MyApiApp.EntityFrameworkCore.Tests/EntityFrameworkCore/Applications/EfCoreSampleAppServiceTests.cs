using MyApiApp.Samples;
using Xunit;

namespace MyApiApp.EntityFrameworkCore.Applications;

[Collection(MyApiAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyApiAppEntityFrameworkCoreTestModule>
{

}
