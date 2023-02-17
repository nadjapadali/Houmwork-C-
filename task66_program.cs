static int SumRec(int M, int N)
{
    if (M >= N) return N;
    else return N + SumRec(M, N - 1);
}
Console.Write(SumRec(5,6));