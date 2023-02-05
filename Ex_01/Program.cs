// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("Введите коэф. b1 для уравнения прямой y = k1 * x + b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите коэф. k1 для уравнения прямой y = k1 * x + b1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите коэф. b2 для уравнения прямой y = k2 * x + b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите коэф. k2 для уравнения прямой y = k2 * x + b2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

Console.WriteLine("Нам даны две прямые, заданные уравнениями:");
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

double temp1 = k1 * b2 - k2 * b1;
double y = temp1 / (k1 - k2);

double temp2 = y - b1;
double x = temp2 / k1;

Console.WriteLine($"Точка пересечения указанных прямых имеет координаты ({x}; {y})");

