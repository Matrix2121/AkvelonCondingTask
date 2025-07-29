using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonCodingTask
{
    public class FizzBuzzDetector
    {
        public static ReturnModel GetOverlappings(string input)
        {
            int wordCount = 0;

            string result = "";
            string currWord = "";

            char currChar;

            for (int i = 0; i < input.Length; i++)
            {
                currChar = input[i];

                if (AlphanumericChar(currChar))
                {
                    currWord += currChar;
                }
                else
                {
                    if (currWord.Length > 0)
                    {
                        wordCount++;
                        if (wordCount % 3 == 0 && wordCount % 5 == 0)
                        {
                            result += "FizzBuzz ";
                        }
                        else if (wordCount % 3 == 0)
                        {
                            result += "Fizz ";
                        }
                        else if (wordCount % 5 == 0)
                        {
                            result += "Buzz ";
                        }
                        else
                        {
                            result += currWord + " ";
                        }
                        currWord = "";
                    }
                    result += currChar;
                }
            }

            if (currWord.Length > 0)
            {
                wordCount++;
                if (wordCount % 3 == 0 && wordCount % 5 == 0)
                {
                    result += "FizzBuzz ";
                }
                else if (wordCount % 3 == 0)
                {
                    result += "Fizz ";
                }
                else if (wordCount % 5 == 0)
                {
                    result += "Buzz ";
                }
                else
                {
                    result += currWord;
                }
            }

            return new ReturnModel(result, wordCount);
        }

        private static bool AlphanumericChar(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
        }
    }
}
