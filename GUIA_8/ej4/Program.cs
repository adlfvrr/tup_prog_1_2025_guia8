namespace ej4
{
    internal class Program
    {
        #region Declaraciones
        static string jugador1 = "", jugador2 = "", ganador = "";
        static int j1, j2, set1 = 0, set2 = 0,op;
        static bool menu = true;
        #endregion
        #region Metodos !Mostrar
        static void RegistrarJugadores()
        {
            if (jugador1 == "")
            {
                Console.Write("Ingrese nombre de jugador 1: ");
                jugador1 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jugador ya registrado");
            }
            if (jugador2 == "")
            {
                Console.Write("Ingrese nombre de jugador 2: ");
                jugador2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jugador ya registrado");
            }

        }
        static void RegistrarResultadoSet()
        {
            if (jugador1 == "" && jugador2 == "")
            {
                Console.WriteLine("Registrar jugadores primero.");
            }
            else
            {
                if (set1 == 0 && set2 == 0)
                {
                    Console.Write("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {jugador1}");
                            set1 = 1;
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                set2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                set2 = 1;
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    Console.WriteLine($"Ganador del set: {jugador1}");
                                    set1 = 1;
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos");
                        }
                    }
                }
                else if (set1 == 1 || set2 == 1)
                {
                    Console.WriteLine("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {jugador1}");
                            if (set1 == 1)
                            {
                                set1++;
                            }
                            else
                            {
                                set1 = 1;
                            }
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                if (set2 == 1)
                                {
                                    set2++;
                                }
                                else
                                {
                                    set2 = 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                if (set2 == 1)
                                {
                                    set2++;
                                }
                                else
                                {
                                    set2 = 1;
                                }
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    Console.WriteLine($"Ganador del set: {jugador1}");
                                    if (set1 == 1)
                                    {
                                        set1++;
                                    }
                                    else
                                    {
                                        set1 = 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos.");
                        }
                    }
                }
                else if (set1 == 1 && set2 == 1)
                {
                    Console.WriteLine("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            set1++;
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                set2++;
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                set2++;
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    set1++;
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La puntuación minima necesaria para ganar un set es de 4 puntos.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se pueden procesar más juegos.");
                }
            }
        }
        static void DeterminarGanador()
        {
            if (set1 == 2)
            {
                ganador = jugador1;
            }
            else if (set2 == 2)
            {
                ganador = jugador2;
            }
            else
            {
                Console.WriteLine("Se deben procesar más juegos.");
            }
        }
        #endregion
        #region Metodos Mostrar
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una opción: \n1.Registrar nombres de jugadores\n2.Registrar resultado de cada set\n3.Mostrar ganador\nOtro.Salir");
            op = Convert.ToInt32(Console.ReadLine());
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            RegistrarJugadores();
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            RegistrarResultadoSet();
            Console.ReadKey();
        }
        static void MostrarPantallaGanador()
        {
            DeterminarGanador();
            if (ganador != "")
            {
                Console.WriteLine($"El ganador del partido es {ganador}");
            }
            else
            {
                Console.WriteLine("Ganador no determinado");
            }
                Console.ReadKey();
        }
        #endregion
        #region Program
        static void Main(string[] args)
        {
            while (menu)
            {
                MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1:MostrarPantallaSolicitarNombreJugadores(); break;
                    case 2:MostrarPantallaSolicitarResultadoSet(); break;
                    case 3:MostrarPantallaGanador(); break;
                    default: menu = false; break;
                }
            }
        }
        #endregion

    }
}
