// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число А, возведённое в степень В равно:");
Console.WriteLine(expon_(number1, number2));

int expon_(int num1, int num2)
{
    int exp = num1;
    for (int i=2; i<=num2; i++)
{
    exp = exp*num1;
}
return exp;
}