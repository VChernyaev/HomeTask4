// программа, которая принимает на вход число и выдаёт сумму цифр в числе 
System.Console.WriteLine("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int score = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        score = number - number % 10;
        result = result + (number - score);
        number = number / 10;
    }
    return result;


}
 int Sum = SumNumber(num);
 System.Console.WriteLine($"Cумма всех чисел в числе {Sum}");