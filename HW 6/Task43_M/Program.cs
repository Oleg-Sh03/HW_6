// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

Intersection(k1, b1, k2, b2);
void Intersection(double a1, double d1, double a2, double d2)
{
if(a1 == a2 && d1 == d2) Console.WriteLine ("Прямые совпадают");
else if(a1 == a2 && d1 != d2) Console.WriteLine ("Прямые параллельны");
else Console.WriteLine ($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({(b2 - b1)/(k1 - k2)}; {(b2 - b1)/(k1 - k2) * k1 + b1})");
}