using System.Diagnostics;
using System.Resources;
using System.Runtime.InteropServices.JavaScript;

namespace ConversorRomanos.Dominio
{
    public class Conversor
    {
        private Dictionary<int, string> numeros;
        private Dictionary<char, int> romanos;

        public Conversor()
        {
            numeros = new Dictionary<int, string>();

            numeros.Add(1, "I");
            numeros.Add(2, "II");
            numeros.Add(3, "III");
            numeros.Add(4, "IV");
            numeros.Add(5, "V");
            numeros.Add(6, "VI");
            numeros.Add(7, "VII");
            numeros.Add(8, "VIII");
            numeros.Add(9, "IX");

            romanos = new Dictionary<char, int>();

            romanos.Add('I', 1);
            romanos.Add('V', 5);
            romanos.Add('X', 10);
            romanos.Add('L', 50);
            romanos.Add('C', 100);
            romanos.Add('D', 500);
            romanos.Add('M', 1000);
        }

        public string ConverterNumeroParaRomano(int numero)
        {
            if (numero == 0)
                return "";

            else if (numero >= 1000)
            {
                int n = numero - 1000;
                return "M" + ConverterNumeroParaRomano(n);
            }
            
            else if (numero >= 900)
            {
                int n = numero - 900;
                return "CM" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 500)
            {
                int n = numero - 500;
                return "D" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 400)
            {
                int n = numero - 400;
                return "CD" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 100)
            {
                int n = numero - 100;
                return "C" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 90)
            {
                int n = numero - 90;
                return "XC" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 50)
            {
                int n = numero - 50;
                return "L" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 40)
            {
                int n = numero - 40;
                return "XL" + ConverterNumeroParaRomano(n);
            }

            else if (numero >= 10)
            {
                int n = numero - 10;
                return "X" + ConverterNumeroParaRomano(n);
            }

            return numeros[numero];
        }

        public int ConverterRomanoParaNumero(string romano)
        {
            int[] sequencia = new int[romano.Length];

            if (romano.Length == 1)
                return romanos[romano[0]];

            for (int i = 0; i < sequencia.Length; i++)
            {
                sequencia[i] = romanos[romano[i]];
            }

            int valor = sequencia.Last();

            for (int i = 1; i < sequencia.Length; i++)
            {
                int penultimo = sequencia.Length - i - 1;

                if (sequencia[penultimo] < sequencia[penultimo + 1])
                    valor -= sequencia[penultimo];

                else 
                    valor += sequencia[penultimo];
            }
            return valor;
        }
    }
}
