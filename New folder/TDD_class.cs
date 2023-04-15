//class1.cs
namespace Domain
{
    public class RomanToDecimal
    {
        public string ConvertRomanToDecimal(int number)
        {
            
            int[] values = new int[]        { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = "";
            for(int i=0;i<values.Length;i++)
            {
                while (number >= values[i])
                {
                    result += symbols[i];
                    number -= values[i];
                }
            }
            return result;


        }
        

       
    }
}


//UnitTest1.cs
using Domain;
using FluentAssertions;
using Xunit;
namespace TDDProjectWithXunit
{
    public class RomanToDecimalTests
    {
        RomanToDecimal calc = new RomanToDecimal();
        [Fact]
        public void Roman_Of_1_Should_Be_I()
        {
            
            calc.ConvertRomanToDecimal(1).Should().Be("I");


        }
        [Fact]
        public void Roman_Of_2_Should_Be_II()
        {

            calc.ConvertRomanToDecimal(2).Should().Be("II");


        }
        [Fact]
        public void Roman_Of_3_Should_Be_III()
        {

            calc.ConvertRomanToDecimal(3).Should().Be("III");


        }
        [Fact]
        public void Roman_Of_4_Should_Be_IV()
        {

            calc.ConvertRomanToDecimal(4).Should().Be("IV");


        }
        [Fact]
        public void Roman_Of_5_Should_Be_V()
        {

            calc.ConvertRomanToDecimal(5).Should().Be("V");


        }
        [Fact]
        public void Roman_Of_9_Should_Be_IX()
        {

            calc.ConvertRomanToDecimal(9).Should().Be("IX");


        }
        [Fact]
        public void Roman_Of_21_Should_Be_XXI()
        {

            calc.ConvertRomanToDecimal(21).Should().Be("XXI");


        }

        [Fact]
        public void Roman_Of_50_Should_Be_L()
        {

            calc.ConvertRomanToDecimal(50).Should().Be("L");


        }
        [Fact]
        public void Roman_Of_100_Should_Be_C()
        {

            calc.ConvertRomanToDecimal(100).Should().Be("C");


        }

        [Fact]
        public void Roman_Of_500_Should_Be_D()
        {

            calc.ConvertRomanToDecimal(500).Should().Be("D");


        }

        [Fact]
        public void Roman_Of_1000_Should_Be_M()
        {

            calc.ConvertRomanToDecimal(1000).Should().Be("M");


        }
        [Fact]
        public void Roman_Of_400_Should_Be_CD()
        {

            calc.ConvertRomanToDecimal(400).Should().Be("CD");


        }
        [Fact]
        public void Roman_Of_900_Should_Be_CM()
        {

            calc.ConvertRomanToDecimal(900).Should().Be("CM");


        }
        [Fact]
        public void Roman_Of_90_Should_Be_XC()
        {

            calc.ConvertRomanToDecimal(90).Should().Be("XC");


        }
        [Fact]
        public void Roman_Of_1100_Should_Be_MC()
        {

            calc.ConvertRomanToDecimal(1100).Should().Be("MC");


        }
        [Fact]
        public void Roman_Of_140_Should_Be_CXL()
        {

            calc.ConvertRomanToDecimal(140).Should().Be("CXL");


        }
        [Fact]
        public void Roman_Of_1900_Should_Be_MCM()
        {

            calc.ConvertRomanToDecimal(1900).Should().Be("MCM");


        }
        [Fact]
        public void Roman_Of_1650_Should_Be_MDCL()
        {

            calc.ConvertRomanToDecimal(1650).Should().Be("MDCL");


        }
        [Fact]
        public void Roman_Of_12_Should_Be_XII()
        {

            calc.ConvertRomanToDecimal(12).Should().Be("XII");


        }
        [Fact]
        public void Roman_Of_600_Should_Be_DC()
        {

            calc.ConvertRomanToDecimal(600).Should().Be("DC");


        }



    }
}