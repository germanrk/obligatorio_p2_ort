using System;
using BibliotecaDeClases;
using System.Collections.Generic;

namespace Obligatorio_1
{
    class ActividadDeportiva
    {
        static void Main(string[] args)
        {
            List<string> periodistas = new List<string>();

            bool preguntar = true;
            Console.WriteLine("Bienvenido al sistema de gestion!");

            while (preguntar)
            {
                Console.WriteLine("Ingrese La opcion deseada...");
                Console.WriteLine("Ingrese 1 para entrar al menu");
                Console.WriteLine("Ingrese 0 para salir");
                string numOpcion = Console.ReadLine();
                bool inputOk = int.TryParse(numOpcion, out int miOpcion);

                if (inputOk)
                {
                    if (miOpcion == 0)
                        preguntar = false;
                    else
                    {
                        switch (miOpcion)
                        {
                            case 1:
                                Console.Clear();
                                MenuPrincipal();
                                break;
                        }
                        Console.Clear();
                    }
                }
                Console.WriteLine("Gracias por venir, precione cualquier tecla para cerrar");
                Console.Read();
                Console.Clear();
            }
        }
        public static void MenuPrincipal()
        {
            bool preguntar = true;
            Console.WriteLine("Menu principal elija una opcion:");
            Console.WriteLine("Precione 1 para dar de alta un periodista");
            Console.WriteLine("Precione 2 para dar de alta un jugador");
            Console.WriteLine("Precione 3 para dar de alta un partido");
            string numOpcion = Console.ReadLine();
            bool inputOk = int.TryParse(numOpcion, out int miOpcion);

            while (preguntar)
            {
                if (inputOk)
                {
                    if (miOpcion == 0)
                        preguntar = false;
                    else
                    {
                        switch (miOpcion)
                        {
                            case 1:
                                Console.Clear();
                                AltaPeriodista();
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
        public static void AltaPeriodista()
        {
            Console.WriteLine("Ingrese el nombre del Periodista");
            string nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese el apellido del Periodista");
            string apellido = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese el email del Periodista");
            string email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese la pass del Periodista");
            string pass = Console.ReadLine();
            Console.Clear();
            Periodista newPeriodista = new Periodista(nombre, apellido, email, pass);
            //try
            //{
            //    Console.WriteLine($"Su nombre es {newPeriodista.Nombre}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //bool inputOk = int.TryParse(numOpcion, out int miOpcion);
        }
    } // Method antes de aqui
}
