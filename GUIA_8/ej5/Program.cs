namespace ej5
{
    internal class Program
    {
        static int mes, anio;
        private static int DeterminarLosDiasDelMes(int mes, int año)
        {
            int dias = 0;
            if (mes <= 7 && mes > 0)
            {
                bool bisiesto = DeterminarSiEsBisiesto(año);
                if (mes % 2 == 0)
                {
                    dias = 30;
                    if (mes == 2)
                    {
                        dias = 28;
                        if (bisiesto == true)
                        {
                            dias = 29;
                        }
                    }
                }
                else
                {
                    dias = 31;
                }
            }
            else
            {
                if (mes % 2 == 0)
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }
            }
            return dias;
        }
        private static bool DeterminarSiEsBisiesto(int año)
        {
            bool EsBisiesto = false;
            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 400 == 0)
                {
                    EsBisiesto = true;
                }
            }
            return EsBisiesto;
        }
        private static void IngresoAñoYMes()
        {
            Console.Write("Ingrese número de mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese año: ");
            anio = Convert.ToInt32(Console.ReadLine());
        }
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Ingrese opción:
1. Determinar cantidad de días del mes
2. Verificar si el año es bisiesto.
Otro. Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        private static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            IngresoAñoYMes();
            int dias = DeterminarLosDiasDelMes(mes, anio);
            Console.WriteLine($"Los días del mes {mes} son {dias}");
            Console.ReadKey();
        }
        private static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            bool bisiesto = DeterminarSiEsBisiesto(anio);
            if (bisiesto == true)
            {
                Console.WriteLine($"El año {anio} es Bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {anio} no es Bisiesto");
            }
            Console.ReadKey();
        }
            static void Main(string[] args)
            {
                bool seguir = true;
                while (seguir)
                {
                    int opcion = MostrarPantallaSolicitarOpcionMenu();
                    switch (opcion)
                    {
                    case 1: MostrarPantallaSolicitarMesAñoYDeterminarDias();break;
                        case 2: MostrarPantallaVerificarSiElAñoEsBisiesto();break;
                    default: seguir = false;break;
                    }
                }
            }
        }
    }

