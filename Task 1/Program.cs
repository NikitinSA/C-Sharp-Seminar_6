/*Вывод массива на экран в обратном порядке*/

Console.Write("Введи размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int count = 1;

void PrintArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

void PrintArrayRevers(int[] arr, int count)
{
    for (int i = 0; i < arr.Length; i++)
    {
        while (count <= size)
        {
            Console.Write($"{arr[^count]} "); // Вывод через счетчик. Когда count = 1 выводится последний элемент массива.
            count++;
        }
    }
}

PrintArray(arr, size);
Console.WriteLine();
PrintArrayRevers(arr, count);