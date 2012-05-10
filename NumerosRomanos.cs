using NUnit.Framework;

namespace NumerosRomanosTeste
{
    [TestFixture]
    public class NumerosRomanos
    {
        [Test]
        public void Deve_Retornar_I_Para_1()
        {
            Assert.AreEqual(Romanos.Converter(1), "I");
        }

        [Test]
        public void Deve_Retornar_II_Para_2()
        {
            Assert.AreEqual(Romanos.Converter(2), "II");
        }

        [Test]
        public void Deve_Retornar_III_Para_3()
        {
            Assert.AreEqual(Romanos.Converter(3), "III");
        }

        [Test]
        public void Deve_Retornar_IV_Para_4()
        {
            Assert.AreEqual(Romanos.Converter(4), "IV");
        }
        [Test]
        public void Deve_Retornar_IV_Para_5()
        {
            Assert.AreEqual(Romanos.Converter(5), "V");
        }
        [Test]
        public void Deve_Retornar_IV_Para_6()
        {
            Assert.AreEqual(Romanos.Converter(6), "VI");
        }
        [Test]
        public void Deve_Retornar_IV_Para_7()
        {
            Assert.AreEqual(Romanos.Converter(7), "VII");
        }
        [Test]
        public void Deve_Retornar_IV_Para_8()
        {
            Assert.AreEqual(Romanos.Converter(8), "VIII");
        }
        [Test]
        public void Deve_Retornar_IV_Para_9()
        {
            Assert.AreEqual(Romanos.Converter(9), "IX");
        }
        [Test]
        public void Deve_Retornar_IV_Para_10()
        {
            Assert.AreEqual(Romanos.Converter(10), "X");
        }

        [Test]
        public void Deve_Retornar_XI_Para_11()
        {
            Assert.AreEqual(Romanos.Converter(11), "XI");
        }

        [Test]
        public void Deve_Retornar_XV_Para_15()
        {
            Assert.AreEqual(Romanos.Converter(15), "XV");
        }

        [Test]
        public void Deve_Retornar_XIX_Para_19()
        {
            Assert.AreEqual(Romanos.Converter(19), "XIX");
        }

        [Test]
        public void Deve_Retornar_XX_Para_20()
        {
            Assert.AreEqual(Romanos.Converter(20), "XX");
        }

        [Test]
        public void Deve_Retornar_XXI_Para_21()
        {
            Assert.AreEqual(Romanos.Converter(21), "XXI");
        }


        [Test]
        public void Deve_Retornar_XXV_Para_25()
        {
            Assert.AreEqual(Romanos.Converter(25), "XXV");
        }

        [Test]
        public void Deve_Retornar_XXV_Para_33()
        {
            Assert.AreEqual(Romanos.Converter(33), "XXXIII");
        }
    }
}
