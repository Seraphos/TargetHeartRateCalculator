using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TargetHeartRateCalculator
{
    class HeartRates
    {
        private string firstName, lastName;
        private int currentYear, yearOfBirth;
        //firstname property
        public string FirstName {
            get { return firstName; }
            set { firstName = value; } }
        //lastname property
        public string LastName {
            get { return lastName; }
            set { lastName = value; } }
        //currentyear property; validate for negative numbers and zero
        public int CurrentYear {
            get { return currentYear; }
            set { if (currentYear <= 0) throw new ArgumentOutOfRangeException("No Negative numbers!");
                else currentYear = value; } }
        //yearofbirth property; validate for negative numbers and zero
        public int YearOfBirth {
            get { return yearOfBirth; }
            set { if (yearOfBirth <= 0) throw new ArgumentOutOfRangeException("No Negative numbers!");
                else yearOfBirth = value; } }

        public HeartRates(string constFirstName, string constLastName, int constCurrentYear, int constYearOfBirth)
        {
            firstName = constFirstName; lastName = constLastName; currentYear = constCurrentYear; yearOfBirth = constYearOfBirth;
        }//end constructor

        public double CalculateAge(int methCurrentYear, int methYearOfBirth)
        {
            double userAge = methCurrentYear - methYearOfBirth;
            return userAge;              
        }//end calculate age method

        //this method depends on either asking the user their age or using the calculate age method
        public double CalculateMaxumumHearRate(double methUserAge)
        {
            double userMaxHeartRate = 220-methUserAge;
            return userMaxHeartRate;
        }//end calculate max heart rate method

        public double CalculateLowerTargetHeartRateRangeBound(double methMaxHeartRate)
        {
            double lowerTargetHeartRateBound;
            lowerTargetHeartRateBound = methMaxHeartRate * .5;
            return lowerTargetHeartRateBound;
        }//end calc calculate lower boundary target heart rate range

        public double CalculateUpperTargetHeartRateRangeBound(double methMaxHeartRate)
        {
            double upperTargetHeartRateBound;
            upperTargetHeartRateBound = methMaxHeartRate * .85;
            return upperTargetHeartRateBound;
        }//end calculate upper boundary target heart rate range
        
    }//end class
}//end namespace
