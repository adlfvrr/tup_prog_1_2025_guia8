namespace ej6
{
    internal class Program
    {
        static int indecisos= 0, negativos= 0, positivos = 0, encuestados = 0;
        static double porcentajeIndecisos = 0, porcentajeNegativos = 0, porcentajePositivos = 0;
        private static void RegistrarOpinion (int op)
        {
            if (op == 0)
            {
                positivos++;
            }
            else if (op == 1)
            {
                negativos++;
            }
            else if (op == 2)
            {
                indecisos++;
            }
        }
        private static void ProcesarEncuesta()
        {
                porcentajeIndecisos = 1.0 * (indecisos / (double)encuestados) * 100;
                porcentajeNegativos = 1.0 * (negativos / (double)encuestados) * 100;
                porcentajePositivos = 1.0 * (positivos / (double)encuestados) * 100;
        }
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Ingrese opcion:
1. Registrar opinión.
2. Procesar y mostrar resultados encuesta.
Otro. Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        private static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Write("Ingrese opinión: 0.Positivo - 1.Negativo - 2.Indeciso ");
            int opinion = Convert.ToInt32(Console.ReadLine());
            encuestados++;
            RegistrarOpinion(opinion);
        }
        private static void MostrarPantallaProcesarYMostrarResultadosEncuesta()
        {
            if (encuestados != 0)
            {
                ProcesarEncuesta();
                Console.WriteLine(@$"Los resultados de la encuesta son:
Positivos - {porcentajePositivos:f2}%
Negativos - {porcentajeNegativos:f2}%
Indecisos - {porcentajeIndecisos:f2}%");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir)
            {
                int opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:MostrarPantallaRegistrarEncuesta();break;
                    case 2:MostrarPantallaProcesarYMostrarResultadosEncuesta();break;
                    default: seguir = false; break;
                }
            }
        }
    }
}
