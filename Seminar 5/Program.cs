// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("1 - task 34");
Console.WriteLine("2 - task 36");
Console.WriteLine("3 - task 38");

int NumberOfTask = int.Parse(Console.ReadLine());
switch (NumberOfTask)
{
    //case 1:
       //Task34();
       //break;
    //case 2:
       //Task36();
       //break;
    case 3:
       Task38();
       break;
}

static void Task38()
{
    // Задача 38: Задайте массив вещественных чисел. (в задаче массив из целыч чисел)
    //Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76

    Console.WriteLine("Input array length");
    int lenght = int.Parse(Console.ReadLine());
    int[] array = new int[lenght];

    int [] GetRandomArray()
    {
        int[] arr = new int[lenght];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0,101);
        }
        return arr;
    }
    
    void PrintResult(int[] arr)
    {
        Console.WriteLine($"Array result is {String.Join(" ", array)}");
    }

    void DifferenceMaxMin(int[] array)
    {
        int max = array[0];
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
           if (array[i] > max) 
           max = array[i];
           else if (array[i] < min)
           min = array[i];
        }
        Console.WriteLine($"The difference between {max} and {min} is {max-min}");
    }
    
    array = GetRandomArray();
    PrintResult(array);
    DifferenceMaxMin(array);
}
