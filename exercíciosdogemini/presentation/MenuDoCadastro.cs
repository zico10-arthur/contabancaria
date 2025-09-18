namespace exercíciosdogemini.presentation;

public class MenuDoCadastro
{
    public static void Mostrar()
    {
        while (true)
        {
            Console.WriteLine("[1] cadastro de cliente");
            Console.WriteLine("[2] remover conta de cliente");
            Console.WriteLine("[3] lista de clientes");
            Console.WriteLine("[4] acessar a sua conta");
            Console.WriteLine("[5] para sair");


            string entrada = Console.ReadLine();
            int resposta = Convert.ToInt32(entrada);

            if (resposta == 1)
            {
                CadastrarCliente.Cadastrar();
            }
            else if (resposta == 2)
            {
                CadastrarCliente.Excluir();
            }
            else if (resposta == 3)
            {
                CadastrarCliente.Listar();
            }
            else if (resposta == 4)
            {
                BancariaEntrar.Entrada();
            }
            else if (resposta == 5)
            {
                Environment.Exit(0);
            }
        }
    }
}
