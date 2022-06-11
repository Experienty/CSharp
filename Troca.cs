/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Vet
{
    public class Troca 
    {         
        static void Main()
        {
        	int temp;
        	int[] N = new int[20];
        	for(int i = 0; i <= 19; i++){
        		Console.Write("digite um numero e sempre aperte enter de 1 até 20: ");
        		N[i] = Convert.ToInt32(Console.ReadLine());
        		Console.Clear();
        	}
        	for(int i = 0; i <= 9; i++){
        		temp = N[i];
        		N[i] = N[19 - i];
        		N[19 - i] = temp;
        	}
        	for(int i = 1; i <= 19; i++){
        		Console.WriteLine($"N[{i}] = {N[i]}\n");
        	}
        }
    }
}*/