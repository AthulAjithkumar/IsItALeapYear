using IsItALeapYear;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Year_2001_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYear(2004);
            var actual1 = p.Year_1996_Is_a_leap_year(1996);
            var actual2 = p.Year_1900_is_not_a_leap_year(1990);
            var actual3 = p.Year_2000_is_a_leap_year(2000);


            // Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
