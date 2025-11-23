using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Clases.Class3
{
    public class Persona
    {
        #region Propiedades
        public string NombreCompleto { get; set; } = string.Empty;
        public int Edad { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        #endregion

        #region Constructores
        public Persona(string nombreCompleto, int edad, decimal altura, decimal peso)
        {
            NombreCompleto = nombreCompleto;
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }
        #endregion

        #region Métodos
        public void Caminar()
        {
            Console.WriteLine(NombreCompleto + "esta caminando" + Edad + "nose");
            Console.WriteLine($"{NombreCompleto} esta caminando {Edad} nose");
        }

        public void Saludar()
        {
            Console.WriteLine($"{NombreCompleto} esta saludndo");
        }

        public double CalcularIMC()
        {
            double IMC = Convert.ToDouble(Peso) / Math.Sqrt(Convert.ToDouble(Altura));
            return IMC;
           
        }
        #endregion
    }
}
