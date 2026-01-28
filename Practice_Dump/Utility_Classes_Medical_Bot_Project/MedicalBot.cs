using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility_Classes_Medical_Bot_Project
{
    public class MedicalBot
    {
        private const string _botName = "Bob";


        public static string GetBotName()
        {
            return _botName;
        }

        public void  PrescribeMedication(Patient patient)
        {
            switch (patient._symptomCode)
            {
                case "s1" : patient.SetPrescription("ibuprofen"); break;
                case "s2" : patient.SetPrescription("diphenhydramine"); break;
                case "s3" :
                    {
                        if (patient.GetMedicalHistory().Equals("diabetes"))
                        {
                            patient.SetPrescription("metformin");
                        }
                        else
                        {
                            patient.SetPrescription("dimenhydrinate");
                        }
                    }; break;
                default: patient.SetPrescription("No medicine prescription available."); break;
            }
            Console.WriteLine(GetDosage(patient, patient.GetPrescription()));
        }

        public string GetDosage(Patient patient, string medicineName)
        {
            switch (medicineName)
            {
                case "ibuprofen":
                {
                        if (patient.GetAge() <= 18)
                        {
                            patient.SetPrescription($"{patient._prescription} 400 mg");
                        }
                        else
                        {
                            patient.SetPrescription($"{patient._prescription} 800 mg");
                        }
                }; break;

                case "diphenhydramine":
                {
                        if (patient.GetAge() <= 18)
                        {
                           patient.SetPrescription($"{patient._prescription} 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription($"{patient._prescription} 300 mg");
                        }
                }; break;

                case "dimenhydrinate":
                {
                        if (patient.GetAge() <= 18)
                        {
                           patient.SetPrescription($"{patient._prescription} 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription($"{patient._prescription} 400 mg");
                        }
                }; break;

                case "metformin":
                {
                        patient.SetPrescription($"{patient._prescription} 500 mg");
                    }
                    ; break;

                default: patient.SetPrescription("No prescription available"); break;
            }
            return patient.GetPrescription();
        }
     }
}
