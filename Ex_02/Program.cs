// Написать программу масштабирования фигуры

Console.Write("Введите кол-во вершин фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "");

int[] arr_x = new int[count];

int[] arr_y = new int[count];

Console.WriteLine("Ниже представлены координаты вершин фигуры на плоскости:");

for (int i = 0; i < count; i++)
{
    arr_x[i] = new Random().Next(11);
    arr_y[i] = new Random().Next(11);
    Console.WriteLine($"Вершина № {i+1} имеет координаты ({arr_x[i]};{arr_y[i]})");
}

Console.Write("Введите коэффициент масштабирования k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ниже представлены координаты вершин фигуры на плоскости после изменения масштаба фигуры согласно коэффициенту k:");

for (int i = 0; i < count; i++)
{
    arr_x[i] = arr_x[i] * k;
    arr_y[i] = arr_y[i] * k;
    Console.WriteLine($"Вершина № {i+1} имеет координаты ({arr_x[i]};{arr_y[i]})");
}