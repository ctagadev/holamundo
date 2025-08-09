string nombre;
int edadInt = 0;
int añoActual = DateTime.Now.Year;
bool edadInvalida = true;

Console.WriteLine("Introduce tu nombre, por favor:");
nombre = Console.ReadLine();
// Control de errores en el dato de edad, solo se permite un entero, nada de decimales o letras.
while (edadInvalida)
{
    try
    {
        string edad;
        Console.WriteLine("Introduce tu edad, por favor:");
        edad = Console.ReadLine();
        edadInt = Convert.ToInt32(edad); // Convertimos la entrada de texto en entero para poder operar con él.

        edadInvalida = false; // Si el dato es correcto, seguimos ejecutando el programa.
    } 
    catch (FormatException e)
    {
        Console.WriteLine("La edad la tienes que poner de forma entera, sin decimales o letras.");
    }
}

int cien = 100 - edadInt; // Hacemos el cálculo inicial para restar la edad.
int añoCien = añoActual + cien; // Usando el resultado anterior, sacamos cuando se cumplen los 100.

Console.WriteLine("¡Hola, " + nombre + "!");
Console.WriteLine("Asi que tienes " + edadInt);
Console.WriteLine("Por cierto, cumpliras los 100 en el año " + añoCien);