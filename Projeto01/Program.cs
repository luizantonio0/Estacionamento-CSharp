using System.Runtime.CompilerServices;
using Projeto01.models;

Estacionamento estacionamento1 = new Estacionamento();
estacionamento1.Carros = new List<Carro>();

bool menu = true;

Console.Write("Digite o valor de inicio: ");
estacionamento1.ValorInicio = decimal.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor por hora: ");
estacionamento1.ValorHora = decimal.Parse(Console.ReadLine() ?? "0");

while (menu)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar carro");
    Console.WriteLine("2 - Remover carro");
    Console.WriteLine("3 - Listar carros cadastrados");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Digite a opção desejada: ");
    string opcao = Console.ReadLine() ?? string.Empty;
    

    switch (opcao)
    {
        
        case "1":
                Carro novoCarro = new Carro();
                Console.WriteLine("Digite a placa do carro: ");
                novoCarro.Placa = Console.ReadLine() ?? string.Empty;
                if(novoCarro.Placa != ""){
                    estacionamento1.AdicionarCarro(novoCarro);               
                    Console.WriteLine("Cadastro feito com sucesso");
                    
                } else Console.WriteLine("Nome inválido");

                Console.Write("Pressione qualquer tecla para continuar... ");             
                Console.ReadKey();
            break;
        case "2":
            if (estacionamento1.RemoverCarro())
            {
                Console.WriteLine("Carro removido com sucesso!");
            } else{
                Console.WriteLine("Carro não encontrado.");
            }
            Console.Write("Pressione qualquer tecla para continuar... ");
            Console.ReadKey();
            break;
        case "3":
            estacionamento1.ListaCarrosCadastrados();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
                break;
        case "4":
            Console.WriteLine("Fim do programa!");
            Console.ReadKey();
            // Sair do loop
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida!\n");
            Console.Write("Pressione qualquer tecla para continuar... ");      
            Console.ReadKey();
            break;
    
    }
}
