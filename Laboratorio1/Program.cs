using System;

class Program
{
    static void Main()
    {
        //Programa 2 de numero impar.
        // Solicitamos al usuario que ingrese un número entero positivo N mayor que cero
        Console.Write("Por favor ingrese un número entero positivo mayor que cero: ");
        int n = int.Parse(Console.ReadLine());

        // Calculamos el factorial de N y lo almacenamos en el resultado de una variable llamada "factorial"
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        // Imprimimos en la pantalla los números enteros positivos menores o iguales que N que sean divisibles entre 3
        Console.Write("Los números divisibles entre 3 son: ");
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // Imprimimos en la pantalla los números enteros positivos menores o iguales que N que sean divisibles entre 5 
        Console.Write("Los números divisibles entre 5 son: ");
        int j = 1;
        while (j <= n)
        {
            if (j % 5 == 0)
            {
                Console.Write(j + " ");
            }
            j++;
        }
        Console.WriteLine();

        // Imprimimos en la pantalla la secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N 
        Console.Write("La secuencia de los números enteros positivos que comienzan en 1 y se incrementan en 2 son: ");
        int k = 1;
        do
        {
            Console.Write(k + " ");
            k += 2;
        } while (k <= n);
        Console.WriteLine();

        // Imprimimos en pantalla el valor de la variable "factorial" al final del proceso
        if (n == 1)
        {
            Console.WriteLine("El factorial de " + n + " es: " + factorial);
        }
        else
        {
            int l = 1;
            int factorialWhile = 1;
            while (l <= n)
            {
                factorialWhile *= l;
                l++;
            }
            Console.WriteLine("El factorial de " + n + " es: " + factorialWhile);
        }
    }
}
