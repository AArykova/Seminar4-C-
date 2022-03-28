// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

Random rnd = new Random();
int kol = 8;
int[] array = new int[kol];
FillArr();
PrintArr();
NewArr();
PrintArr();

void FillArr()
{
    for (int i = 0; i < kol; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
}
void PrintArr()
{
    for (int i = 0; i < kol; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
void NewArr()
{
    int temp = 0;
    int index = 0;

    for (int i = 0; i < kol; i++)
    {
        index = i;
        for (int j = i; j < kol; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[index]))
            {
                index = j;
            }
        }
        if (index != i)
        {
            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
}
