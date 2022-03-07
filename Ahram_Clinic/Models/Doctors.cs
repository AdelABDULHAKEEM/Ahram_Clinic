using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ahram_Clinic.Models
{
    public class Doctors
    {
        [Key]
        public int ID { get; set; }
        public string Doc_Name { get; set; }
        public string Doc_Email { get; set; }
        public string Doc_Password { get; set; }
        public string Doc_UserName { get; set; }
        public string Doc_Address { get; set; }
        public int Doc_Phone { get; set; }
        public string Doc_Certificates { get; set; }
        public string Specialization { get; set; }


    }
}
