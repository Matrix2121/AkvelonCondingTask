using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonCodingTask
{
    public class ReturnModel
    {
        public string Result { get; set; }
        public int WordCount { get; set; }

        public ReturnModel(string result, int wordCount)
        {
            Result = result;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine("\"" + Result + "\"");
            Console.WriteLine("count: " + WordCount);
        }
    }
}
