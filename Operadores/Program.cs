/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
  usa una variable para cada dato y otra para el mensaje. 
  Ej: nombre, apellido, edad, sabe programar, etc.

Console.WriteLine("Introdcue tu nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Introdcue tu apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Introdcue tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hola " + nombre +" "+ apellido + ", tienes " + edad+" años.");
*/

/*Usando los tipos de variables más adecuados, describe los objetos siguientes:
   Coche: puertas, ruedas, marca, ITV vigente
   Mesa: peso, largo, material, color
 */

/*
Console.WriteLine("Describa la cantidad de puertas de un coche promedio:");
int cantidadPuertas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cuantas ruedas tiene?:");
int cantidadRuedad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qué marca es?:");
string marca = Console.ReadLine();


Console.WriteLine("Cual es el peso de la mesa de su casa?:");
int pesoMesa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qué largo tiene?:");
int largoMesa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("De que material es?:");
string materialMesa = Console.ReadLine();
*/

/*Operadores Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18
Un char es ‘a’
Se cumplen dos conciones a la vez (ambas verdaderas)
Se cumple una de dos condiciones a la vez (una true y otra false)
 */
int numero = 18;
char letra = 'a';
int numero2 = 2;

Console.WriteLine(numero >= 18);
Console.WriteLine(letra == 'a');
Console.WriteLine(numero2 == 2 && numero2 == 2);
Console.WriteLine(numero2 == 2 && numero2 == 3);

