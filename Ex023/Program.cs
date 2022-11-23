// Задача 23
//Напишите программу, которая принимает на вход число (Num) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Num; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}