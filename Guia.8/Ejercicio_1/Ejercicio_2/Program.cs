using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_2
{
    internal class Program
    {

        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;
        static double monto;
        static double porcentaje0;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double monto0;
        static double monto1;
        static double monto2;
        static double monto3;
        static bool salir = false;
        static int totalEdad;


        static void RegistrarMontoARepartir(double monto)
        {

                monto0 = porcentaje0 * monto / 100;
                monto1 = porcentaje1 * monto / 100;
                monto2 = porcentaje2 * monto / 100;
                monto3 = porcentaje3 * monto / 100;
            

        }

        static int RegistrarEdad()
        {
            totalEdad = edad0 + edad1 + edad2 + edad3;

            return totalEdad;
        
        }

        static void CalcularMontosYPorcentajesARepartir()
        {
            porcentaje0 = (double)edad0 * 100 / RegistrarEdad();
            porcentaje1 = (double)edad1 * 100 / RegistrarEdad();
            porcentaje2 = (double)edad2 * 100 / RegistrarEdad();
            porcentaje3 = (double)edad3 * 100 / RegistrarEdad();

        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("Ingrese una opcion del menu");
            Console.WriteLine("1 - Iniciar Monto a repartir");
            Console.WriteLine("2 - Solicitar Edad Por niña");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("4- Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.WriteLine("Ingresar el monto que desea repartir");
            monto = Convert.ToDouble(Console.ReadLine());
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.WriteLine("Ingresa la edad de la primera niña");
            edad0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad de la niña segunda niña");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad de la niña tercera niña");
            edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad de la niña cuarta niña");
            edad3 = Convert.ToInt32(Console.ReadLine());


        }

        static void MostrarPantallaCalcularMostrarMontoYPorcentajeNiñas()
        {
            if (monto !=0)
            {
                CalcularMontosYPorcentajesARepartir();
                Console.WriteLine($"El porcentaje que le corresponde a cada niña es :\n Niña 1 {porcentaje0:f2}\n Niña 2 {porcentaje1:f2} \n Niña 3 {porcentaje2:f2}\n Niña 4 {porcentaje3:f2} ");
                RegistrarMontoARepartir(monto);
                Console.WriteLine($"El monto que le corresponde a cada niña es :\n Niña 1 {monto0:f2}\n Niña 2 {monto1:f2} \n Niña 3 {monto2:f2}\n Niña 4 {monto3:f2} ");

            }
            else
            {
                Console.WriteLine("El monto es 0");
            }
        }

        static void Main(string[] args)
        {

            while (salir != true)
            {
                
                int opcion = MostrarPantallaSolicitarOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;

                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;

                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajeNiñas();
                        break;


                    case 4:

                        Console.WriteLine("Saliendo del programa...");
                        salir = true;

                        break;


                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }

                if (salir != true)
                {
                    Console.WriteLine("\n\n\nPresione una tecla para continuar");
                    Console.ReadKey();

                }

            }
        }

    }
}
