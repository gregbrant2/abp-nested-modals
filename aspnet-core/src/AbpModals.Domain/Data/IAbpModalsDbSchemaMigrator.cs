using System.Threading.Tasks;

namespace AbpModals.Data
{
    public interface IAbpModalsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
