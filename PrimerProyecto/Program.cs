using PrimerProyecto.Clases;
using PrimerProyecto.Clases.Class3;
//Versión 
//namespace MiApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

#region Clase 1 de noviembre 2025
//Clase 1 de noviembre 2025
//Class1 class1 = new Class1();
//class1.Variables();
#endregion

#region Clase 2 del 8 de noviembre del 2025
Class2 class2 = new Class2();

//Atajos
//Para comentar codigo utilicen el atajo de teclado ctrl + c + k
//Para descomentar codigo utilicen el atajo de teclado ctrl + k + u
//Para duplicar una linea utilicen el atajo ctrl + d\
//Para mover una linea con las flechitas del teclado pueden utilizar el atajo alt + flechitas arriba o abajo
//Para navegar por el codigo de manera horizontal pueden usar el atajo shift + ruedita del ratón

//Strings
//Console.WriteLine(class2.EnviarMensajeString());

//Datos numericos
//class2.DatosNumericos();

//Datos por referencia
//class2.DatosReferencia();

//Datos Listas y arreglos
//class2.ArreglosListas();

//Condicionales
//class2.Condicionales();

//Ciclos
//class2.Ciclos();

#endregion

#region Clase 3 del 22 de noviembre del 2025
/* 
 Objetivos de la clase
-Clases
-Objetos
-Constructores
-Métodos
-Propiedades
-Encapsulamineto básico
 */

//Persona 1 Axel Rivera
//Persona persona = new Persona(string.Empty, 0 ,0,0);
//Console.WriteLine(persona.Altura);
//Console.WriteLine(persona.Edad);
//Console.WriteLine(persona.Peso);
//Console.WriteLine(persona.NombreCompleto);

//persona.Altura = 1.71m;
//persona.Edad = 23;
//persona.Peso = 1.75m;
//persona.NombreCompleto = "Axel Rivera";
//double IMC = persona.CalcularIMC();
//Console.WriteLine($"El imc de {persona.NombreCompleto} es de: {IMC}");
//Console.WriteLine(persona.Altura);
//Console.WriteLine(persona.Edad);
//Console.WriteLine(persona.Peso);
//Console.WriteLine(persona.NombreCompleto);


////Persona2 Alex Rivera
//Persona persona2 = new Persona(string.Empty, 0, 0, 0);
//persona2.Altura = 168m;
//persona2.Edad = 23;
//persona2.Peso = 175m;
//persona2.NombreCompleto = "Alex Rivera";

//Console.WriteLine(persona2.Altura);
//Console.WriteLine(persona2.Edad);
//Console.WriteLine(persona2.Peso);
//Console.WriteLine(persona2.NombreCompleto);

//Console.WriteLine("\n \n \n");
//Console.WriteLine("===============================================================");

////Grupo de personas
//List<Persona> personas = new List<Persona>();

//Manera 1 de agregar a una lista del tipo de una clase
//Persona JuanCenteno = new Persona(string.Empty, 0, 0, 0);
//JuanCenteno.Altura = 1.65m;
//JuanCenteno.Edad = 24;
//JuanCenteno.Peso = 1.80m;
//JuanCenteno.NombreCompleto = "Juan Centeno";
//personas.Add(JuanCenteno);

//Persona EderSanchez = new Persona(string.Empty, 0, 0, 0);
//EderSanchez.Altura = 1.72m;
//EderSanchez.Edad = 24;
//EderSanchez.Peso = 1.70m;
//EderSanchez.NombreCompleto = "Eder Sanchez";
//personas.Add(EderSanchez);

//Manera 2 de agregar a una lista del tipo de una clase
//personas.Add(new Persona(string.Empty, 0, 0, 0) {NombreCompleto = "Eder Sanchez", Altura = 1.71m, Edad = 24, Peso = 1.70m });

// Recorrer las propiedades de la clase personas
//foreach (var item in personas)
//{
//    Console.WriteLine(item.NombreCompleto);
//    Console.WriteLine(item.Edad);
//    Console.WriteLine(item.Altura);
//    Console.WriteLine(item.Peso);
//    Console.WriteLine("\n");
//}

//Ejercicio
/*
Una clase Estudiante
Con propiedades: Nombre, Carrera, Promedio
Un método: MostrarInfo()
Un método: Aprobo() que retorne si aprobó (>=70)
*/

//dario.rivera@unah.hn
//<3
Console.ReadKey();

#endregion