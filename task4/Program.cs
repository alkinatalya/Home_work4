// Напишите программу, которая задаёт массив из 8 элементов случайными 
// числами и выводит их на экран. Также ищет второй максимум (число 
// меньше максимального элемента, но больше всех остальных)
//8 1 2 4 4 5 3 1 -> 5
//1 2 6 9 8 1 1 1 -> 8
//2 1 2 1 1 1 1 1 -> 1
//1 2 1 2 1 1 1 1 -> 1
//1 2 3 4 5 6 7 8 -> 7
//1 2 3 4 5 6 8 7 -> 7 
int[] Create(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void DisplayArray(int[] array)
{
        int second_max = 0;
        int first_max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
        if (array[i] > array[second_max])
        {
            if (array[i] > array[first_max])
            {
                second_max = first_max;
                first_max = i;
            }
            else
            {
                second_max = i;
            }
        }
    }
    System.Console.WriteLine();
    System.Console.Write($"second_max={array[second_max]}");
    System.Console.WriteLine();
    System.Console.Write($"first_max={array[first_max]}");
    System.Console.WriteLine();
}
int[] array = Create(8);
DisplayArray(Create(8));