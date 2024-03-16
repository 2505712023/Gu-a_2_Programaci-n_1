using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> elementos = new List<string>();

        do
        {
            Console.Clear();
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Agregar un nuevo elemento.");
            Console.WriteLine("b) Actualizar un elemento.");
            Console.WriteLine("c) Eliminar un elemento.");
            Console.WriteLine("d) Mostrar alfabéticamente (A-Z).");
            Console.WriteLine("e) Mostrar alfabéticamente y en orden inverso (Z - A).");
            Console.WriteLine("f) Cerrar programa.");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "a")
            {
                Console.Write("Ingrese el nuevo elemento: ");
                string nuevoElemento = Console.ReadLine();
                elementos.Add(nuevoElemento);
                Console.WriteLine("Elemento agregado correctamente.");
            }
            else if (opcion == "b")
            {
                Console.Write("Ingrese el elemento que desea actualizar: ");
                string elementoActualizar = Console.ReadLine();
                if (elementos.Contains(elementoActualizar))
                {
                    Console.Write("Ingrese el nuevo valor para el elemento: ");
                    string nuevoValor = Console.ReadLine();
                    int index = elementos.IndexOf(elementoActualizar);
                    elementos[index] = nuevoValor;
                    Console.WriteLine("Elemento actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("El elemento no existe en la lista.");
                }
            }
            else if (opcion == "c")
            {
                Console.Write("Ingrese el elemento que desea eliminar: ");
                string elementoEliminar = Console.ReadLine();
                if (elementos.Contains(elementoEliminar))
                {
                    elementos.Remove(elementoEliminar);
                    Console.WriteLine("Elemento eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("El elemento no existe en la lista.");
                }
            }
            else if (opcion == "d")
            {
                elementos.Sort();
                Console.WriteLine("Elementos ordenados alfabéticamente (A-Z):");
                foreach (string elemento in elementos)
                {
                    Console.WriteLine(elemento);
                }
            }
            else if (opcion == "e")
            {
                elementos.Sort();
                elementos.Reverse();
                Console.WriteLine("Elementos ordenados alfabéticamente en orden inverso (Z-A):");
                foreach (string elemento in elementos)
                {
                    Console.WriteLine(elemento);
                }
            }
            else if (opcion == "f")
            {
                Console.WriteLine("Cerrando el programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            }

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();

        } while (true);
    }
}
