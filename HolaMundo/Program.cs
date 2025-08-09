string nombre;
int edadInt = 0;
int añoActual = DateTime.Now.Year;
bool edadInvalida = true;

Console.WriteLine("Introduce tu nombre, por favor:");
nombre = Console.ReadLine();
while (edadInvalida)
{
    try
    {
        string edad;
        Console.WriteLine("Introduce tu edad, por favor:");
        edad = Console.ReadLine();
        edadInt = Convert.ToInt32(edad);
        
        edadInvalida = false;
    } 
    catch (FormatException e)
    {
        Console.WriteLine("La edad la tienes que poner de forma entera, sin decimales o letras.");
    }
}

int cien = 100 - edadInt;
int añoCien = añoActual + cien;

Console.WriteLine("¡Hola, " + nombre + "!");
Console.WriteLine("Asi que tienes " + edadInt);
Console.WriteLine("Por cierto, cumpliras los 100 en el año " + añoCien);