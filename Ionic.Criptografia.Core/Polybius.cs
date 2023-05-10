using System.Collections.Specialized;

namespace Ionic.Criptografia.Core
{
    public class Polybius
    {
        private readonly OrderedDictionary _matriz;
        public Polybius()
        {
            _matriz = new OrderedDictionary();
            _matriz.Add("A", 11);
            _matriz.Add("B", 12);
            _matriz.Add("C", 13);
            _matriz.Add("D", 14);
            _matriz.Add("E", 15);
            _matriz.Add("F", 21);
            _matriz.Add("G", 22);
            _matriz.Add("H", 23);
            _matriz.Add("I", 24);
            _matriz.Add("J", 24);
            _matriz.Add("K", 25);
            _matriz.Add("L", 31);
            _matriz.Add("M", 32);
            _matriz.Add("N", 33);
            _matriz.Add("O", 34);
            _matriz.Add("P", 35);
            _matriz.Add("Q", 41);
            _matriz.Add("R", 42);
            _matriz.Add("S", 43);
            _matriz.Add("T", 44);
            _matriz.Add("U", 45);
            _matriz.Add("V", 51);
            _matriz.Add("X", 52);
            _matriz.Add("W", 53);
            _matriz.Add("Y", 54);
            _matriz.Add("Z", 55);
        }

        public int ObterNumeroDaLetra(char letra)
        {
            return Convert.ToInt32(_matriz[letra.ToString().ToUpper()]);
        }

        public string ObterLetraDoNumero(int numero)
        {
            foreach (var item in _matriz)
            {
                var itemd = item;
            }

            return string.Empty;
        }

        public IEnumerable<int> GerarCriptografia(string texto)
        {
            foreach (char letra in texto)
            {
                yield return ObterNumeroDaLetra(letra);
            }
        }
    }
}
