Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CompareWithZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int[] myArray = CreateArray(m);
Console.WriteLine("Из ряда");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"пользователь ввел чисел '> 0' {CompareWithZero(myArray)}.");
