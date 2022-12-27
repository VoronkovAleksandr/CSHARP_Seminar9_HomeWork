// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumberRec(int n, int m)
{
    int temp = 0;
    if (n > m)
    {
        temp = m;
        m = n;
        n = temp;
    }
    int sum = 0;
    if (m == n) return n;
    else return sum = n + (SumNumberRec(n+1, m));

}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int n = Convert.ToInt32(DataEntry("Введите первое число: "));
int m = Convert.ToInt32(DataEntry("Введите второе число: "));
Console.WriteLine(SumNumberRec(n, m));
