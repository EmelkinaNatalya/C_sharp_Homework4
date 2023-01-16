// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

int summa_(int num1)
{
    int num2 = num1%10;
    num1 = num1/10;
    int sum = num2;
    
    while (num1>9) 
    {
        num2 = num1%10;
        num1 = num1/10;
        sum = sum + num2;
    }
    sum = sum + num1;
    return sum;
}

Console.WriteLine(summa_(number1));