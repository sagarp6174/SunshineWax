using SunshineWax.Data.Data;
using SunshineWax.Data.Repositories.IRepository;
using SunshineWax.Models.BookingModels;

namespace SunshineWax.Data.Repositories.Repository
{
    public class ShinersRepository : Repository<Sunshiners>, IShinersRepository
    {
        private readonly ApplicationDbContext _db;
        public ShinersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Services shiners)
        {
            _db.Services.Update(shiners);
        }
    }
}
