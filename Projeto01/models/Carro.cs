using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto01.models
{
    public class Carro
    {
        public string Placa { get; set; } = string.Empty;

        public Carro CadastrarCarro()
        {
            Console.WriteLine("Digite a placa do carro: ");
            Placa = Console.ReadLine() ?? string.Empty;
            return this;
        }
        public string RemoverCarro()
        {            
            Console.WriteLine("Digite a placa do carro: ");
            return Console.ReadLine() ?? string.Empty;

        }

    }
}