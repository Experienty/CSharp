/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Perfect
{
    public class Numbers 
    {         
        static void Main()
        {
        	Console.Write("digite o numero: ");
        	int.TryParse(Console.ReadLine(), out int x);
        	Console.Clear();
        	int metade = x/2, y = 1, soma = 0;
        	
        	while(y <= metade){
        		if(x%2 == 0){
        			soma += y;
        		}
        		y++;
        	}
        	if(soma.Equals(x)){
        		Console.WriteLine($"o numero {x} é perfeito");
        	}else{
        		Console.WriteLine($"o numero {x} Não é perfeito");
        	}
        }
    }
}*/