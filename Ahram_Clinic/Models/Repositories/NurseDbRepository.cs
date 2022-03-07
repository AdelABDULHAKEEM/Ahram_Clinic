using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Models.Repositories
{
    public class NurseDbRepository : ClinicRepository<Nurses>
    {
        AhramClinicDBContext db;
        public NurseDbRepository(AhramClinicDBContext _db)
        {
            db = _db;
        }
        public void Add(Nurses entity)
        {
            db.Nur.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var nurse = Find(id);
            db.Nur.Remove(nurse);
            db.SaveChanges();

        }

        public Nurses Find(int id)
        {
            var nurse = db.Nur.FirstOrDefault(a => a.ID == id);
            return nurse;
        }

        public IList<Nurses> List()
        {
            return db.Nur.ToList();
        }

        public void Update(int id, Nurses nurse)
        {
            db.Update(nurse);
            db.SaveChanges();
        }
    }
}
