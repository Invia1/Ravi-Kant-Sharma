using Hospital_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Ipatient
{
    internal interface Interface
    {
        int addPatient(Patient temp);
        List<Patient> display();
    }
}
