using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesyMetodosUNAD
{
    class TetraedroRegular
    {
        public double volumen;
        public double area;
        public string mensaje = "Por favor digite la Longitud";
        public int noParametros = 1;
        public string name = "Tetraedro Regular";
        public string datosDeEntrada;
        public double VolumenTetraedroRegular(double longitud)
        {
            this.volumen = (Math.Pow(longitud, 3) * Math.Sqrt(2)) / 12;
            return this.volumen;
        }

        public double AreaTetraedroRegular(double longitud)
        {
            this.area = Math.Pow(longitud, 2) * Math.Sqrt(3);
            return this.area;
        }

        public string Solucion(double longitud)
        {
            this.volumen = this.VolumenTetraedroRegular(longitud);
            this.area = this.AreaTetraedroRegular(longitud);
            this.datosDeEntrada = "longitud " + longitud;
            return "Para: " + this.name + Environment.NewLine + "Los datos de entrada son :" + this.datosDeEntrada + Environment.NewLine + "El Volumen es: " + this.volumen + "el Area es: " + this.area;
        }
    }
}
