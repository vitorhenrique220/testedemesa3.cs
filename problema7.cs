using System;

namespace Problema7
{
    class Investimento
    {
        
        public double ValorPresente;
        public double TaxaJurosMensal;
        public double ValorResgateQuintoMes;

       
        public Investimento(double vp, double taxa, double resgate)
        {
            ValorPresente = vp;
            TaxaJurosMensal = taxa / 100; 
            ValorResgateQuintoMes = resgate;
        }

        
        public void MostrarEvolucao()
        {
            double saldoAtual = ValorPresente;

            Console.WriteLine("\n{0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15}", "Período", "Saldo Inicial", "Rendimento", "Resgate", "Saldo Final");
            Console.WriteLine(new string('-', 85));

           
            for (int mes = 1; mes <= 8; mes++)
            {
                double saldoInicialNoMes = saldoAtual;
                double rendimentoNoMes = saldoInicialNoMes * TaxaJurosMensal;
                double resgateAplicado = 0;

                
                if (mes == 5)
                {
                    resgateAplicado = ValorResgateQuintoMes;
                }

                saldoAtual = saldoInicialNoMes + rendimentoNoMes - resgateAplicado;

                Console.WriteLine("Mês {0,-11} | {1,15:C2} | {2,15:C2} | {3,15:C2} | {4,15:C2}",
                    mes, saldoInicialNoMes, rendimentoNoMes, resgateAplicado, saldoAtual);
            }

            
            double saldoAntesDos10Dias = saldoAtual;
            double taxaDiaria = TaxaJurosMensal / 30;
            double rendimento10Dias = saldoAntesDos10Dias * taxaDiaria * 10;
            double saldoFinalTotal = saldoAntesDos10Dias + rendimento10Dias;

           
            Console.WriteLine("{0,-15} | {1,15:C2} | {2,15:C2} | {3,15:C2} | {4,15:C2}",
                "8 meses + 10d", saldoAntesDos10Dias, rendimento10Dias, 0.00, saldoFinalTotal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Valor Presente Investido: ");
                double vp = Convert.ToDouble(Console.ReadLine());

                Console.Write("Taxa de Juros Mensal (%): ");
                double taxa = Convert.ToDouble(Console.ReadLine());

                Console.Write("Valor do Resgate (somente no 5º mês): ");
                double resgate = Convert.ToDouble(Console.ReadLine());

             
                Investimento meuInvestimento = new Investimento(vp, taxa, resgate);

               
                meuInvestimento.MostrarEvolucao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
