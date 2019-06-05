using DateScanner;
using DateScanner.Exceptions;
using NUnit.Framework;

namespace DataScannerTests
{
    public class InputValidatorTest
    {
        [Test]
        public void CheckArgAmount_ProperAmountOfData_ReturnTrue()
        {
            bool result = InputValidator.CheckAmountOfArguments(2);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckArgAmount_InvalidAmountOfData_ReturnFalse()
        {
            bool result = InputValidator.CheckAmountOfArguments(3);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void CheckDateFormat_ProperFormatOfDate_ReturnTrue()
        {
            bool result = InputValidator.CheckFormatOfDate("12.12.1998");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckDateFormat_InvalidFormatOfDate_ReturnFalse()
        {
            bool result = InputValidator.CheckFormatOfDate("12.1998");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void CheckYear_ProperYearPassed_ReturnTrue()
        {
            bool result = InputValidator.CheckYear("2000");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckYear_InvalidTypeOfYear_ThrowsException()
        {
            Assert.Throws<BadTypeOfDateElementsException>(
                () => InputValidator.CheckYear("123,5"));
        }

        [Test]
        public void CheckYear_YearOutOfRange_ThrowsException()
        {
            Assert.Throws<DataOutOfRangeException>(
                () => InputValidator.CheckYear("3001"));
        }

        [Test]
        public void CheckMonth_ProperMonthPassed_ReturnTrue()
        {
            bool result = InputValidator.CheckYear("11");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckMonth_InvalidTypeOfMonth_ThrowsException()
        {
            Assert.Throws<BadTypeOfDateElementsException>(
              () => InputValidator.CheckMonth("11,4"));
        }

        [Test]
        public void CheckMonth_MonthOutOfRange_ThrowsException()
        {
            Assert.Throws<DataOutOfRangeException>(
                () => InputValidator.CheckMonth("13"));
        }

        [Test]
        public void CheckDay_ProperDayPassed_ReturnTrue()
        {
            bool result = InputValidator.CheckDay("11","11","2000");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckDay_InvalidTypeOfDay_ThrowsException()
        {
            Assert.Throws<BadTypeOfDateElementsException>(
              () => InputValidator.CheckDay("1,4","2","2000"));
        }

        [Test]
        public void CheckDay_DayOutOfRange_ThrowsException()
        {
            Assert.Throws<DataOutOfRangeException>(
              () => InputValidator.CheckDay("40", "2", "2000"));
        }
    }
}
