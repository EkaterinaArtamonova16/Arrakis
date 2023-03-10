Console.Clear();
Console.WriteLine("1 - Task 66");
Console.WriteLine("2 - Task 68");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task66();
    break;

    //case 2:
    //Console.Clear();
    //Task68();
    //break;

    //case 3:
    //Console.Clear();
    //Task38();
    //break;

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

//static void Task68()
{ //Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n. 
//m = 2, n = 3 -> A(m,n) = 29

static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

} 
