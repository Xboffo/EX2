using System;

class Program
{
    // Função para verificar se um número está na sequência de Fibonacci
    static bool VerificaSePertenceFibonacci(int numeroDigitado)
    {
        int a = 0, b = 1;

        while (a <= numeroDigitado)
        {
            if (a == numeroDigitado)
            {
                return true; // Número pertence
            }
            int c = a + b;
            a = b;
            b = c;
        }

        return false; // Número não pertence
    }
    static void Main()
    {
        Console.Write("Informe um número: ");

        // Lê o número 
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Verifica se o número pertence 
            if (VerificaSePertenceFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Caracter não reconhecido, Você deve inserir um número válido.");
        }
    }
}
