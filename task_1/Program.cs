using System;

void RecNum(int M,int N){
    if (M>0 & M<N+1){
        Console.Write($"{M}\t");
        RecNum(M+1, N);
    }
}
Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
RecNum(M,N);