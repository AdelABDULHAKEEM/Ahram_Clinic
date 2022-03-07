using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Models.Repositories
{
    public class PatientDbRepository : ClinicRepository<Patients>
    {
        AhramClinicDBContext db;
        public PatientDbRepository(AhramClinicDBContext _db)
        {
            db = _db;
        }
        public void Add(Patients entity)
        {
            db.Pat.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var patient = Find(id);
            db.Pat.Remove(patient);
            db.SaveChanges();

        }

        public Patients Find(int id)
        {
            var patient = db.Pat.FirstOrDefault(a => a.ID == id);
            return patient;
        }

        public IList<Patients> List()
        {
            return db.Pat.ToList();
        }

        public void Update(int id, Patients patient)
        {
            db.Update(patient);
            db.SaveChanges();
        }
    }
}
