using System.Numerics;

namespace ej1
{
    internal class Program
    {
        #region Variables
        static int ac = 0, cont = 0, max = 0, min = 0;
        #endregion
        #region Metodos
        private static void RegistrarValor(int n)
        {
            ac += n;
            cont++;
            if (max == 0 && min == 0)
            {
                max = n;
                min = n;
            }
            else
            {
                if (n > max)
                {
                    max = n;
                }
                else if (n < min)
                {
                    min = n;
                }
            }
        }
        private static double CalcularPromedio()
        {
            double prom = 1.0 * (ac / (double)cont);
            return prom;
        }
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción: \n1.Solicitar número\n2.Solicitar varios números\n3.Mostrar máximo y mínimo\n4.Mostrar promedio\n5.Cantidad de numeros ingresados\n6.Iniciar Variables\nOtro.Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        private static void IniciarVariables()
        {
            ac = 0;
            cont = 0;
            max = 0;
            min = 0;
            Console.WriteLine("Variables reinicadas");
            Console.ReadKey();
        }
        private static void SolicitarNumero()
        {
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(n);

        }
        private static void SolicitarVariosNumeros()
        {
            Console.Write("Ingrese cantidad de ingresos: ");
            int ingresos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ingresos; i++)
            {
                Console.Write("Ingrese un número: ");
                int n = Convert.ToInt32(Console.ReadLine());
                RegistrarValor(n);
            }
        }
        private static void MostrarMaximoYMinimo()
        {
            Console.WriteLine($"El numero mayor ingresado es {max}.\nEl numero menor ingresado es {min}.");
            Console.ReadKey();
        }
        private static void MostrarPromedio()
        {
            if (cont != 0)
            {
                double prom = CalcularPromedio();
                Console.WriteLine($"El promedio es {prom:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
                Console.ReadKey();
            }
        }
        private static void MostrarCantidadNumeros()
        {
            Console.WriteLine($"Los numeros ingresados son {cont}");
            Console.ReadKey();
        }
        #endregion
        #region Programa
        static void Main(string[] args)
        {
            bool menu = true;
            int opcion;
            while (menu)
            {

                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: SolicitarNumero(); break;
                    case 2: SolicitarVariosNumeros(); break;
                    case 3: MostrarMaximoYMinimo(); break;
                    case 4: MostrarPromedio(); break;
                    case 5: MostrarCantidadNumeros(); break;
                    case 6: IniciarVariables(); break;
                    default: menu = false; break;
                }

            }

        }
        #endregion

    }

}
