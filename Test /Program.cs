  static int Prompt(string message)//метод запроса числа
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

    Console.WriteLine(FinfSumAllElements(Prompt("Enter first number"),Prompt("Enter second number")));
    Console.ReadLine();


int FinfSumAllElements(int firstnum, int secondnum)
{
    if (firstnum == secondnum) return firstnum;
    return firstnum + FinfSumAllElements(firstnum + 1, secondnum);
}
