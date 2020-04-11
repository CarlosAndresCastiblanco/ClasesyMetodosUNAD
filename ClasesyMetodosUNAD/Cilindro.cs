using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesyMetodosUNAD
{
    class Cilindro
    {
        public double volumen;
        public double area;
        public string mensaje = "Por favor digite el radio y la altura";
        public int noParametros = 2;
        public string name = "Cilindro";
        public string datosDeEntrada;
        public double VolumenCilintro(double radio, double altura)
        {
            this.volumen = (Math.PI * Math.Pow(radio, 2)) * altura;
            return this.volumen;
        }

        public double AreaCilindro(double radio, double altura)
        {
            this.area = 2 * Math.PI * radio * (altura + radio);
            return this.area;
        }

        public string Solucion(double radio, double altura)
        {
            this.volumen = this.VolumenCilintro(radio, altura);
            this.area = this.AreaCilindro(radio, altura);
            this.datosDeEntrada = "radio " + radio + " altura " + altura;
            return "Para: " + this.name + Environment.NewLine + "Los datos de entrada son :" + this.datosDeEntrada + Environment.NewLine + "El Volumen es: " + this.volumen + "el Area es: " + this.area;
        }
    }
}
