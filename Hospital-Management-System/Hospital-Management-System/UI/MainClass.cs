using System;
using Hospital_Management_System.Ipatient;
using Hospital_Management_System.Model;
using Hospital_Management_System.Service;

namespace Hospital_Management_System.UI
{
     class MainClass
    {
        public static void Main()
        {
            //Patient obj = new Patient();
            Interface service = new GeneralMedicine();
            Interface service1 = new Orthopaedics();
            Interface service2 = new Dental();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter 1 for General Medicine...");
                Console.WriteLine("Enter 2 for Orthopaedics..");
                Console.WriteLine("Enter 3 for Dental..");
                Console.WriteLine("--------------------------------");
                int a;
                Console.WriteLine("Enter your choice..");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of general medicine..");
                            Console.WriteLine("Enter 2 For Display Patient list of general medicine..");
                            Console.WriteLine("-----------------------------------------------------------");
                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();

                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientRegistrationId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.PatientFirstName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.PatientLastName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.PatientPhoneNo = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.PatientGender = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.PatientAge = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.PatientAddress = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.PatientAdharNo = Convert.ToDouble(Console.ReadLine());

                                    service.addPatient(obj);
                                    break;
                                case 2:
                                    service.display();
                                    break;
                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of Orthopaedics..");
                            Console.WriteLine("Enter 2 For Display Patient list of Orthopaedics..");
                            Console.WriteLine("----------------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();

                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientRegistrationId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.PatientFirstName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.PatientLastName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.PatientPhoneNo = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.PatientGender = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.PatientAge = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.PatientAddress = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.PatientAdharNo = Convert.ToDouble(Console.ReadLine());

                                    service1.addPatient(obj);
                                    break;
                                case 2:
                                    service1.display();
                                    break;
                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of Dental..");
                            Console.WriteLine("Enter 2 For Display Patient list of Dental..");
                            Console.WriteLine("----------------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();

                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientRegistrationId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.PatientFirstName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.PatientLastName = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.PatientPhoneNo = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.PatientGender = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.PatientAge = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.PatientAddress = Console.ReadLine();
                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.PatientAdharNo = Convert.ToDouble(Console.ReadLine());

                                    service2.addPatient(obj);
                                    break;
                                case 2:
                                    service2.display();
                                    break;
                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;
                            }
                            break;
                        }


                }

            }
                string ch;
                Console.WriteLine("Do you want to Continue ? Enter 'Y' for Yes. Otherwise Press 'N'");
                ch = Console.ReadLine();
                if (ch == "Y" || ch == "y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
        }
        
        

       
}

