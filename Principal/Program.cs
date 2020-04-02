using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Matriz m1 = new Matriz(2, 3);
                m1.Cargar();
                Console.WriteLine("Matriz A");
                m1.Mostrar();

               Matriz m2 = new Matriz(3, 4);
                m2.Cargar();
                Console.WriteLine("\nMatriz B");
                m2.Mostrar();

                Console.WriteLine("\nResultado");            
                m1.Multiplicar(m2).Mostrar();              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}