using System;
using System.Linq;
using System.Collections.Generic;

namespace Tem
{
    public class Dez 
    {         
        static void Main()
        {
        	double soma = 0;
        	int s,t,v,r;
        	Console.Write("digite o primeiro numero: ");
        	int.TryParse(Console.ReadLine(), out int x);
        	Console.Clear();
        	Console.Write("digite o segundo numero: ");
        	int.TryParse(Console.ReadLine(), out int y);
        	Console.Clear();
        	
        	if(x == 10 && y == 10){
        		s = x << 1;
        		t = y >> 1;
        		v = s + t;
        		r = s - t;
        		soma = v / r;
        		Console.WriteLine($"A soma das variaveis são: {soma:f1}");
        	}else{
        		if(x != 10 || y != 10){
        			soma = x * y;
        			Console.WriteLine($"A Multiplicação dos valores são: {soma}");
        		}
        	}
        }
    }
}