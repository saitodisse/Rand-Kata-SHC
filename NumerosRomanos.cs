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
        public void Unidades(int num, string romano)
        {
            var conv = new ConversorRomano();
            Assert.AreEqual(romano, conv.ConverterDecimal(num));
        }
        
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(70, "LXX")]
        [TestCase(80, "LXXX")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        public void Dezenas(int num, string romano)
        {
            var conv = new ConversorRomano();
            Assert.AreEqual(romano, conv.ConverterDecimal(num));
        }
    }
}
