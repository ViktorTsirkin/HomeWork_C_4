/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetDeg(A,B)}");
int GetDeg(int A, int B) 
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

/* В 11 строке можно было написать просто:
Console.WriteLine($"Число {A} в степени {B} равно {Math.Pow(A, B)}");
И удалить оставшийся код. Получается тот же результат, но без использования метода
*/