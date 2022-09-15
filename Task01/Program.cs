// программа котора принимает на вход два числа (А и B) 
// и возводит число A в натуральную степень B
Console.WriteLine("Введите число A ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int NumberB = Convert.ToInt32(Console.ReadLine());

int exponent (int num1, int num2)
{
    int result = num1;
    for (int i=1; num2>i; i++)
    {
       result  = result*num1;
    }
    return result;
}    
 Console.WriteLine($"{NumberA} в степени {NumberB} равно {exponent(NumberA, NumberB)}");  
