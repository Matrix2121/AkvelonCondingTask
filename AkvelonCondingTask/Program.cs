using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonCodingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnModel rm = FizzBuzzDetector.GetOverlappings("aa bb cc dd ee ff gg hh ii jj kk ll mm nn oo pp");

            rm.Print();
        }
    }
}
