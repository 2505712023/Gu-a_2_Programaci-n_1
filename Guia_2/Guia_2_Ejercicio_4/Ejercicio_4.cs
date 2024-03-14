/*
4)  Cree una lista que contenga 5 números enteros desordenados (pueden ser
    ingresados desde teclado o ser datos ya predeterminados por usted).

    Se necesita conocer (muéstrelo en un texto en pantalla):
        ➢ El número mayor y la posición que ocupa.
        ➢ El número del medio y la posición que ocupa.
        ➢ El número menor y la posición que ocupa.
 */

List<int> enteros = new List<int>();

Console.WriteLine("Ingrese los 5 números enteros que compondrán la lista.");

for (int i = 1; i <= 5; i++)
{
    switch (i)
    {
        case 1:
            Console.Write("Ingrese el primer número: ");
            enteros.Add(int.Parse(Console.ReadLine()));
            break;
        case 2:
            Console.Write("Ingrese el segundo número: ");
            enteros.Add(int.Parse(Console.ReadLine()));
            break;
        case 3:
            Console.Write("Ingrese el tercer número: ");
            enteros.Add(int.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.Write("Ingrese el cuarto número: ");
            enteros.Add(int.Parse(Console.ReadLine()));
            break;
        case 5:
            Console.Write("Ingrese el quinto número: ");
            enteros.Add(int.Parse(Console.ReadLine()));
            break;
        default:
            break;
    }
}

List<int> enteros_ordenados = enteros.ToList();
enteros_ordenados.Sort();

Console.WriteLine("\nEl número mayor de la lista es {0} y ocupa la posición número {1}", enteros_ordenados[4], enteros.IndexOf(enteros_ordenados[4]) + 1);
Console.WriteLine("El número del medio de la lista es {0} y ocupa la posición número {1}", enteros_ordenados[2], enteros.IndexOf(enteros_ordenados[2]) + 1);
Console.WriteLine("El número menor de la lista es {0} y ocupa la posición número {1}", enteros_ordenados[0], enteros.IndexOf(enteros_ordenados[0]) + 1);

Console.ReadKey();
