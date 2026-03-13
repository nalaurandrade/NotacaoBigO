using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Demonstração de Notação Big-O ===");
            Console.WriteLine("1 - O(1) Constante");
            Console.WriteLine("2 - O(log n) Logarítmica");
            Console.WriteLine("3 - O(n) Linear");
            Console.WriteLine("4 - O(n²) Quadrática");
            Console.WriteLine("5 - O(n³) Cúbica");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 0)
                break;

            Console.Write("Digite o tamanho da entrada (n): ");
            int n = int.Parse(Console.ReadLine());

            Stopwatch tempo = Stopwatch.StartNew();

            switch (opcao)
            {
                case 1:
                    BigOConstante(n);
                    break;

                case 2:
                    BigOLogaritmico(n);
                    break;

                case 3:
                    BigOLinear(n);
                    break;

                case 4:
                    BigOQuadratico(n);
                    break;

                case 5:
                    BigOCubico(n);
                    break;
            }

            tempo.Stop();

            Console.WriteLine($"Tempo de execução: {tempo.ElapsedMilliseconds} ms");
            Console.ReadKey();

        } while (true);
    }

    // O(1)
    static void BigOConstante(int n)
    {
        int[] vetor = new int[n];
        vetor[0] = 10;
        Console.WriteLine("Operação constante executada.");
    }

    // O(log n)
    static void BigOLogaritmico(int n)
    {
        int i = 1;

        while (i < n)
        {
            i *= 2;
        }

        Console.WriteLine("Loop logarítmico executado.");
    }

    // O(n)
    static void BigOLinear(int n)
    {
        for (int i = 0; i < n; i++)
        {
        }

        Console.WriteLine("Loop linear executado.");
    }

    // O(n²)
    static void BigOQuadratico(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
            }
        }

        Console.WriteLine("Loop quadrático executado.");
    }

    // O(n³)
    static void BigOCubico(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                }
            }
        }

        Console.WriteLine("Loop cúbico executado.");
    }
}s