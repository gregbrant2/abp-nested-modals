using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpModals.EntityFrameworkCore
{
    public static class AbpModalsDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpModals(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpModalsConsts.DbTablePrefix + "YourEntities", AbpModalsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}