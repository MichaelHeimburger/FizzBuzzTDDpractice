using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Get(int num)
        {
            if ((IsMultipleOf3(num))&&(IsMultipleOf5(num)))
            {
                return "FizzBuzz";
            }
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }
            return num.ToString();
            

        }


        private bool IsMultipleOf3(int numberToCheck)
        { // refactored code doesnt modify the function but instead adds a method that does the math operation instead of having it in the main code
            return numberToCheck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberToCheck)
        { // refactored code doesnt modify the function but instead adds a method that does the math operation instead of having it in the main code
            return numberToCheck % 5 == 0;
        }
    }

}
