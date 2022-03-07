using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Models
{
    public class Patients
    {
        [Key]
        public int ID { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Email { get; set; }
        public string Patient_Password { get; set; }
        public string Patient_Address { get; set; }
        public int Patient_Phone { get; set; }
        public string Patient_UserName { get; set; }

    }
}
