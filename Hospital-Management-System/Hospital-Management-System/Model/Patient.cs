using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Model
{
     class Patient
    {
        public int PatientRegistrationId { get; set; }
        public string PatientFirstName { get; set;}
        public string PatientLastName { get; set;}
        public double PatientPhoneNo { get; set;}
        public string PatientGender { get; set;}
        public int PatientAge { get; set;}
        public string PatientAddress { get; set;}
        public double PatientAdharNo { get; set;}

    }
}
