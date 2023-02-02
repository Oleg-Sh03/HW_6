// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива (натуральное число M): ");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 0)
{
int[] array = Create(n, -1000, 1000);
int[] Create(int size, int min, int max)
{
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine("Введите число от -1000 до 1000: ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

PrintArray(array);
void PrintArray (int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
}


int summaPozitiveNumber = SummaPozitiveNumber(array);
Console.WriteLine($" -> {summaPozitiveNumber}");

int SummaPozitiveNumber(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
if(arr[i] > 0) sum += 1;
}
return sum;
}
}
else
{
    Console.WriteLine("Не существует");
}