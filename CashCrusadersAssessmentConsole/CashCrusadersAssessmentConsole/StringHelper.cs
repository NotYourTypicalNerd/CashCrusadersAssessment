using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusadersAssessmentConsole
{
    public static class StringHelper
    {
        public static int CountCharacterOccurance(char character, string input)
        {
            var inputAsArray = input.ToCharArray();
            var result = 0;

            for(int a =0; a < inputAsArray.Length; a++)
            {
                if (character == inputAsArray[a])
                {
                    result++;
                }
            }

            return result;

        }

        public static string ReverseString(string input)
        {
            var returnString = new StringBuilder();

            for(int a = input.Length - 1; a >= 0; a--) {
                returnString.Append(input[a]);
            }

            return returnString.ToString();
        }
    }
}
