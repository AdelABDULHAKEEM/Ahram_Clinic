using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Models.Repositories
{
    public class DoctorDbRepository : ClinicRepository<Doctors>
    {
        AhramClinicDBContext db;
        public DoctorDbRepository(AhramClinicDBContext _db){
            db = _db;
            }
        public void Add(Doctors entity)
        {
            db.Doc.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var doctor = Find(id);
            db.Doc.Remove(doctor);
            db.SaveChanges();

        }

        public Doctors Find(int id)
        {
            var doctor = db.Doc.FirstOrDefault(a => a.ID == id);
            return doctor;
        }

        public IList<Doctors> List()
        {
            return db.Doc.ToList();
        }

        public void Update(int id, Doctors doctor)
        {
            db.Update(doctor);
            db.SaveChanges();
        }
    }
}
