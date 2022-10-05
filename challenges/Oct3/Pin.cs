using System;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Numerics;

namespace staging_challenges
{
//    (i) Create a function that will test if a string is a valid PIN or not via a regular expression.

//    A valid PIN has:

//Exactly 4 or 6 characters.

//Only numeric characters(0-9).
	
//No whitespace.
    public class Pin
    {
        public bool Solution(string pin)
        {
            bool isValid = true;

            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char i in pin)
                {
                    Console.WriteLine(i);
                    if (i == ' ')
                    {
                        isValid = false;
                        break;
                    }
                    else if (!char.IsNumber(i))
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            else
            {
                isValid = false;
            }

            Console.WriteLine(isValid);
            return isValid;
        }
    }
}

