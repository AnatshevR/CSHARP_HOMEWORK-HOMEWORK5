//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("enter 4 digits ");
int k1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);
int k2 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);

int x = (b1-b2)/(k1-k2);
int y = k1*x +b1;

Console.WriteLine("the point of interception has this coordinates: " + "x= " + x + "; y= " + y);
