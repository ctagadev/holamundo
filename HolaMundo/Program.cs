string nombre;
string edad;
int edadInt;
int añoActual = DateTime.Now.Year;

Console.WriteLine("Introduce tu nombre, por favor:");
nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad, por favor:");
edad = Console.ReadLine();

edadInt = Convert.ToInt32(edad);

int cien = 100 - edadInt;
int añoCien = añoActual + cien;

Console.WriteLine("¡Hola, " + nombre + "!");
Console.WriteLine("Asi que tienes " + edadInt);
Console.WriteLine("Por cierto, cumpliras los 100 en el año " + añoCien);