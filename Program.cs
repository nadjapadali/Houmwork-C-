static int Acker(int n,int m)
{
    if (n==0)
      return m+1;
    else
        if((n!=0)&&(m==0))
          return Acker(n-1,1);
          else
            return Acker(n-1,Acker(n,m-1));
}    
Console.Write(Acker(2,5));


