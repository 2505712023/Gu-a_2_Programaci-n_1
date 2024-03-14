/*
1)  Cree 2 array, el primero debe contener números enteros y el segundo será llenado con el
    triple del numero que tenga el primer array en la misma posición.

    Ejemplo:
        Array 1 [2,5,10,25]
        Array 2 [6, 15, 30, 75]

    Importante:
        ➢ Deben tener mínimo 5 elementos.
        ➢ Los datos del primer array deben ser ingresados desde teclado.
        ➢ El segundo array debe ser llenado por el programa, no debe colocarle los datos
            predeterminados (datos quemados).
        ➢ Valide que lo ingresado por el usuario sean números para evitar posibles errores
            en el código.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
    
        int[] array1 = new int[5];
        int[] array2 = new int[5];

        Console.WriteLine("Ingrese 5 número enteros: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Número {i + 1}: ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            array2[i] = array1[i] * 3;
        }

        Console.WriteLine("\nPrimer Array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nSegundo Array (Triple de los números del primer array):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array2[i] + " ");
        }
        Console.WriteLine();
    }
}
