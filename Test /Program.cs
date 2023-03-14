System.Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int n)
{
    if (n == 1) return 1;
    Console.Write($"{n}, ");
    return PrintNumbers(n-1);
}

System.Console.WriteLine(PrintNumbers(n));