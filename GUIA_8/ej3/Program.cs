using System.Collections;
using System.Diagnostics;

namespace ej3
{
    internal class Program
    {
        #region Declaraciones
        static string nombre0 = "", nombre1 = "", nombre2 = "", nombre,nombmayor = "",nombmedio = "",nombmenor = "";
        static int numeroLibreta0, numeroLibreta1, numeroLibreta2, orden = 1, numero, op, notamayor = 0, notamenor = 0, notamedia = 0;
        static bool menu = true;
        #endregion
        #region Metodos !Mostrar
        static void RegistrarNombreYNumeroLibreta()
        {
            if (orden < 4)
            {
                Console.Write($"Ingrese nombre del alumno {orden}: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese número de libreta: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (nombre0 == "" && numeroLibreta0 == 0)
                {
                    nombre0 = nombre;
                    numeroLibreta0 = numero;
                }
                else if (nombre1 == "" && numeroLibreta1 == 0)
                {
                    nombre1 = nombre;
                    numeroLibreta1 = numero;
                }
                else if (nombre2 == "" && numeroLibreta2 == 0)
                {
                    nombre2 = nombre;
                    numeroLibreta2 = numero;
                }
                orden++;
                if (notamayor == 0 && notamedia == 0 && notamenor == 0)
                {
                    notamayor = numero;
                    notamenor = numero;
                    notamedia = numero;
                }
            }
            else
            {
                Console.WriteLine("Límite de ingresos alcanzado.");
                Console.ReadKey();
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
        static void OrganizarLista()
        {
            if (numeroLibreta0 > numeroLibreta1)
            {
                if (numeroLibreta0 > numeroLibreta2)
                {
                    notamayor = numeroLibreta0;
                    nombmayor = nombre0;
                    if (numeroLibreta1 > numeroLibreta2)
                    {
                        nombmedio = nombre1;
                        notamedia = numeroLibreta1;
                        notamenor = numeroLibreta2;
                        nombmenor = nombre2;
                    }
                    else
                    {
                        nombmedio = nombre2;
                        notamedia = numeroLibreta2;
                        notamenor = numeroLibreta1;
                        nombmenor = nombre1;
                    }
                }
                else
                {
                    notamayor = numeroLibreta2;
                    nombmayor = nombre2;
                    nombmedio = nombre0;
                    notamedia = numeroLibreta0;
                    notamenor = numeroLibreta1;
                    nombmenor = nombre1;
                }
            }
            else
            {
                if (numeroLibreta1 > numeroLibreta2)
                {
                    notamayor = numeroLibreta1; nombmayor = nombre1;
                    if (numeroLibreta2 > numeroLibreta0)
                    {
                        notamedia = numeroLibreta2;
                        nombmedio = nombre2;
                        notamenor = numeroLibreta0;
                        nombmenor = nombre0;
                    }
                    else
                    {
                        notamedia = numeroLibreta0;
                        nombmedio = nombre0;
                        notamenor = numeroLibreta2;
                        nombmenor = nombre2;
                    }
                }
                else
                {
                    notamayor = numeroLibreta2;
                    nombmayor = nombre2;
                    notamedia = numeroLibreta1;
                    nombmedio = nombre1;
                    nombmenor = nombre0;
                    notamenor = numeroLibreta0;
                }
            }
        }
        
        #endregion
        #region Metodos Mostrar
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción: \n1.Registrar notas\n2.Mostrar lista ordenada\n3.Ordenar lista\nOtro.Salir");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            RegistrarNombreYNumeroLibreta();
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (nombmayor == "" && notamayor == 0 && nombmedio == "" && notamedia == 0 && nombmenor == "" && notamenor == 0)
            {
                Console.WriteLine("No se pudo determinar la lista. Es obligatorio el ingreso de 3 alumnos.");
            }
            else {
                Console.WriteLine($"El alumno con mayor nota es {nombmayor} con la nota {notamayor}\nEl alumno con nota media es {nombmedio} con la nota {notamedia}\nEl alumno con menor nota es {nombmenor} con la nota {notamenor}");
                }
                Console.ReadKey();
        }
        #endregion
        #region Programa
        static void Main(string[] args)
        {
            while (menu)
            {
                MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                        case 1: RegistrarNombreYNumeroLibreta();break;
                        case 2: MostrarPantallaMostrarListaOrdenada();break;
                        case 3: OrganizarLista();break;
                        default: menu = !menu;break;
                }
            }
        }
        #endregion
    }
}
