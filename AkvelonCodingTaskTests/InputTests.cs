using AkvelonCodingTask;

namespace AkvelonCodingTaskTests
{
    [TestClass]
    public sealed class InputTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "aa bb cc dd ee ff gg hh ii jj kk ll mm nn oo pp";

            ReturnModel result = FizzBuzzDetector.GetOverlappings(input);

            string expected = "aa bb Fizz dd Buzz Fizz gg hh Fizz Buzz kk Fizz mm nn FizzBuzz pp";
            Assert.AreEqual(expected, result.Result);
            Assert.AreEqual(16, result.WordCount);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "   aa bb cc dd ee ff gg hh ii jj kk ll mm nn oo pp    ";

            ReturnModel result = FizzBuzzDetector.GetOverlappings(input);

            string expected = "   aa bb Fizz dd Buzz Fizz gg hh Fizz Buzz kk Fizz mm nn FizzBuzz pp    ";
            Assert.AreEqual(expected, result.Result);
            Assert.AreEqual(16, result.WordCount);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "aa bb cc dd ee\n ff gg hh ii jj          kk ll mm nn oo pp";

            ReturnModel result = FizzBuzzDetector.GetOverlappings(input);

            string expected = "aa bb Fizz dd Buzz\n Fizz gg hh Fizz Buzz          kk Fizz mm nn FizzBuzz pp";
            Assert.AreEqual(expected, result.Result);
            Assert.AreEqual(16, result.WordCount);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "aa@ bb cc @ dd ee ff gg hh ii jj kk //// ll mm nn oo pp/// ";

            ReturnModel result = FizzBuzzDetector.GetOverlappings(input);

            string expected = "aa@ bb Fizz @ dd Buzz Fizz gg hh Fizz Buzz kk //// Fizz mm nn FizzBuzz pp/// ";
            Assert.AreEqual(expected, result.Result);
            Assert.AreEqual(16, result.WordCount);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "@ aa bb cc dd ee 5 ff gg hh ii jj kk ll 98mm nn oo pp";

            ReturnModel result = FizzBuzzDetector.GetOverlappings(input);

            string expected = "@ aa bb Fizz dd Buzz Fizz ff gg Fizz Buzz jj Fizz ll 98mm FizzBuzz oo pp";
            Assert.AreEqual(expected, result.Result);
            Assert.AreEqual(17, result.WordCount);
        }
    }
}
