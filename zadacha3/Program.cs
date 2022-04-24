int count = 0, max = 0, min = 0;
int i = 0;
int[] array = new int[100];
Random rnd = new Random();

Console.WriteLine("Количество элементов: ");
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  значения элементов массива: ");
max = Convert.ToInt32(Console.ReadLine());
min = Convert.ToInt32(Console.ReadLine());

if (min > max) 
{
    i = max;
    max = min;
    min = i;
}
i = 0;

Console.WriteLine("массив: ");
genArray(count, min, max);

void genArray(int N, int minimum, int maximum) 
{ 
    for (i = 0; i <= N; i++) 
    {
        array[i] = rnd.Next(minimum, maximum);
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();
