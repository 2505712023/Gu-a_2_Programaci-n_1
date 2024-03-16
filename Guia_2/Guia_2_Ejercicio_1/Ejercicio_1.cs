namespace Guia_2_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Console.WriteLine("Ingrese 5 número enteros: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
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
}