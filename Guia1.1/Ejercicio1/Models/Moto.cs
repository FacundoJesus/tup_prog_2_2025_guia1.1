using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Moto
    {
        public string Marca { get; }
        public int Modelo { get; }
        public double ValorFabricacion { get; }

        public Moto (string marca, int modelo, double valorFabrica)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.ValorFabricacion = valorFabrica;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            double valorActualizado = this.ValorFabricacion - (this.ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
            return valorActualizado;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            double valorActualizado = this.ValorFabricacion * (Math.Pow(1 - 0.1, añoACalcular - Modelo));
            return valorActualizado;
        }

        public string VerDescripcion()
        {
            return $"Marca: {this.Marca}, Modelo: {this.Modelo}, Valor Fabricación: {this.ValorFabricacion:c2}";

        }
    }
}
