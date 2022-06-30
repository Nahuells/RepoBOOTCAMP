/*Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón descuento.
Muestre un precio rebajado en función del cupón descuento.
Muestre el precio de un producto sin descuento si no hay cupón.
 * LOS CUPONES TIENE %50
 * TV:$1200
 */

/*
Console.WriteLine("Tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("email: ");
Console.ReadLine();
Console.WriteLine("Tiene cupon con descuento?: ");
string cupon = Console.ReadLine();
double descuentoCupon = 0.4;
int tv = 1200;
double descuentoProducto = 0;
double total = 0;
if (cupon == "si")
{
    descuentoProducto = tv * descuentoCupon;
    total = tv - descuentoProducto;
    Console.WriteLine("Su producto con descuento es de " + total);
}
else
{
    Console.WriteLine("Su producto no tiene descuento, su precio es de "+tv);
}
*/

/*
 * Haz una lista de lenguajes de programación
 por ejemplo: C#, Java, C++.
 Presenta la lista en consola y pide que el usuario seleccione el lenguaje 
 mediante 1, 2, 3 o a, b, c. 
 Presenta el resultado en consola.
 */
Console.WriteLine("Que lenguaje prefiere usar:\n1 para: C#\n2 para: Java\n3 para: C++");
int seleccionDeLenguaje = Convert.ToInt32(Console.ReadLine());
switch(seleccionDeLenguaje)
{
    case 1:
        Console.WriteLine("Se usara C#.");
    break;
    case 2:
        Console.WriteLine("Se usara Java.");
    break;
    case 3:
        Console.WriteLine("Se usara C++.");
    break;
}


