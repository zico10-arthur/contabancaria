using exercíciosdogemini.application;
using exercíciosdogemini.Domain.Entites;

namespace exercíciosdogemini.presentation;

public class BancariaEntrar
{
    public static void Entrada()
    {
        ContaBancaria conta = new ContaBancaria();

        while (true)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("entrando na conta...");

            Console.WriteLine("digite o seu nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("digite o seu cpf: ");
            string cpf = Console.ReadLine();

            var consumidor = ClienteService.Listar().FirstOrDefault(c => c.Cpf == cpf);

            if (consumidor != null)
            {
                Menu.Mostrar();
            }
            else
            {
                Console.WriteLine("essa conta não existe.");
                break;
            }


            

            

        }
    }
}
