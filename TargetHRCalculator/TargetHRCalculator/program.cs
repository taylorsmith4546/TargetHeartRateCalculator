using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHRCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Please enter your year of birth: ");
            var yearOfBirth = Convert.ToInt32(Console.ReadLine());

            var heartRate = new HeartRate(firstName, lastName, yearOfBirth);

            Console.WriteLine("Your name is {0} {1}", heartRate.FirstName, heartRate.LastName);
            if (heartRate.YearOfBirth != 0)
            {
                Console.WriteLine("Your age is {0}", heartRate.PersonAge);
                Console.WriteLine("Your max safe heart rate is {0}", heartRate.MaxHeartRate);
                Console.WriteLine("Your max target heart rate is {0}", heartRate.MaxTargetHeartRate);
                Console.WriteLine("Your min target heart rate is {0}", heartRate.MinTargetHeartRate);
            }
            else
            {
                Console.WriteLine("Calculations could not be performed because you did not provide a valid birth year");
            }
            

            Console.ReadKey();         
        }
    }
}
