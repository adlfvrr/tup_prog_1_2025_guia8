namespace ej2
{
    internal class Program
    {
        #region Declaraciones
        static int edad0, edad1, edad2, edad3, edad,nroNina,op,suma;
        static double monto = 0, porcentaje0 = 0, porcentaje1 = 0, porcentaje2 = 0, porcentaje3 = 0, monto0 = 0, monto1 = 0, monto2 = 0, monto3 = 0;
        static bool seguir = true;
        #endregion
        #region Metodos !Mostrar
        static void RegistrarEdad()
        {
            edad = 0;
            Console.Write("Ingrese edad de la niña: ");
            edad = Convert.ToInt32(Console.ReadLine());
            suma += edad;
            Console.Write("A qué niña corresponde? ");
            nroNina = Convert.ToInt32(Console.ReadLine());
            if (nroNina == 1)
            {
                edad0 = edad;
            }
            else if (nroNina == 2)
            {
                edad1 = edad;
            }
            else if (nroNina == 3)
            {
                edad2 = edad;
            }
            else if (nroNina == 4)
            {
                edad3 = edad;
            }
        }
        static double RegistrarMontoARepartir()
        {
            Console.Write("Ingrese el monto a repartir: $");
            monto = Convert.ToDouble(Console.ReadLine());
            return monto;
        }
        static void CalcularMontosYPorcentajesARepartir()
        {   
                porcentaje0 = 1.0 * (edad0 / (double)suma) * 100;
                porcentaje1 = 1.0 * (edad1 / (double)suma) * 100;
                porcentaje2 = 1.0 * (edad2 / (double)suma) * 100;
                porcentaje3 = 1.0 * (edad3 / (double)suma) * 100;
                monto0 = (porcentaje0 * monto) / 100;
                monto1 = (porcentaje1 * monto) / 100;
                monto2 = (porcentaje2 * monto) / 100;
                monto3 = (porcentaje3 * monto) / 100;
        }
        
        #endregion
        #region Metodos Mostrar
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción:\n1. Iniciar monto a repartir\n2. Solicitar edad por niña\n3. Mostrar monto y porcentajes que corresponde a cada niña.\nOtro. Salir");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            RegistrarMontoARepartir();
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            RegistrarEdad();
        }
        static void MostrarPantallaCalcularYMostrarMontoYPorcentajePorNiña()
        {
            if (suma > 0){
                CalcularMontosYPorcentajesARepartir();
                Console.WriteLine($"A la niña 1 le corresponde un {porcentaje0:f2}%, equivalente a ${monto0:f2}");
                Console.WriteLine($"A la niña 2 le corresponde un {porcentaje1:f2}%, equivalente a ${monto1:f2}");
                Console.WriteLine($"A la niña 3 le corresponde un {porcentaje2:f2}%, equivalente a ${monto2:f2}");
                Console.WriteLine($"A la niña 4 le corresponde un {porcentaje3:f2}%, equivalente a ${monto3:f2}");
                Console.ReadKey();
            }
            else { Console.WriteLine("No se ingresaron edades.");Console.ReadKey(); }
        }
        #endregion
        #region Programa
        static void Main(string[] args)
        {
            while (seguir) 
            {
                MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1: MostrarPantallaSolicitarMontoARepartir(); break;
                    case 2: MostrarPantallaSolicitarEdadesNiñas(); break;
                    case 3: MostrarPantallaCalcularYMostrarMontoYPorcentajePorNiña(); break;
                    default: seguir = !seguir; break;
    
                }
            }
        }
        #endregion
    }
}
