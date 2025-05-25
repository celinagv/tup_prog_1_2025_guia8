using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        #region Atributos/Variables
        static int acumulador;
        static int contador;
        static int maximo;
        static int minimo;
        static int valor;
        static bool salir = false;
        static double promedio;

        #endregion


        static int RegistrarValor(int valor)
        {
            return 0;
        }


        static double CalcularPromedio()
        {
            if (contador !=0)
            {
                promedio =1.0* acumulador / contador;
            }
            else
            {
                promedio = 0;
            }
                return promedio;
        }


        static int MostrarPantallaSolicitarOpcionMenu ()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("Elija una opción del menu:");
            Console.WriteLine("1 - Procesar un solo número");
            Console.WriteLine("2 - Procesar varios números");
            Console.WriteLine("3 - Mostrar máximo y mínimo.");
            Console.WriteLine("4 - Mostrar promedio.");
            Console.WriteLine("5 - Mostrar cantidad de números ingresados.");
            Console.WriteLine("6 - Reiniciar variables.");
            Console.WriteLine("7 - Salir.");
            opcion =Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        static void MostrarIniciarVariables()
        {
            acumulador = 0;
            contador = 0;
            valor = 0;
            maximo = 0;
            minimo = 0;
        }

        static void MostrarPantallaSolicitarNumero()
        {
            int valor;
            Console.WriteLine("Ingresa un valor");
            valor = Convert.ToInt32(Console.ReadLine());
            contador++;
            acumulador += valor;

            maximo = valor;
            minimo = valor;
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            int cantidad;

            Console.WriteLine("Ingresa la cantidad de numeros a ingresar");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese el valor");
                valor = Convert.ToInt32(Console.ReadLine());
                contador++;
                acumulador += valor;

                if (contador == 1)
                {
                    maximo = valor;
                    minimo = valor;
                }
                else 
                {
                    maximo = Math.Max(maximo, valor);
                    minimo = Math.Min(minimo, valor);

                }

            }
        }

        static void MostrarPantallaMaximoMinimo()
        {
            Console.WriteLine($"El maximo numero ingresado es {maximo}, y el minimo numero ingresado es {minimo}. ");
        }


        static void MostrarPantallaCalcularYMostrarpromedio()
        {
            promedio = CalcularPromedio();

            Console.WriteLine($"El promedio es {promedio:F2}");
        }

        static void MostrarPantallaCantidad()
        {
            Console.WriteLine($"La cantidad de numeros ingresados es {contador}");
        }
        static void Main(string[] args)
        {

            MostrarIniciarVariables();
           


            while (salir != true)
            {
                int opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;

                    case 3:
                        MostrarPantallaMaximoMinimo();
                        break;

                    case 4:
                        MostrarPantallaCalcularYMostrarpromedio();
                        break;

                    case 5:
                        MostrarPantallaCantidad();
                        break;

                    case 6:
                        MostrarIniciarVariables();
                        Console.WriteLine("Variables reinicidas");
                        break;
                    case 7:
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                     break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                     break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            }



        }

    }
}
