using System;

namespace DecoParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero = PideEntero();

            if (EsPar(numero))
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }

            Console.ReadLine();
        }

        static int PideEntero()
        {
            int numero;
            Console.WriteLine("Ingrese un número entero:");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("El número ingresado no es un entero valido! Ingrese un entero válido:");
            }
            
            return numero;
        }

        static bool EsPar(int num)
        {
            return num % 2 == 0;
        }
    }
}