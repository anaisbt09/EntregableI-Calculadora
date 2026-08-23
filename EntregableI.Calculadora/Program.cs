using System;

namespace EntregableI.Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool seguirEjecutando = true;

            while (seguirEjecutando)
            {
                MostrarMenu();

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "0")
                {
                    seguirEjecutando = false;
                    Console.WriteLine("\nGracias por usarme :) .");
                    break;
                }

                if (opcion != "1" &&
                    opcion != "2" &&
                    opcion != "3" &&
                    opcion != "4")
                {
                    Console.WriteLine("\nOpción no válida.");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    continue;
                }

                double numero1 = LeerNumero("Ingrese el primer número: ");
                double numero2 = LeerNumero("Ingrese el segundo número: ");

                double resultado;

                switch (opcion)
                {
                    case "1":
                        resultado = Sumar(numero1, numero2);
                        MostrarResultado(resultado);
                        break;

                    case "2":
                        resultado = Restar(numero1, numero2);
                        MostrarResultado(resultado);
                        break;

                    case "3":
                        resultado = Multiplicar(numero1, numero2);
                        MostrarResultado(resultado);
                        break;

                    case "4":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("\nNo se puede dividir entre cero. :( ");
                        }
                        else
                        {
                            resultado = Dividir(numero1, numero2);
                            MostrarResultado(resultado);
                        }

                        break;
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }
        }

        static void MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       CALCULADORA              ");
            Console.WriteLine("================================");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            Console.WriteLine("================================");
        }

        static double LeerNumero(string mensaje)
        {
            double numero;

            while (true)
            {
                Console.Write(mensaje);

                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }

                Console.WriteLine("Error: ingrese un número válido. :(");
            }
        }

        static double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        static double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        static double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        static double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        static void MostrarResultado(double resultado)
        {
            Console.WriteLine($"\nResultado: {resultado}");
        }
    }
}