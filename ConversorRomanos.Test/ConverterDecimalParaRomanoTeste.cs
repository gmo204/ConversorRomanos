using ConversorRomanos.Dominio;

namespace ConversorRomanos.Test
{
    [TestClass]
    public class ConverterRomanoParaDecimalTeste
    {
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("V", 5)]
        [DataRow("X", 10)]
        [DataRow("L", 50)]
        [DataRow("C", 100)]
        [DataRow("D", 500)]
        [DataRow("M", 1000)]
        public void Teste_unitario(string romano, int numero)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterRomanoParaNumero(romano);

            Assert.AreEqual(numero, resultado);
        }

        [TestMethod]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XXX", 30)]
        public void Teste_de_soma(string romano, int numero)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterRomanoParaNumero(romano);

            Assert.AreEqual(numero, resultado);
        }

        [TestMethod]
        [DataRow("IV", 4)]
        [DataRow("IX", 9)]
        [DataRow("XIV", 14)]
        [DataRow("XIX", 19)]
        [DataRow("XL", 40)]
        [DataRow("XC", 90)]
        [DataRow("CD", 400)]
        [DataRow("CM", 900)]
        public void Teste_de_subtracao(string romano, int numero)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterRomanoParaNumero(romano);

            Assert.AreEqual(numero, resultado);
        }

        [TestMethod]
        [DataRow("I", 1)]           // Valor mínimo possível
        [DataRow("IV", 4)]          // Exemplo com subtração
        [DataRow("IX", 9)]          // Exemplo com subtração
        [DataRow("XL", 40)]         // Subtração envolvendo dezenas
        [DataRow("XC", 90)]         // Subtração envolvendo centenas
        [DataRow("CM", 900)]        // Subtração envolvendo milhares
        [DataRow("MMMCMXCIX", 3999)] // Valor máximo (3999)
        [DataRow("MMXXIV", 2024)]   // Ano atual
        [DataRow("DLV", 555)]       // Teste intermediário
        [DataRow("CCCLXIX", 369)]   // Valor misto de centenas e unidades
        public void Teste_extra(string romano, int numero)
        {
            var conversor = new Conversor();

            var resultado = conversor.ConverterRomanoParaNumero(romano);

            Assert.AreEqual(numero, resultado);
        }

    }
}
