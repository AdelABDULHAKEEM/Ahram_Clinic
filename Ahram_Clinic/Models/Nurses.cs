using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Models
{
    public class Nurses
    {
        [Key]
        public int ID { get; set; }
        public string Nur_Name { get; set; }
        public string Nur_Email { get; set; }
        public string Nur_Password { get; set; }
        public string Nur_UserName { get; set; }
        public string Nur_Address { get; set; }
        public int Nur_Phone { get; set; }
    }
}
