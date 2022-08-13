using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//llamada de clases externas que incluyen las funciones
using static Opciones_de_menu.Ejemplo_if;
using static Opciones_de_menu.Ejemplo_switch;
using static Opciones_de_menu.Ejemplo_for;
using static Opciones_de_menu.Ejemplo_while;
using static Opciones_de_menu.Ejemplo_dowhile;


namespace Opciones_de_menu
{
    class Principal
    {
        //Funcion principal que inicia el programa
        static void Main(string[] args)
        {
            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");

            System.Console.ReadKey();

            int repetir;

            //menu_interno();

            do
            {
                menu_interno();

                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

        } //Cierre de función principal


        //Inicio de funciones interna
        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo Wor");
            System.Console.WriteLine("5. Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:
                    //Ejemplo para llamar clase externa
                    Ejemplo_if();

                    //llamada función interna
                    //programa_if();
                    break;

                case 2:
                    //llamada de función interna
                    Ejemplo_switch();
                    break;

                case 3:
                    //llamada de función interna
                    Ejemplo_for();
                    break;

                case 4:
                    //llamada de función interna
                    Ejemplo_while();
                    break;
                case 5:
                    //llamada de función interna
                    Ejemplo_dowhile();
                    break;
            }

        }

        //Función interna para ejemplo if
        static void Ejemplo_if()
        {
            System.Console.WriteLine("Aqui llamo ejemplo If");
            string myInput;
            int myInt;
            Console.Write("Dame un número: ");
            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);
            // comparación para una toma de decisión SIMPLE
            if (myInt > 0)
            {
                Console.WriteLine("el número {0} es mayor que cero", myInt);
            }
            // comparación para una toma de decisión SIMPLE
            if (myInt < 0)
            {
                Console.WriteLine("el número {0} es menor que cero", myInt);
            }
            // comparación para tomar UNA DE DOS decisiones
            if (myInt != 0)
            {
                Console.WriteLine("el número {0} es distinto de cero", myInt);
            }
            else
            {
                Console.WriteLine("el número {0} es igual a cero", myInt);
            }

        }

        //Función interna para ejemplo switch
        static void Ejemplo_switch()
        {
            System.Console.WriteLine("Aqui llamo ejemplo Switch");
            Console.WriteLine("ingrese un numero entre 1 y 3");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("valor es 1");
                    break;
                case 2:
                    Console.WriteLine("valor es 2");
                    break;
                case 3:
                    Console.WriteLine("valor es 3");
                    break;
                default:
                    Console.WriteLine("no se encontro el valor");
                    break;
            }
            Console.ReadKey(); 


        }

        //Función interna para ejemplo for
        static void Ejemplo_for()
        {
            System.Console.WriteLine("Aqui llamo ejemplo For");
            System.Console.WriteLine("Contador iniciado:");
            for (int num = 1; num <= 100; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        //Función interna para ejemplo while
        static void Ejemplo_while()
        {
            System.Console.WriteLine("Aqui llamo ejemplo While");
            System.Console.WriteLine("Ejemplo de while:");
            Console.WriteLine("escriba un numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un numero mayor que el anterior.");
            int numero2 = int.Parse(Console.ReadLine());
            while (numero1 < numero2)
            {
                Console.WriteLine("valores:" + numero1);
                numero1++;
            }
            Console.ReadKey();
        }

        //Función interna para ejemplo dowhile
        static void Ejemplo_dowhile()
        {
            System.Console.WriteLine("Aqui llamo ejemplo DoWhile");
            string secret;
            string programacion;
            Console.WriteLine("Introduzca la palabra secreta:");
            secret = Console.ReadLine();
            do
            {
                Console.WriteLine("Vuelva a introducir la palabra secreta:");
                programacion = Console.ReadLine();
                if (programacion != secret)
                    Console.WriteLine("Palabra incorrecta!!!");
            } while (programacion != secret);

            Console.WriteLine("Palabra Correcta.");
            Console.ReadKey();
        }

        //Fin de funciones internas

    }
}
