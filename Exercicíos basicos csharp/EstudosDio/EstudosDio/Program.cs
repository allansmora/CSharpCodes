using System;
using EstudosDio.Models;

namespace EstudosDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Idade = 12;
            pessoa1.Nome = "Jorge";

            pessoa1.Apresentar();
        }
    }
}
