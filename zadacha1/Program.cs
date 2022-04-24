Console.WriteLine("Введите число и степень: ");
int number = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number + " в " + pow + " степени = " + userPow(number, pow));
static int userPow(int number, int deg) 
{
    int result = 1;
    for (int i = 1; i <= deg; i++) 
    {
        result = result * number;
    }
    return result;
}
