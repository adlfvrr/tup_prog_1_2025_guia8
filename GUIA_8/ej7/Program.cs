namespace ej7
{
    internal class Program
    {
        static int cantidad1=0, cantidad2=0, cantidad3 = 0, cantidad4 = 0, cantidad5 = 0, numeroTransaccionMayor = 0, contadorDeTransacciones = 0;
        static double montoTransaccionMayor = 0, porcentajeCantidadRubro1 = 0, porcentajeCantidadRubro2 = 0 , porcentajeCantidadRubro3 = 0, porcentajeCantidadRubro4 = 0, porcentajeCantidadRubro5 = 0, recaudacionTotal = 0;
        private static void InicializarVariables()
        {
            cantidad1 = 0; cantidad2 = 0; cantidad3 = 0; cantidad4 = 0; cantidad5 = 0; numeroTransaccionMayor = 0; contadorDeTransacciones = 0;
            montoTransaccionMayor = 0; porcentajeCantidadRubro1 = 0; porcentajeCantidadRubro2 = 0; porcentajeCantidadRubro3 = 0; porcentajeCantidadRubro4 = 0; porcentajeCantidadRubro5 = 0; recaudacionTotal = 0;
        }
        private static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            switch (rubro)
            {
                case 1: cantidad1 += cantidad; recaudacionTotal += monto; contadorDeTransacciones++; break;
                case 2: cantidad2 += cantidad; recaudacionTotal += monto; contadorDeTransacciones++; break;
                case 3: cantidad3 += cantidad; recaudacionTotal += monto; contadorDeTransacciones++; break;
                case 4: cantidad4 += cantidad; recaudacionTotal += monto; contadorDeTransacciones++; break;
                case 5: cantidad5 += cantidad; recaudacionTotal += monto; contadorDeTransacciones++; break;
                default: Console.WriteLine("Rubro inexistente"); break;
            }
            if (numeroTransaccionMayor == 0 && montoTransaccionMayor == 0)
            {
                numeroTransaccionMayor = nroTransaccion;
                montoTransaccionMayor = monto;
            }
            else
            {
                if (monto > montoTransaccionMayor)
                {
                    montoTransaccionMayor = monto;
                    numeroTransaccionMayor = nroTransaccion;
                }
            }
        }
        private static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            porcentajeCantidadRubro1 = 1.0 * (cantidad1 / (double)contadorDeTransacciones) * 100;
            porcentajeCantidadRubro2 = 1.0 * (cantidad2 / (double)contadorDeTransacciones) * 100;
            porcentajeCantidadRubro3 = 1.0 * (cantidad3 / (double)contadorDeTransacciones) * 100;
            porcentajeCantidadRubro4 = 1.0 * (cantidad4 / (double)contadorDeTransacciones) * 100;
            porcentajeCantidadRubro5 = 1.0 * (cantidad5 / (double)contadorDeTransacciones) * 100;
        }
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Ingrese opción: 
1- Ingresar un resumen de venta.
2- Mostrar Número de transacción registrado con el mayor monto total.
3- Mostrar porcentaje de cantidad por rubro.
4- Mostrar la recaudación total.
Otro- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        private static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Write("Ingrese numero de transacción: ");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese rubro: ");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
        }
        private static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            if (contadorDeTransacciones > 0)
            {
                CalcularPorcentajesCantidadVentasPorRubro();
                Console.WriteLine(@$"Los porcentajes de cantidad por rubro son:
Rubro 1: {porcentajeCantidadRubro1:f2}%
Rubro 2: {porcentajeCantidadRubro2:f2}%
Rubro 3: {porcentajeCantidadRubro3:f2}%
Rubro 4: {porcentajeCantidadRubro4:f2}%
Rubro 5: {porcentajeCantidadRubro5:f2}%");
                Console.ReadKey();
            }
            else { Console.WriteLine("No hubo transacciones."); Console.ReadKey(); }
        }
        private static void MostrarPantallaTransaccionMayorMonto()
        {
            if (contadorDeTransacciones > 0)
            {
                Console.WriteLine($"La transaccion con mayor monto es la numero {numeroTransaccionMayor}, con un monto de ${montoTransaccionMayor:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo transacciones.");
                Console.ReadKey();
            }
        }
        private static void MostrarPantallaMontoRecaudadoTotal()
        {
            if (contadorDeTransacciones > 0)
            {
                Console.WriteLine($"La recaudación total es de ${recaudacionTotal:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo transacciones");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir)
            {
                int op = MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1: MostrarPantallaRegistrarTransaccion(); break;
                    case 2: MostrarPantallaTransaccionMayorMonto(); break;
                    case 3: MostrarPantallaPorcentajeDeCantidadesPorRubro(); break;
                    case 4: MostrarPantallaMontoRecaudadoTotal(); break;
                    default: seguir = false; break;
                }
            }
        }
    }
}
