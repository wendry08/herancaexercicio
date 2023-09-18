using ExercicioHeranca___POO.Classes;

public class Program
{
    static void Main(string[] args)
    {
        ContaEmpresa contaEmpresa = new ContaEmpresa(1, "Agencia1", "Empresa1", 100.0, 5000.0);
        ContaEstudante contaEstudante = new ContaEstudante(2, "Agencia2", "Estudante1", 1000.0, "12345678901", "Universidade XYZ");

        contaEmpresa.Depositar(5000.0);
        contaEmpresa.RealizarEmprestimo(3000.0);
        contaEmpresa.Sacar(8000.0);

        contaEstudante.Depositar(1000.0);
        contaEstudante.Sacar(1500.0);
        contaEstudante.Sacar(2000.0);


    }
}