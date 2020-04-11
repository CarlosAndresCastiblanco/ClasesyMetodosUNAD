using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesyMetodosUNAD
{
    class UsoCunaEsferica
    {
        public double volumen;
        public double area;
        public string mensaje = "Por favor digite los grados y el radio";
        public int noParametros = 2;
        public string name = "Huso - Cuña Esferica";
        public string datosDeEntrada;

        public double VolumenUsoCanaEsferica(double grados, double radio)
        {
            this.volumen = (4 / 3) * ((Math.PI * Math.Pow(radio, 3)) / 360) * grados;
            return this.volumen;
        }

        public double AreaUsoCanaEsferica(double grados, double radio)
        {
            this.area = ((4 * Math.PI * Math.Pow(radio, 2)) / 360) * grados;
            return this.area;
        }

        public string Solucion(double grados, double radio)
        {
            this.volumen = this.VolumenUsoCanaEsferica(grados, radio);
            this.area = this.AreaUsoCanaEsferica(grados, radio);
            this.datosDeEntrada = "grados " + grados + " radio " + radio;
            return "Para: "+ this.name + Environment.NewLine + "Los datos de entrada son :"+ this.datosDeEntrada + Environment.NewLine + "El Volumen es: " + this.volumen + "el Area es: " + this.area; 
        }
    }
}
