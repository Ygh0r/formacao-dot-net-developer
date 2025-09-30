using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formacao_dot_net_developer.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
        
    }
}