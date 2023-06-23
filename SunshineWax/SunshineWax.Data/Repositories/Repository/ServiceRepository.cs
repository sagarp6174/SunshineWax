using SunshineWax.Data.Data;
using SunshineWax.Data.Repositories.IRepository;
using SunshineWax.Models.BookingModels;

namespace SunshineWax.Data.Repositories.Repository
{
    public class ServiceRepository : Repository<Services>, IServiceRepository
    {
        private readonly ApplicationDbContext _db;
        public ServiceRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Services service)
        {
            _db.Services.Update(service);
        }
    }
}
