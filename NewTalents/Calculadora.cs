using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _historico;
        private string _data;


        public Calculadora(string data)
        {
            _historico = new List<string>();
            _data = data;
        }
        public int Somar(int x, int y)

        {
            int res = x + y;
            _historico.Insert(0, "Res" + res + " data: " + _data);
            
            return res;
        }

        public int Multiplicar(int x, int y)
        {
            int res = x * y;
            _historico.Insert(0, "Res" + res + " data: " + _data);

            return res;
        }

        public int Subtracao(int x, int y)
        {
            int res = x - y;
            _historico.Insert(0, "Res" + res + " data: " + _data);

            return res;
        }

        public double Dividir(int x, int y)
        {
            int res = x / y;
            _historico.Insert(0, "Res" + res + " data: " + _data);

            return res;
        }

        public List<string> ListaHistorico()
        {

            _historico.RemoveRange(3, _historico.Count - 3);

            return _historico;
        }


    }
}
