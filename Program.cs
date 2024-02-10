using System;


//Napisz program, który rekurencyjnie znajduje 10 pierwszych liczb Fibonacciego* i wyświetla je.
//*Ciąg Fibonacciego to ciąg liczb naturalnych określony rekurencyjnie w następujący sposób:
//pierwszy wyraz to F0 = 0, drugi to F1 = 1, każdy następny jest sumą dwóch poprzednich, tzn. Fn-1 + Fn-2 dla n > 1.
//Wyrazy ciągu Fibonacciego to: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233... itd.

class CiagFibonacciego
{
    static int[] GenerateFibonacciSequence(int count)
    {
        int[] fibonacciSequence = new int[count];
        fibonacciSequence[0] = 0;
        fibonacciSequence[1] = 1;

        for (int i = 2; i < count; i++)
        {
            fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
        }
        return fibonacciSequence;
    }

    static void Main()
    {
        try
        {
            int count = 10;
            int[] fibonacciSequence = GenerateFibonacciSequence(count);
            Console.WriteLine("Pierwsze 10 liczb Fibonacciego: ");
            foreach (int num in fibonacciSequence)
            {
                Console.WriteLine(num);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił wyjątek: " + ex.Message);
        }
    }
}