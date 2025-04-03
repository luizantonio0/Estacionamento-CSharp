using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Projeto01.models
{
    public class Estacionamento
    {
        private decimal _valorInicio;
        private decimal _valorHora;
        
        public List<Carro> Carros { get; set; }
        public decimal ValorInicio { 
            get => _valorInicio;
            
            set {
                if (value < 0)
                {
                    throw new ArgumentException("O valor não pode ser negativo");
                }
                _valorInicio = value;
            
                }
            }
        public decimal ValorHora { 
            get => /*<- Body expressions, tipo uma return*/_valorHora;
            set{
                if (value < 0){
                    throw new ArgumentException("O valor não pode ser negativo");
                }
                _valorHora = value;
            } 
        }
        // public int Vagas { get; set; }

//-----------------------------------------------------------------------------------------------------------------------------------------

        public decimal ValorCobrado()
        {
            Console.Write("Quantas horas o carro ficou? ");
            int horas = int.Parse(Console.ReadLine() ?? "0");
            return ValorInicio + (horas * ValorHora);
        }

        public void AdicionarCarro(Carro carro)
        {
            Carros.Add(carro);
        }

        public void ListaCarrosCadastrados()
        {
            if (Carros.Count == 0){
                Console.WriteLine("Não há Carros cadastrados.");
            } else {
                Console.WriteLine("Carros cadastrados: ");
                foreach (var carro in Carros)
                {
                    Console.WriteLine($"Carro: {carro.Placa}");
                }
            }
        }

        public bool RemoverCarro(){
            string placa;
            Console.Write("Insira a placa do carro que deseja remover: ");
            placa = Console.ReadLine();
            int i=0;
            foreach(var loop in Carros){
                //Compara o valor de cada indice do vetor com a placa inserida e retorna o primeiro valor que encontrar
                if (Carros[i].Placa.Equals(placa)){
                    Carros.RemoveAt(i);
                    //Chama a função que retorna um valor decimal e depois converte para o modelo (R$ X,00)
                    Console.WriteLine($"O preço a ser pago é: R$ {ValorCobrado().ToString("C")}");
                    return true;
                }
            }
            return false;
        }
//------------------------------------------------------------------------------------------------------------    
    }
}
