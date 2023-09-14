using CashCrusadersAssessmentConsole;

namespace CashCrusadersAssessmentConsoleTest
{
    [TestClass]
    public class CashCrusadersAssessmentTest
    {
        [TestMethod]
        public void CountCharacterOccuranceTest()
        {
            var count = StringHelper.CountCharacterOccurance('a', "ababababa");
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            var reversed = StringHelper.ReverseString("Oprah");
            Assert.AreEqual(reversed, "harpO");
        }
    }
}