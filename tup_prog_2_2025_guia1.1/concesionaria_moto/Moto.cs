using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concesionaria_moto
{
    public class Moto
    {
        public string Marca { get; set; } 
        public int Modelo { get; set; }
        public double ValorFabricacion { get; set; }

        public Moto(string marca, int modelo, double valorFabricacion) 
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int anioACalcular, int vidaUtil)
        {
            if (vidaUtil <= 0) throw new ArgumentOutOfRangeException(nameof(vidaUtil));

            int aniosUso = Math.Max(0, anioACalcular - Modelo);
            double v = ValorFabricacion * (1.0 - (double)aniosUso / vidaUtil);

            return Math.Max(0, v);
        }


        public double CalcularDepreciacionAnual(int anioACalcular, double tasaDepreciacion)
        {
            if (tasaDepreciacion < 0 || tasaDepreciacion > 1)
                throw new ArgumentOutOfRangeException(nameof(tasaDepreciacion));

            int aniosUso = Math.Max(0, anioACalcular - Modelo);

            // Vact = Vfab × (1 − tasa)^aniosUso
            double factor = Math.Pow(1.0 - tasaDepreciacion, aniosUso);
            double v = ValorFabricacion * factor;

            return Math.Max(0, v);
        }

        public string VerDescripcion()
        {
            return $"Marca: {Marca} | Modelo: {Modelo} | Valor de fábrica: {ValorFabricacion:C2}";
        }
    }
}
