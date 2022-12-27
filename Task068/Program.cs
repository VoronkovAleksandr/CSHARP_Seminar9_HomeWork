// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m>0 && n == 0) return Ackerman(m-1,1);
    else return Ackerman(m-1,Ackerman(m,n-1));
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int m = Convert.ToInt32(DataEntry("Введите число m: "));
int n = Convert.ToInt32(DataEntry("Введите число n: "));
Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");
