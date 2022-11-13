/*Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число 
в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.*/

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
SearchArrayNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);
Console.Write("Введите значение: ");
int meaning = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == meaning)
    {
        Console.WriteLine($"Индекс введенного значения: {i}");
        count ++;
    }
    else if (i == numbers.Length-1 & count == 0)
    {
    Console.WriteLine(-1);
    }
}

void SearchArrayNumbers(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
    {
        numbers[k] = new Random().Next(-100,101);
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