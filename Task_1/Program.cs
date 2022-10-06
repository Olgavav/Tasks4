//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите первое число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число B: ");
int B = int.Parse(Console.ReadLine()!);
int rezult = Stepen();
Console.WriteLine("A в степени B = " + rezult);

int Stepen ()
{
    int step = 1;
    for (int i = 0; i < B; i++)
    {
        step = step * A;
    }
    return step;
}