/* Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
int[] array = GetArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]"); //разделитель элементов - символ ";" и символ " " (пробел)

int [] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100); // Можно было взять числа в промежутке от 0 до 2147483646, но взял до 99
    }
    return result;
}
