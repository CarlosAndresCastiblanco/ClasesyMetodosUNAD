using System;

namespace ClasesyMetodosUNAD
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "N";
            while (salir == "N")
            {
                Figura figura = new Figura();
                Informacion info = new Informacion();
                Console.WriteLine(info.nombreDelPrograma);
                Console.WriteLine(info.autor);
                Console.WriteLine(info.usoDeLaAplicacion);
                Console.WriteLine(info.menu);
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(figura.SolicitudMensageData(opcion));
                double dato1 = 0;
                double dato2 = 0;
                for (int i = 0; figura.cantidadDeDatos > i; i++)
                {
                    double dato = Convert.ToDouble(Console.ReadLine());
                    if (i == 0)
                    {
                        dato1 = dato;
                    }
                    else
                    {
                        dato2 = dato;
                    }
                }
                Console.WriteLine(figura.EjecutarOpcion(opcion, dato1, dato2));
                Console.WriteLine(info.mensajeSalir);
                salir = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
