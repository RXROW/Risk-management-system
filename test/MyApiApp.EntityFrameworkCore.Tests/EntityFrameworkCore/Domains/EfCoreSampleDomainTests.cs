using MyApiApp.Samples;
using Xunit;

namespace MyApiApp.EntityFrameworkCore.Domains;

[Collection(MyApiAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyApiAppEntityFrameworkCoreTestModule>
{

}
