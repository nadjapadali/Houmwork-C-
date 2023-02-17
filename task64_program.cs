
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{NumRec(N)}");


string NumRec(int N)
{
    if (N == 0) return "";
    return " " + N +  NumRec(N-1);
}

