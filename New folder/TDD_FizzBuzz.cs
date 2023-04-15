//class.cs
namespace Domain
{
    public class FizzBuzz
    {
        public string FizzBuzzChecker(int n)
        {


            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return n.ToString();
            }


        }
        

       
    }
}


//unitTest.cs
using Domain;
using FluentAssertions;
using Xunit;
namespace TDDProjectWithXunit
{
    public class FizzBuzzTests
    {
        FizzBuzz calc = new FizzBuzz();
        [Fact]
        public void FizzBuzz_Of_3_Should_Be_Fizz()
        {
            
            calc.FizzBuzzChecker(3).Should().Be("Fizz");


        }
        [Fact]
        public void FizzBuzz_Of_5_Should_Be_Fizz()
        {

            calc.FizzBuzzChecker(5).Should().Be("Buzz");


        }
        [Fact]
        public void FizzBuzz_Of_10_Should_Be_Buzz()
        {

            calc.FizzBuzzChecker(10).Should().Be("Buzz");


        }





    }
}