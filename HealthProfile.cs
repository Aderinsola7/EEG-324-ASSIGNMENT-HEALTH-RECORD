using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerizationHealthRecords
{
    class HealthProfile
    {
        private int _patientYearOfBirth;
        private string _patientGender;

        public HealthProfile(string firstname, string lastname, int yearofbirth, string gender, int height, int weight  )
        {
            PatientFirstName = firstname;
            PatientlastName = lastname;
            PatientYearOfBirth = yearofbirth;
            PatientGender = gender;
            PatientHeight = height;
            PatientWeight = weight;

        }

        public string PatientFirstName { get; set; }
        public string PatientlastName { get; set; }
        public int PatientHeight { get; set; }
        public int PatientWeight { get; set; }

        public int PatientYearOfBirth
        {
            get
            {
                return _patientYearOfBirth;
            }
            set
            {
                while (value < 2001)
                {
                    Console.WriteLine("invalid year of birth ,please inter the correct year of birth: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _patientYearOfBirth = value;
            }
        }

        public string PatientGender
        {
            get
            {
                return _patientGender;
            }
            set
            {
                while (value.ToUpper() != "M" && value.ToUpper() != "F") ;
                {
                    Console.WriteLine("Please enter the correct gender (M or F)");
                    value = Console.ReadLine();
                }


                _patientGender = value;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Today.Year - _patientYearOfBirth;
            }
        }

        public int MaxHeartRate
        {
            get
            {
                return 220 - Age;
            }
        }
        public int MaxTargetRate
        {
            get
            {
                return (Convert.ToInt32(MaxHeartRate * 0.92));
            }
        }
        public int MinTargetRate
        {
            get
            {
                return (Convert.ToInt32(MaxHeartRate * 0.7));
            }
        }

        public double BMI
        {
            get
            {
                return (PatientWeight / (Math.Pow(PatientHeight, 2))) * 703;
            }
        }

        public string BMIEvaluation()
        {
            if (BMI < 18.5)
                return "Underweight";
            else if (BMI < 25)
                return "Normal";
            else if (BMI < 30)
                return "Overweight";
            else
                return "Obese";
        }
    }
}
