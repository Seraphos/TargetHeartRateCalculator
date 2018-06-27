using System;

namespace TargetHeartRateCalculator
{
    class TargetHeartRateCalculatorTest
    {
        static void Main(string[] args)
        {
            int yearOfBirth, currentYear;
            string firstName, lastName;
            double maxHeartRate, userAge, lowerHRRangeBound, upperHRRangeBound;

            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            HeartRates newCustomerHeartRate = new HeartRates(firstName, lastName, currentYear, yearOfBirth);

            userAge = newCustomerHeartRate.CalculateAge(currentYear, yearOfBirth);
            maxHeartRate = newCustomerHeartRate.CalculateMaxumumHearRate(userAge);
            lowerHRRangeBound = newCustomerHeartRate.CalculateLowerTargetHeartRateRangeBound(maxHeartRate);
            upperHRRangeBound = newCustomerHeartRate.CalculateUpperTargetHeartRateRangeBound(maxHeartRate);

            Console.WriteLine("{0} {1}, based on your input you are {2} years old.", firstName, lastName, userAge);
            Console.WriteLine("Your maximum recommended heart rate is {0}", maxHeartRate);
            Console.WriteLine("The ideal working heart rate range for you is between {0} bpm, and {1} bpm.", lowerHRRangeBound, upperHRRangeBound);



        }//end main method
    }//end class
}//end namespace
