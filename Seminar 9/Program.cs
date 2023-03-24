Console.Clear();
Console.WriteLine("1 - Task 66");
Console.WriteLine("2 - Task 64");
Console.WriteLine("3 - Task 68");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task66();
    break;

    case 2:
    Console.Clear();
    Task64();
    break;

    case 3:
    Console.Clear();
    Task68();
    break;

    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
}
    static int Prompt(string message)//метод запроса числа
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task66()
{ // Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

{
    Console.WriteLine(FinfSumAllElements(Prompt("Enter first number"),Prompt("Enter second number")));
    Console.ReadLine();
}

int FinfSumAllElements(int firstnum, int secondnum)
{
    if (firstnum == secondnum) return firstnum;
    return firstnum + FinfSumAllElements(firstnum + 1, secondnum);
}

  

}

static void Task64()
{ 
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int n)
{
    if (n == 1) return 1;
    Console.Write($"{n}, ");
    return PrintNumbers(n-1);
}

System.Console.WriteLine(PrintNumbers(n));

} 

static void Task68()
{ 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine("Input minimal number: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
System.Console.WriteLine(Ackermann(m,n));


}