using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility_Classes_Medical_Bot_Project;

namespace Medical_Bot
{
    internal class Program
    {
        string patientName;
        int patientAge;
        string patientGender;
        string patientMedicalHistory;
        string patientSymptoms;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to medical bot system.");
            Program p = new Program();
            p.GetPatientDetails();
            Patient patient = new Patient(p.patientName,p.patientAge,p.patientGender,p.patientMedicalHistory,p.patientSymptoms,"");
            MedicalBot medicalBot = new MedicalBot();
            medicalBot.PrescribeMedication(patient);


            Console.WriteLine("Thank you for coming!");
        }
        private void  GetPatientDetails()
        {
            Console.WriteLine("Enter patient name:: ");
            this.patientName = Console.ReadLine();
            Console.WriteLine("Enter patient age:: ");
            this.patientAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the patient gender:: ");
            this.patientGender = Console.ReadLine();
            Console.WriteLine("Enter the patient's medical history ex- Diabetes Press Enter for none:: ");
            this.patientMedicalHistory = Console.ReadLine().ToLower();

            Console.WriteLine($"Welcome, {patientName}, {patientAge}.");
            Console.WriteLine("What symptoms do you have::\n s1. Headache \n s2. Skin rashes \n s3. Dizziness \n Enter the symptom code from above list (s1,s2,s3) : ");
            this.patientSymptoms = Console.ReadLine();
            
        }

        
    }
}
