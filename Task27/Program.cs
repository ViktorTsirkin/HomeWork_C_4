/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSum(num)}"); 
int GetSum(int num) 
{
    int sum = 0; 
    for(int i = num; i > 0; i = i / 10) 
    {
        sum = sum + i % 10; 
        
    }
    return sum; 
}