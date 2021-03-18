using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpModals.Data
{
    /* This is used if database provider does't define
     * IAbpModalsDbSchemaMigrator implementation.
     */
    public class NullAbpModalsDbSchemaMigrator : IAbpModalsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}