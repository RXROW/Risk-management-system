using Xunit;

namespace MyApiApp.EntityFrameworkCore;

[CollectionDefinition(MyApiAppTestConsts.CollectionDefinitionName)]
public class MyApiAppEntityFrameworkCoreCollection : ICollectionFixture<MyApiAppEntityFrameworkCoreFixture>
{

}
