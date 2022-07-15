int Cupon=2;
string nombre;
string email;
double precio = 500;
double preciocondescuento;
Console.WriteLine("Ingrese Su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Igrese su email");
email = Console.ReadLine();
Console.WriteLine("Tiene un cupon: 1-Si 2-NO");
Cupon = Convert.ToInt32(Console.ReadLine());
if(Cupon == 1)
{

        preciocondescuento = precio - precio * 0.15;
        Console.WriteLine("El precio Con cupon sera de: $" + preciocondescuento);


}
else
{
    Console.WriteLine("El precio sera de: $" + precio);
}

int lenguaje;
Console.WriteLine("Selecciona un  lenguaje de programacion 1-C# 2-Java 3-C++");
lenguaje =Convert.ToInt32( Console.ReadLine()); 

switch (lenguaje)
{
    case 1 :
        Console.WriteLine("Hola Mundo");
        break;
    case 2 :
        Console.WriteLine("Las iniciales de los nombres de sus creadores James Gosling, Arthur Van Hoff, y Andy Bechtolsheim forman JAVA");
        break ;
    case 3 :
        Console.WriteLine(" C++ significa incremento de C");
        break;
      Default:
        Console.WriteLine("No seleccionaste ningun lenguaje");
        break;
}

