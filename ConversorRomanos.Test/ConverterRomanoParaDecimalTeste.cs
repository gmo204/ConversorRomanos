using ConversorRomanos.Dominio;

namespace ConversorRomanos.Test
{
    [TestClass]
    public class ConverterDecimalParaRomanoTeste
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        public void Teste_de_1_9(int numero, string romano)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterNumeroParaRomano(numero);

            Assert.AreEqual(romano, resultado);
        }

        [TestMethod]
        [DataRow(10, "X")]
        [DataRow(11, "XI")]
        [DataRow(12, "XII")]
        [DataRow(13, "XIII")]
        [DataRow(14, "XIV")]
        [DataRow(15, "XV")]
        [DataRow(16, "XVI")]
        [DataRow(17, "XVII")]
        [DataRow(18, "XVIII")]
        [DataRow(19, "XIX")]
        public void Teste_de_10_19(int numero, string romano)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterNumeroParaRomano(numero);

            Assert.AreEqual(romano, resultado);
        }

        [TestMethod]
        [DataRow(20, "XX")]
        [DataRow(30, "XXX")]
        [DataRow(40, "XL")]
        [DataRow(50, "L")]
        [DataRow(60, "LX")]
        [DataRow(70, "LXX")]
        [DataRow(80, "LXXX")]
        [DataRow(90, "XC")]
        public void Teste_de_dezenas(int numero, string romano)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterNumeroParaRomano(numero);

            Assert.AreEqual(romano, resultado);
        }

        [TestMethod]
        [DataRow(100, "C")]
        [DataRow(200, "CC")]
        [DataRow(300, "CCC")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(600, "DC")]
        [DataRow(700, "DCC")]
        [DataRow(800, "DCCC")]
        [DataRow(900, "CM")]
        public void Teste_de_centena(int numero, string romano)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterNumeroParaRomano(numero);

            Assert.AreEqual(romano, resultado);
        }

        [TestMethod]
        [DataRow(1000, "M")]
        [DataRow(2000, "MM")]
        [DataRow(3000, "MMM")]
        public void Teste_de_milhar(int numero, string romano)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterNumeroParaRomano(numero);

            Assert.AreEqual(romano, resultado);
        }
    }
}