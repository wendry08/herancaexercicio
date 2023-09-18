public class Banco
{
    public int NumeroConta { get; set; }
    public string Agencia { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public Banco()
    {

    }

    public Banco(int numeroConta, string agencia, string titular, double saldo)
    {
        NumeroConta = numeroConta;
        Agencia = agencia;
        Titular = titular;
        Saldo = 0;
    }

    public virtual void Deposito(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado na conta {NumeroConta}");
    }
    public virtual bool Saque(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado na conta {NumeroConta}");
            return true;
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente na conta {NumeroConta}");
            return false;
        }
    }
} 
    
