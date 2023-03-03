// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number");
int ViewerNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[new Random().Next(5,6), new Random().Next(5,6)];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");
        }
    }   
}

void Viewer(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == ViewerNumber)
            {
                Console.WriteLine($"Element is taking is on: {i}, {j}");
            }
            else
            {
                count++;
            }
        }
    }
    
    if (count == array.GetLength(0)*array.GetLength(1));
    Console.WriteLine("There is no such element");
}

FillArray(array);
Console.WriteLine();
Viewer(array);
