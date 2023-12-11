using System;
using System.ComponentModel;
int N = 10;
Random rnd = new Random();
int [] mas = new int[N];
for (int i=0;i<N;i++){
    mas[i] = rnd.Next(-100,100);
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();
void RecurcMas(int[] mas, int i){
    if(i > 0){
        Console.Write($"{mas[i]}\t");
        RecurcMas(mas, i-1);
    }else{
        return;
    }
}
RecurcMas(mas,N-1);