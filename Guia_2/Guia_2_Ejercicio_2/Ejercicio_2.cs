/*
2)  Cree un arraylist que tenga como mínimo 7 elementos (pueden ser predefinidos o ingresados desde teclado) de tipo String.

    Pida al usuario que ingrese un texto y verifique si este existe dentro del arraylist que
    creo:
        ➢ En caso de que exista, solicite al usuario que ingrese un nuevo dato y reemplácelo
            con el elemento que encontró, debe mostrar un mensaje que diga: “Datos
            actualizados” seguido de eso debe mostrar el contenido del arraylist.
        ➢ En caso de no existir debe informarle al usuario y mostrar un mensaje “No se
            realizaron cambios”, seguido de eso debe mostrar el contenido del arraylist.

    ** Valide que el contenido dentro del arraylist y el ingresado este en: Mayúsculas.
*/

using System.Collections;

ArrayList palabras = new ArrayList();

for (int i = 1; i <= 7; i++)
{
    Console.Write("Ingrese la palabra {0} del ArrayList: ", i);
    palabras.Add(Console.ReadLine().ToUpper());
}

Console.WriteLine("\nArrayList ingresado exitosamente:");
foreach (string palabra in palabras)
{
    Console.WriteLine("- {0}", palabra);
}

Console.Write("Presione cualquier tacla para continuar...");
Console.ReadKey();
Console.Clear();

Console.Write("Ingrese la palabra que desea buscar en el ArrayList: ");
string expresion = Console.ReadLine().ToUpper();

if (palabras.Contains(expresion))
{
    Console.WriteLine("\nLa palabra \"{0}\" si existe en el ArrayList.", expresion);
    Console.Write("Ingrese la palabra por la cual desea reemplazar \"{0}\": ", expresion);

    palabras[palabras.IndexOf(expresion)] = Console.ReadLine().ToUpper();

    Console.WriteLine("\nDatos actualizados:");
    foreach (string palabra in palabras)
    {
        Console.WriteLine("- {0}", palabra);
    }
}
else
{
    Console.WriteLine("\nLa palabra \"{0}\" no existe en el ArrayList.", expresion);

    Console.WriteLine("\nNo se realizaron cambios:");
    foreach (string palabra in palabras)
    {
        Console.WriteLine("- {0}", palabra);
    }
}
Console.ReadKey();
