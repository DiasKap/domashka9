using System;
using static System.Console;
Clear();
Write("Число M: ");
int m = int.Parse(ReadLine());
Write("Число N: ");
int n = int.Parse(ReadLine());
Write(Akk(m,n));
int Akk(int m,int n)
{
    if (m==0){
        return n+1;    }
    else if (n==0 && m>0){
        return Akk(m-1,1);    }
    else{
        return (Akk(m-1,Akk(m,n-1)));    }
}