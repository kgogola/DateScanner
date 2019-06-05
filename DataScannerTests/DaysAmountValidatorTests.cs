using DateScanner;
using NUnit.Framework;

namespace DataScannerTests
{
    class DaysAmountValidatorTests
    {
        [TestCase("2000",2,29)]
        [TestCase("2001", 2, 28)]
        [TestCase("2000", 1, 31)]
        [TestCase("2000", 4, 30)]
        public void ChooseProperDaysAmount_ProperValue_Equal
            (string year, int month, int days)
        {
            DaysAmountValidator daysAmountValidator = new DaysAmountValidator(year);
            daysAmountValidator.EstimateNumberOfDays(month);
            int result = daysAmountValidator.MaxNumberOfDays;
            Assert.AreEqual(days, result);
        }
    }
}
