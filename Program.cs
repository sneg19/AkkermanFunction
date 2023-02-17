// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akk(int n, int m)
{
    if(n==0) return m+1;
    if(n!=0 && m==0) return Akk(n-1,1);
    if(n>0 && m>0) return Akk(n-1, Akk(n, m-1));
    return Akk(n, m);
}

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"M = {m}, N = {n} -> A(m, n) = {Akk(m, n)}");
}

Main();