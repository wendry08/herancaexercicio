using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca___POO.Classes
{
    internal class Conta_Estudante:Banco
    {
        public double LimiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string InstituicaoEnsino { get; set; }

        public Conta_Estudante(int numeroConta, int agencia, string titular, double limitechequeespecial, string cpf, string instituicaoEnsino)
            :base(numeroConta, agencia, titular)
        {
            this.LimiteChequeEspecial = limitechequeespecial;
            this.CPF = cpf;
            this.InstituicaoEnsino = instituicaoEnsino;
        }
        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else if (valor <= Saldo += LimiteChequeEspecial)
            {
                double valorSaqueChequeEspecial = valor - Saldo;
                Saldo = 0;
                Console.WriteLine($"Saque de R${valor} (R${valorSaqueChequeEspecial} do limite de cheque especial) realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente e limite de cheque especial excedido para o saque.");
            }
        }
    }
}
