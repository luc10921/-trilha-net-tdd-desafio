using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        private void inserirHist(int res)
        {
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
        }

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            inserirHist(res);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            inserirHist(res);
            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            inserirHist(res);
            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            inserirHist(res);
            return res;
        }

        public List<string> historico()
        {
            if (listaHistorico.Count < 3){
                return listaHistorico;
            }
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}