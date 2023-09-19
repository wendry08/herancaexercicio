using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_exercicio.Classe
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string agencia, string titular)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = 0.0;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
        }
    }
}