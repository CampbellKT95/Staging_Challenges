using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace staging_challenges
{
// Given an alphanumeric string made up of digits and lower case Latin characters only, find the sum of all the digit characters in the string.

// The first line of the input contains an integer T denoting the number of test cases.Then T test cases follow.

// Each test case is described with a single line containing a string S, the alphanumeric string.

// For each test case, output a single line containing the sum of all the digit characters in that string.

//Input:
//1
//ab1231da
//Output:
//7

    public class SumInString
    {
        public void Solution(string[] inputs)
        {
            int caseCount = Int32.Parse(inputs[0]);

            for (int i = 1; i <= caseCount; i++)
            {
                double sum = 0;

                foreach (char c in inputs[i])
                {
                    if (Char.IsNumber(c))
                    {
                        sum += Char.GetNumericValue(c);
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}

