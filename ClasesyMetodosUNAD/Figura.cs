using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClasesyMetodosUNAD
{
    class Figura
    {

        private Cilindro cilindro = new Cilindro();
        private TetraedroRegular tetraedroRegular = new TetraedroRegular();
        private UsoCunaEsferica usoCunaEsferica = new UsoCunaEsferica();
        public int cantidadDeDatos; 
        public string SolicitudMensageData(int value)
        {
            string message = "";
            if (value == 1)
            {
                this.cantidadDeDatos = this.tetraedroRegular.noParametros;
                message = this.tetraedroRegular.mensaje;
            }
            else if (value == 2)
            {
                this.cantidadDeDatos = this.usoCunaEsferica.noParametros;
                message = this.usoCunaEsferica.mensaje;
            }
            else if (value == 3)
            {
                this.cantidadDeDatos = this.cilindro.noParametros;
                message = this.cilindro.mensaje;
            }
            else
            {
                Console.WriteLine("Error en la selección");
            }
            return message;
        }

        public string EjecutarOpcion(int opcion, double dato1, double dato2)
        {
            string message = "";
            if (opcion == 1)
            {
                message = this.tetraedroRegular.Solucion(dato1);
            }
            else if (opcion == 2)
            {
                message = this.usoCunaEsferica.Solucion(dato1, dato2);
            }
            else if (opcion == 3)
            {
                message = this.cilindro.Solucion(dato1,dato2);
            }
            else
            {
                Console.WriteLine("Error en la Ejecución");
            }
            return message;
        }
    }
}
