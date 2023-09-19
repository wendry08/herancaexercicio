using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_exercicio.Classe
{
    public class ContaEstudante : ContaBancaria
    {
        public double LimiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string InstituicaoEnsino { get; set; }

        public ContaEstudante(int numeroConta, string agencia, string titular, double limiteChequeEspecial, string cpf, string instituicaoEnsino)
            : base(numeroConta, agencia, titular)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            CPF = cpf;
            InstituicaoEnsino = instituicaoEnsino;
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else if (valor <= Saldo + LimiteChequeEspecial)
            {
                double valorSaqueChequeEspecial = valor - Saldo;
                Saldo = 0;
                Console.WriteLine($"Saque de R${valor} (R${valorSaqueChequeEspecial} do limite de cheque especial) realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente e limite de cheque especial ultrapassado para o saque.");
            }
        }
    }
}
