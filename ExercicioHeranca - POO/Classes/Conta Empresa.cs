using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca___POO.Classes
{
    internal class Conta_Empresa:Banco
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public Conta_Empresa(int numeroConta, string agencia, string titular,double saldo, double taxaAnuidade, double limiteEmprestimo, double totalemprestimo)
            :base(taxaAnuidade,limiteEmprestimo,totalemprestimo)
        {
            this.TaxaAnuidade = taxaAnuidade;
            this.LimiteEmprestimo = limiteEmprestimo;
            this.TotalEmprestimo = totalemprestimo;
        }
        public void RealizarEmprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
                Console.WriteLine($"Empréstimo de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de empréstimo excede o limite disponível.");
            }
        }
        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else if (valor <= Saldo + LimiteEmprestimo)
            {
                double valorSaqueChequeEspecial = valor - Saldo;
                Saldo = 0;
                TotalEmprestimo -= valorSaqueChequeEspecial;
                Console.WriteLine($"Saque de R${valor} (R${valorSaqueChequeEspecial} do limite de cheque especial) realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque e limite de cheque especial excedido.");
            }
        }




    }
}
