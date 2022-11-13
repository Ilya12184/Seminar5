/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементами массива.*/

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
DifArrayNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);

double maxim = numbers[0];
double minim = numbers[0];
for (int k = 0; k < numbers.Length; k++)
{
    if (numbers[k] > maxim)
    {
        maxim = numbers[k];
    }
    if (numbers[k] < minim)
    {
        minim = numbers[k];
    }
}
Console.WriteLine($"Разница между макс и миним элементами массива: {maxim-minim}");

void DifArrayNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10,11);
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
