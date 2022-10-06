//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
Console.Clear();
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}

int Sum(int N)

{
    int Summa = 0;
    while(Math.Abs(N) > 0)
    {
        int digit = N  % 10;
        Summa = Summa + digit;
        N = N / 10;
    }
    return Summa;
}
Console.WriteLine($"Сумма чисел  = {Sum(GetNumber())}");