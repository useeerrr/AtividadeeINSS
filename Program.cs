using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Detalhar Data");
            Console.WriteLine("2 - Calcular Desconto INSS");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    DetalharData();
                    break;

                case 2:
                    CalcularDescontoINSS();
                    break;
            }

        } while (opcao != 0);
    }

    static void DetalharData()
    {
        Console.Write("Digite uma data (dd/MM/yyyy): ");
        DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Dia da semana: " + data.DayOfWeek);
        Console.WriteLine("Mês: " + data.ToString("MMMM"));

        if (data.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Hoje é domingo!");
        }
    }

    static void CalcularDescontoINSS()
    {
        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        double desconto = 0;

        if (salario <= 1621.00)
            desconto = salario * 0.075;

        else if (salario <= 2902.84)
            desconto = salario * 0.09;

        else if (salario <= 4354.27)
            desconto = salario * 0.12;

        else
            desconto = salario * 0.14;

        double salarioFinal = salario - desconto;

        Console.WriteLine($"Desconto INSS: R$ {desconto:F2}");
        Console.WriteLine($"Salário com desconto: R$ {salarioFinal:F2}");
    }
}