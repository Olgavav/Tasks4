// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rand.Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }

}
