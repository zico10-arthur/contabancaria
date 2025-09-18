namespace exercíciosdogemini.Domain.Entites;

public  class ContaBancaria
{
    Cliente cliente = new Cliente();

    public decimal Depositar(decimal valor)
    {
        cliente.Saldo += valor;
        return cliente.Saldo;
        
    }

    public  bool Sacar(decimal valor)
    {
        if (cliente.Saldo < valor)
        {
            Console.WriteLine("saldo insuficiente ");
            return false;

        }
        else
        {
            cliente.Saldo -= valor;
            return true;
        }
    }
    public  void VerificarSaldo()
    {
        Console.WriteLine($"{cliente.Nome} esse é o seu saldo atual: R$ {cliente.Saldo:F2}");


    }


}
