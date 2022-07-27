/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Prim
{
    class Primo 
    {         
        static void Main()
        {
        	short y=0;
        	Console.Write("Informe o numero primo: ");
        	short.TryParse(Console.ReadLine(), out short x);
        	for(int i = x; i > 0; i--){
        		if(x%i == 0){
        			y++;
        		}
        	}
        	if(y == 2){
        		Console.Clear(); Console.WriteLine($"O numero {x} é um numero primo");
        	}else{
        		Console.Clear(); Console.WriteLine($"O numero {x} não é um numero primo");
        	}
        }
    }
}*/