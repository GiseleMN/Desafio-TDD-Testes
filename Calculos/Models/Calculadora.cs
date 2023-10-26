using System;
namespace Calculos.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int x, int y)
        {
            int res = x + y;
            listaHistorico.Insert(0, "Resultado: " + res + " - Data: " + data);
            return res;
        }

        public int Subtrair(int x, int y)
        {
            int res = x - y;
            listaHistorico.Insert(0, "Resultado: " + res + " - Data: " + data);
            return res;
        }

        public int Dividir(int x, int y)
        {
            int res = x / y;
            listaHistorico.Insert(0, "Resultado: " + res + " - Data: " + data);
            return res;
        }

        public int Multiplicar(int x, int y)
        {
            int res = x * y;
            listaHistorico.Insert(0, "Resultado: " + res + " - Data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}


