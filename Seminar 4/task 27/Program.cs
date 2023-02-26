// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt()
{
    Console.WriteLine("Input number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;

}
int Sum()
{
    int b = Prompt();
    int result = 0;
    
    while (b > 0)
    {
        result += (b%10);
        b /= 10;

    }
    return result;
}
Console.WriteLine(Sum());