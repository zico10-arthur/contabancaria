using exercíciosdogemini.Domain.Entites;


namespace exercíciosdogemini.presentation
{
    public class Menu
    {
        public static void Mostrar()
        {
            ContaBancaria conta = new ContaBancaria();

            while (true)
            {



                Console.WriteLine("o que você deseja fazer?");
                Console.WriteLine("[1] depositar");
                Console.WriteLine("[2] sacar");
                Console.WriteLine("[3] verificar saldo");
                Console.WriteLine("[4] sair");


                string entrada = Console.ReadLine();
                int resposta = Convert.ToInt32(entrada);

                if (resposta == 1)
                {
                    Console.WriteLine("digite o valor para depósito:");
                    string dep = Console.ReadLine();
                    decimal depreal = Convert.ToDecimal(dep);
                    conta.Depositar(depreal);
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("digite o valor do saque:");
                    string sac = Console.ReadLine();
                    decimal sacreal = Convert.ToDecimal(sac);
                    conta.Sacar(sacreal);
                }
                else if (resposta == 3)
                {
                    conta.VerificarSaldo();
                }
                else if (resposta == 4)
                {
                    break;
                }
            }
        }
    }

}


