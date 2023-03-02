// See https://aka.ms/new-console-template for more information
static void Task36()
{ //Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0З

    Console.WriteLine("Input lenght array");
    int lenght = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[lenght];
    int sum = 0;

    int [] RandomNumbersArray()
    {   
        int [] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,101);
    }
    return arr;

    }
   void SumNotEvenNum(int[] arr)
   {
    foreach (int el in array)
    {
        if (el % 2 !=0)
        {
            sum ++;
        }
        else
        {
            Console.WriteLine("We don't need even numbers");
        }

        

    }
   }
    
    void PrintResult(int[] arr, int sum)
    {
    Console.WriteLine($"Array result is {String.Join(" ", array)}");//Join помогает вывести массив в читаемой форме через разделитель, здесь разделитель 
    Console.Write($" Sum of not even numbers {sum}");
    
    }


    array = RandomNumbersArray();
    SumNotEvenNum(array);
    PrintResult(array, sum);
}