using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LabXUnit
{
    public class TestLeapYear
    {

        [Fact]
        public void Is_Divisible_By_Four_Test()
        {
            var year = 1996;
            var LeapYear = new LeapYearValidator();
            bool result = LeapYear.ValidateYear(year);

            Assert.True(result);
        }
        [Fact]
        public void Is_Not_Divisible_By_Four_Test()
        {
            var year = 2003;
            var LeapYear = new LeapYearValidator();
            bool result = LeapYear.ValidateYear(year);

            Assert.False(result);
        }

        [Fact]
        public void Should_Be_Divisable_By_4And_100_And_400_Test()
        {
            var year = 2000;

            var LeapYear = new LeapYearValidator();
            bool result = LeapYear.ValidateYear(year);


            Assert.True(result);
        }

        [Fact]
        public void Should_Be_Divisable_By_4_And_100_But_Not_400_Test()
        {
            var year = 1900;

            var LeapYear = new LeapYearValidator();
            bool result = LeapYear.ValidateYear(year);

            Assert.False(result);
        }



    }
}
