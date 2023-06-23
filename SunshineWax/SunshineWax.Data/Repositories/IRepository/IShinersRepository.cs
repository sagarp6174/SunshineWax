using SunshineWax.Data.Repositories.IRepository;
using SunshineWax.Models.BookingModels;

namespace SunshineWax.Data.Repositories.IRepository
{ 
    public interface IShinersRepository : IRepository<Sunshiners>
    {
        void Update(Services service);
        void Save();
    }

}

