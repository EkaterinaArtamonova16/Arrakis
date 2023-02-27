// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// #region 
//

int Base = 1;
int Exponent = 1;
int power = 1;

void ReadLine(ref int Base, ref int Exponent)
{
    Console.WriteLine("Input number for exponential ");
    Base = int.Parse(Console.ReadLine());
    Console.WriteLine("Input number for exponent ");
    Exponent = int.Parse(Console.ReadLine());
}
int Power(int Base, int Exponent, ref int power)
{
    for (int i = 0; i < Exponent; i++)
    {
        power *= Base;
    }
    return power;
}

void Validate(int Base, int Exponent, int power)
{
    if (Exponent < 0)
    
        Console.WriteLine("Input wrong exponent");
    else

        Console.WriteLine($"Input base number: {Base}, input exponent: {Exponent}. Result is {power}");
    
    
}
ReadLine(ref Base, ref Exponent);
Power(Base, Exponent, ref power);
Validate(Base, Exponent, power);



