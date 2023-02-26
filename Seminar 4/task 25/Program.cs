// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


#region 
int b = Prompt();

int Prompt()
{
    Console.WriteLine("Input number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;

}
#endregion

