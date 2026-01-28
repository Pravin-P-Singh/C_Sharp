using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility_Classes_Medical_Bot_Project
{
    public class Patient
    {
        public string _name;
        public int _age;
        public string _gender;
        public string _medicalHistory;
        public string _symptomCode;
        public string _prescription;

        public Patient()
        {

        }
        public Patient(string name,int age, string gender, string medicalHistory, string symptomCode, string prescription)
        {
            this._name = name;
            this._age = age;
            this._gender = gender;
            this._medicalHistory = medicalHistory;
            this._symptomCode = symptomCode;
            this._prescription = prescription;
        }
        public string GetName()
        {
            return _name;
        }

        public bool SetName(string name, out string errorMessage)
        {
            if (name.Length >= 2)
            {
                _name = name;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Name is invalid! Name should be of two or more characters";
                return false;
            }
        }

        public int GetAge()
        {
            return _age;
        }

        public bool SetAge(int age, out string errorMessage)
        {
            if(age >0 && age <= 100)
            {
                errorMessage = "";
                _age = age;
                return true;
            }
            else
            {
                errorMessage = "Age cannot be negative or greater than 100";
                return false;
            }
        }

        public string GetGender()
        {
            return _gender;
        }

        public bool SetGender(string gender, out string errorMessage)
        {
            if(gender == "Male" || gender == "Female" || gender == "Other")
            {
                _gender = gender;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Invalid gender input";
                return false;
            }
        }

        public string GetMedicalHistory()
        {
            return _medicalHistory;
        }

        public void SetMedicalHistory(string medicalHistory)
        {
            _medicalHistory = medicalHistory;
        }

        public string GetSymptoms()
        {
            return _symptomCode;
        }

        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            symptomCode = symptomCode.ToLower();
            if ((symptomCode == "s1") || (symptomCode == "s2") || (symptomCode == "s3"))
            {
                _symptomCode = symptomCode;
                errorMessage = "";
                return true;
            }
            else
            {
                _symptomCode = "Unknown";
                errorMessage = "Unknown Symptom";
                return false;
            }
        }

        public string GetPrescription()
        {
            return _prescription;
        }

        public void SetPrescription(string prescription)
        {
            _prescription = prescription;
        }
    }
}
