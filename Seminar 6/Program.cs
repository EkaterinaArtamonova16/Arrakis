// See https://aka.ms/new-console-template for more information
int[,] array = new int[new Random().Next(2,10), new Random().Next(2,10)];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,11);
            Console.WriteLine(array[i,j] + " ");
        }
    }
}

void Explorer(int[,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j <array.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0)
            array[i,j] *= array[i,j];
            Console.Write(array[i,j] + " ");

        }
        

    }
}
FillArray(array);
Console.WriteLine();
Explorer(array);