using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHRCalculator
{
    class HeartRate
    {

        //private members

        private string _firstName;
        private string _lastName;
        private int _yearOfBirth;

        public HeartRate(string firstName, string lastName, int yearOfBirth)
        {
            //getting the current year
            CurrentYear = DateTime.Today.Year;
            //assign values passed into constructor
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        //assigning first name, if provided
        public string FirstName
        {
            get { return _firstName;}
            set { _firstName = value == "" ? "n/a" : value;}
        }

        //assign last name, if provided
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value == "" ? "n/a" : value;}
        }
        //assign year of birth
        //if not provided, default to 0
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value < 1 ? 0 : value;}
        }
        //current year is set in constructor only
        //cannot be set by user
        public readonly int CurrentYear;

        //calculate person's age
        public int PersonAge
        {
            get { return CurrentYear - YearOfBirth;}
        }
        //calculate maximum heart rate
        public int MaxHeartRate
        {
            get { return 220 - PersonAge;}
        }
        //calculate minumum heart rate (50% of max)
        public int MinTargetHeartRate
        {
            get { return Convert.ToInt32(MaxHeartRate * 0.5); }
        }
        //calculate maxiumum target heart rate (85% of max)
        public int MaxTargetHeartRate
        {
            get { return Convert.ToInt32(MaxHeartRate * 0.85); }
        }
    }
    }

