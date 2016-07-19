using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class SquareRoot
    {
        //Constructor accepts error limit *1 as a double
        public SquareRoot(double limit)
        {
            this.errorlimit = limit;
        }
        public double errorlimit { get; set; }

        //Method to guess the square root of a number.
        //Takes in the number and an error limit. 
        public double ComputeSquareRoot(double number)
        {
            //Checks to make sure number is positive
            if (number < 1)
            {
                throw new System.ArgumentException("Negative numbers are not allowed.");
            }

            //Initial guess starts as the number divided by 2
            double guess = number / 2;

            //If the differece is greater than the error limit then need to guess again by
            //taking the average of the first guess and the number divided by the previous guess
            while (Math.Abs(number - (guess * guess)) > errorlimit)
            {
                guess = (guess + (number / guess)) * .5;
            }

            return guess;
        }
    }
}
