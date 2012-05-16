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

        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(300, "CCC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(700, "DCC")]
        [TestCase(800, "DCCC")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        public void Centenas(int num, string romano)
        {
            var conv = new ConversorRomano();
            Assert.AreEqual(romano, conv.ConverterDecimal(num));
        }

        [TestCase(11, "X I")]
        [TestCase(33, "XXX III")]
        [TestCase(87, "LXXX VII")]
        [TestCase(96, "XC VI")]
        [TestCase(1388, "M CCC LXXX VIII")]
        [TestCase(8888, "V'MMM DCCC LXXX VIII")]
        [TestCase(1000000, "M'")]
        public void Juncoes(int num, string romano)
        {
            var conv = new ConversorRomano();
            Assert.AreEqual(romano, conv.ConverterDecimal(num));
        }

    }
}
