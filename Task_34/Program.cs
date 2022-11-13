/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел: {count}");

void FillArrayNumbers(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
    {
        numbers[k] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
    {
        Console.Write(numbers[k] + " ");
    }
    Console.WriteLine();
}