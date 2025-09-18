namespace exercíciosdogemini.application;

using exercíciosdogemini.Domain.Entites;
public static class ClienteService
{
    public static void Cadastrar(Cliente cliente)
    {
        bool existe = Database.Cliente.Any(c => c.Cpf == cliente.Cpf);

        if (existe)
        {
            Console.WriteLine("já temos um cliente cadastrado com esse cpf");
            return;
        }
        Database.Cliente.Add(cliente);
        Console.WriteLine("cliente cadastrado com sucesso");

    }
    public static List<Cliente> Listar()
    {
        if (Database.Cliente.Count == 0)
        {
            Console.WriteLine("a lista de cliente está vazia!");
            return  Database.Cliente;
        }
        else
        {
            return Database.Cliente;

        }
       
    }

    public static void Excluir(Cliente cliente)
    {
        Database.Cliente.Remove(cliente);
    }

}
