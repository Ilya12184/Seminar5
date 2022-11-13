/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
SumArrayNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);

int sum = 0;
for (int k = 0; k < numbers.Length; k++)
{
    if (k % 2 != 0)
    {
        sum += numbers[k];
    }
}

Console.WriteLine($"Сумма элементов нечетных позиций: {sum}");

void SumArrayNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10,11);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}