string nombre;
string edad;
int edadInt;

Console.WriteLine("Introduce tu nombre, por favor:");
nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad, por favor:");
edad = Console.ReadLine();
edadInt = Convert.ToInt32(edad);

Console.WriteLine("¡Hola, " + nombre + "!");
Console.WriteLine("Asi que tienes " + edadInt);