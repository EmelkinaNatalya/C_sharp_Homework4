// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] Array = CreateRandomArray(8, -100, 100);

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
Console.WriteLine($" [ {String.Join(", ", Array)} ] ");