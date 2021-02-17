using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace nested_modals.Data
{
    /* This is used if database provider does't define
     * Inested_modalsDbSchemaMigrator implementation.
     */
    public class Nullnested_modalsDbSchemaMigrator : Inested_modalsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}