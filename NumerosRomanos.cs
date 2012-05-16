using NUnit.Framework;

namespace NumerosRomanosTeste
{
    [TestFixture]
    public class NumerosRomanos
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(31, "XXXI")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(60, "L")]
        //[TestCase(60, "LX")]
        public void Deve_Retornar_I_Para_1(int num, string romano)
        {
            ConversorRomano conv = new ConversorRomano();
            Assert.AreEqual(romano, conv.ConverterDecimal(num));
        }
    }
}
