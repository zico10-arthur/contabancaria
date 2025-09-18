using System.Security.Cryptography.X509Certificates;
using System.Text;
using exercíciosdogemini.application;
using exercíciosdogemini.Domain.Entites;

namespace exercíciosdogemini.presentation;

public static class CadastrarCliente
{
    public static void Cadastrar()
    {

     

        while (true)
        {
            Console.WriteLine("cadastro de cliente");

            Cliente cliente = new Cliente();

            Console.WriteLine(" digite o nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("digite o CPF: ");
            cliente.Cpf = Console.ReadLine();

            ClienteService.Cadastrar(cliente);

            Console.WriteLine("deseja cadastrar outro cliente: [S/N] ");
            string resposta = Console.ReadLine();

            if (resposta.Trim().ToLower() != "s")
            {
                break;
            }


        }

    }
    public static void Listar()
    {
        Console.WriteLine("Listagem de clientes");

        List<Cliente> Cliente = ClienteService.Listar();
    
        foreach (Cliente cliente in Cliente)
        {
            Console.WriteLine($"{cliente.Nome} - {cliente.Cpf} - {cliente.Saldo}");
        }
    }
    public static void Excluir()
    {
        Console.WriteLine("exclusão de cadastro do cliente");

        Console.WriteLine("digite o cpf do cliente: ");
        string cpf = Console.ReadLine();

        var cliente = ClienteService.Listar().FirstOrDefault(c => c.Cpf == cpf);

        if (cliente != null)
        {
            ClienteService.Excluir(cliente);
            Console.WriteLine("cliente excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("cliente não encontrado");
        }
    
    }
    
    


}   
