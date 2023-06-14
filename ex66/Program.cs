// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalElements(int min, int max)
{
    if (max == min) return min;
    else return max + SumNaturalElements(min, max - 1);
}

int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNaturalElements(min, max));