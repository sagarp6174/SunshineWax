using SunshineWax.Models.BookingModels;

namespace SunshineWax.Data.Repositories.IRepository
{
    public interface IServiceRepository : IRepository<Services>
    {
        void Update(Services service);
        void Save();
    }
}
