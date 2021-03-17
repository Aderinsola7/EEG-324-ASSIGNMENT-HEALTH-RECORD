using System;

namespace ComputerizationHealthRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            var firstname = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            var lastname = Console.ReadLine();
            Console.WriteLine("What is your year of birth? ");
            var yearofbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your gender? ('M' or 'F') ");
            var gender = Console.ReadLine();
            Console.WriteLine("What is your height in inches? ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your weight in pounds? ");
            var weight = Convert.ToInt32(Console.ReadLine());

            var healthProfile = new HealthProfile(firstname, lastname, yearofbirth, gender, height, weight);

            Console.WriteLine("Name: {0} {1}", healthProfile.PatientFirstName, healthProfile.PatientlastName);
            Console.WriteLine("Year of birth: {0}",healthProfile.PatientYearOfBirth);
            Console.WriteLine("Age: {0}", healthProfile.Age);
            Console.WriteLine("Gender: {0}", healthProfile.PatientGender.ToUpper() == "M"? "Male" : "Female");
            Console.WriteLine("Max safe heart rate: {0}. Workout heart rate target range {1} to {2}", healthProfile.MaxHeartRate, healthProfile.MinTargetRate, healthProfile.MaxTargetRate);
            Console.WriteLine("Height: {0}\". Weight {1} 1bs",healthProfile.PatientHeight ,healthProfile.PatientWeight);
            Console.WriteLine("BMI: {0:##.##}%, Which means you are {1}", healthProfile.BMI, healthProfile.BMIEvaluation());
            Console.ReadLine();
            
        }
    }
}
