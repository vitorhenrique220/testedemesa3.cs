using System;

class Program
{
    static void Main()
    {
        double valorPresente;
        double valorFuturo;
        double taxaJuros;
        int Mes = 8;
        int dias = 10;
        double periodo = Mes + (dias / 30.0);



        Console.Write("Digite o valor presente: ");
        valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros: ");
        taxaJuros = double.Parse(Console.ReadLine());

        Console.WriteLine("O numero de meses e dias é " + periodo);

        valorFuturo = valorPresente * Math.Pow((taxaJuros / 100 + 1), periodo);

        Console.WriteLine("O valor futuro é " + valorFuturo);

    }
}

