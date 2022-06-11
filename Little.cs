/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Menor
{
    public class Little 
    {         
        static void Main()
        {
        	Console.Write("digite a quantidade de posições do array: ");
        	int.TryParse(Console.ReadLine(), out int N);
        	int[] x = new int[N];
        	int menor, pos;
        	x[0] = int.Parse(Console.ReadLine());
        	menor = x[0];
        	pos = 0;
        	for(int i = 1; i < N; i++){
        		Console.WriteLine("digite a proxima sequencia: ");
        		x[i] = int.Parse(Console.ReadLine());
        		if(x[i] < menor){
        			menor = x[i];
        			pos = i;
        		}
        	}
        	Console.Clear();
        	Console.Write($"Menor Valor: {menor} ");
        	Console.WriteLine($"Posição: {pos}");
        }
    }
}*/