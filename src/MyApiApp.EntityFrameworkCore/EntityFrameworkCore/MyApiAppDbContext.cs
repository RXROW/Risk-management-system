using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using MyApiApp.Configurations;
using ABPCourse.Demo1.Categories;
using ABPCourse.Demo1.Products;
using MyApiApp.Domain;
using MyApiApp.Domain.Risks;

namespace MyApiApp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class MyApiAppDbContext :
    AbpDbContext<MyApiAppDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }

    // Categories
    public DbSet<Category> Categories { get; set; }

    // Products
    public DbSet<Product> Products { get; set; }
    public DbSet<Risk> Risks { get; set; }
    public DbSet<RiskCategory> RiskCategories { get; set; }
    public DbSet<RiskStage> RiskStages { get; set; }
    public DbSet<RiskResponse> RiskResponses { get; set; }
    public DbSet<RiskStatement> RiskStatements { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    public DbSet<Entity> Entities { get; set; }

    public DbSet<FunctionalDomain> FunctionalDomains { get; set; }

    public DbSet<DomainArea> DomainAreas { get; set; }

    public DbSet<OwningGroup> OwningGroups { get; set; }

    public DbSet<RiskAssessment> RiskAssessments { get; set; }

    #endregion

    public MyApiAppDbContext(DbContextOptions<MyApiAppDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        builder.ApplyConfiguration(new CategoryConfiguration());
        builder.ApplyConfiguration(new ProductConfiguration()); 
        builder.Entity<RiskCategory>();
        builder.Entity<RiskStage>();
        builder.Entity<RiskResponse>();

        builder.Entity<Risk>(b =>
        {
            b.HasOne(r => r.RiskCategory)
                .WithMany()
                .HasForeignKey(r => r.RiskCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.RiskStage)
                .WithMany()
                .HasForeignKey(r => r.RiskStageId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.RiskResponse)
                .WithMany()
                .HasForeignKey(r => r.RiskResponseId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.Entity)
                .WithMany(e => e.Risks)
                .HasForeignKey(r => r.EntityId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.FunctionalDomain)
                .WithMany()
                .HasForeignKey(r => r.FunctionalDomainId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.DomainArea)
                .WithMany()
                .HasForeignKey(r => r.DomainAreaId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.RiskOwningGroup)
                .WithMany()
                .HasForeignKey(r => r.RiskOwningGroupId)
                .OnDelete(DeleteBehavior.Restrict);
            b.HasOne(r => r.RiskStatement)
                .WithMany()
                .HasForeignKey(r => r.RiskStatementId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Entity>();

        builder.Entity<DomainArea>(b =>
        {
            b.HasOne(d => d.FunctionalDomain)
                .WithMany()
                .HasForeignKey(d => d.FunctionalDomainId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<RiskAssessment>(b =>
        {
            b.HasOne(ra => ra.Risk)
                .WithMany()
                .HasForeignKey(ra => ra.RiskId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
