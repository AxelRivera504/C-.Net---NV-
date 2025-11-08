using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Clases
{
    public class Class2
    {
        public string EnviarMensajeString()
        {
            //Dejar vacio un string de dos maneras
            string var1 = "";
            string var2 = string.Empty;

            string var = "Hola que tal";
            return var;
        }

        public void DatosNumericos()
        {
            byte edad = 25;                // 0 a 255
            sbyte temperatura = -10;       // -128 a 127
            short habitantesPueblo = 32000; // -32768 a 32767
            ushort codigoPostal = 15000;   // 0 a 65535
            int poblacion = 1500000;       // valor entero común
            uint dineroAhorrado = 4000000000; // sin signo, solo positivos
            long distanciaEstrellas = 9000000000000; // valores muy grandes
            ulong galaxias = 18446744073709551615;   // máximo para ulong
            float precio = 10.75f;         // precisión simple (~6 dígitos)
            double pi = 3.14159265358979;  // precisión doble (~15 dígitos)
            decimal salario = 12345.67m;   // alta precisión para dinero

            // Mostrar límites
            Console.WriteLine("📏 LÍMITES DE TIPOS NUMÉRICOS\n");
            Console.WriteLine($"int: {int.MinValue} a {int.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} a {long.MaxValue}");
            Console.WriteLine($"uint: {uint.MinValue} a {uint.MaxValue}");
            Console.WriteLine($"ulong: {ulong.MinValue} a {ulong.MaxValue}\n");
        }

        public void OtroDatos()
        {
            bool activo = true;            // valor booleano
            char inicial = 'C';            // un solo carácter
        }

        public void DatosReferencia()
        {
            //Atajo Shift + enter para agregar las llaves cuando creemos un metodo
            Console.WriteLine("➡️ TIPOS DE DATOS POR REFERENCIA\n");

            string nombre = "CSharpista";
            object objeto = 12345; // puede guardar cualquier tipo
            dynamic variableDinamica = "Hola"; // tipo flexible

            Console.WriteLine($"string: {nombre}");
            Console.WriteLine($"object: {objeto}");
            Console.WriteLine($"dynamic inicial: {variableDinamica}");

            // cambiar tipo dinámico
            variableDinamica = 3.1416;
            Console.WriteLine($"dynamic cambiado a número: {variableDinamica}\n");
        }

        public void ArreglosListas()
        {
            Console.WriteLine("ARREGLOS Y LISTAS\n");

            int[] numeros = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Arreglo de números:");
            foreach (int n in numeros)
            {
                Console.WriteLine($"Número: {n}");
            }

            List<string> lenguajes = new List<string> { "C#", "Python", "JavaScript" };
            lenguajes.Add("Go");
            Console.WriteLine("\nLista de lenguajes:");
            lenguajes.ForEach(l => Console.WriteLine($"{l}"));

            foreach (string lenguaje in lenguajes)
            {
                Console.WriteLine($"Lenguaje: {lenguaje}");
            }
        }

        public void Condicionales()
        {
            Console.WriteLine("\nCONDICIONALES\n");
            int nota = 50;
            if (nota >= 90)
                Console.WriteLine("Excelente");
            else if (nota >= 70)
                Console.WriteLine("Aprobado");
            else
                Console.WriteLine("Reprobado");
        }

        public void Ciclos()
        {
            List<string> lenguajes = new List<string> { "C#", "Python", "JavaScript" };
            lenguajes.Add("Go");
            lenguajes.Add("Rust");

            Console.WriteLine("\n CICLOS\n");

            Console.WriteLine("FOR: 1 al 5");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }
            lenguajes.Remove("C#");

            //for (int i = 1; i <= 5; i++)
            //++ => Aumentar de 1, osae 1,2,3,4,5
            //+2 => Aumetnar de 2 en dos, osea 1,3,5,7,9...

            Console.WriteLine("\nWHILE: cuenta regresiva");
            int contador = 0;
            while (contador > 0)
            {
                Console.WriteLine(contador);
                contador--;
            }
            //-- => Disminuior de 1, osae 5,4,3,2,1
            //-2 => Aumetnar de 2 en dos, osea 6,4,2,0

            Console.WriteLine("\nDO WHILE: cuenta regresiva");
            int contador2 = 0;

            do
            {
                Console.WriteLine("Segui ejecutandote");
                contador2--;
            } while (contador2 > 0);
            //-- => Disminuior de 1, osae 5,4,3,2,1
            //-2 => Aumetnar de 2 en dos, osea 6,4,2,0

            Console.WriteLine("\nFOREACH: recorrer lista");
            foreach (var lang in lenguajes)
                Console.WriteLine(lang);
        }
    }
}
