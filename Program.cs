using System;

namespace _IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de objeto:
            Pessoa p = new Pessoa();
            p.peso = 80;
            p.altura = 1.80;
            p.mensagem();
        }
    }
}
