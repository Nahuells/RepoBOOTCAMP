/*Crea una estructura de datos para un cliente con estos campos:

Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente
 */
Coords misCoordenadas =new Coords("Nahuel lassos","1231564","nahuellassos@gmail.com","argentina asdasd","si");
Console.WriteLine("Nombre completo: " + misCoordenadas.X);
Console.WriteLine("Telefono: " + misCoordenadas.Y);
Console.WriteLine("Direccion: " + misCoordenadas.Z);
Console.WriteLine("Email: " + misCoordenadas.A);
Console.WriteLine("Eres nuevo cliente?: " + misCoordenadas.B);

//Coords misCoordenadas2 = misCoordenadas with { X = 5 };
//Console.WriteLine(misCoordenadas2);
public struct Coords
{
    public Coords(string x, string y, string z, string a, string b)
    {
        X = x;
        Y = y;
        Z = z;
        A = a;
        B = b;
    }

    public string X { get; set; }
    public string Y { get; set; }
    public string Z { get; set; }
    public string A { get; set; }
    public string B { get; set; }


    public override string ToString() => $"({X}, {Y}, {Z}, {A}, {B})";
}
