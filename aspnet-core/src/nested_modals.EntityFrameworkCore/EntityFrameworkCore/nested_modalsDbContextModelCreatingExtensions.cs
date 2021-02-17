using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace nested_modals.EntityFrameworkCore
{
    public static class nested_modalsDbContextModelCreatingExtensions
    {
        public static void Configurenested_modals(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(nested_modalsConsts.DbTablePrefix + "YourEntities", nested_modalsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}