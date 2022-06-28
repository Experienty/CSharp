/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Consecutivos
{
	class S
	{
		//Usando Metodo Para Resolver o Problema
		protected static int Result(int x, int y)
		{
			int res = 0;
			if(x < y){
				for(int i = x+1; i < y; i++){
					if(i%2 != 0){
						res += i;
					}
				}
			}else{
				for(int i = y+1; i < x; i++){
					if(i%2 != 0){
						res += i;
					}
				}
			}
			return res;
		}
	}
    class Pro:S
    { 
    	static void Main()
    	{
            Console.Write("digite o valor de x: ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Clear();
            Console.Write("digite o valor de y: ");
            int.TryParse(Console.ReadLine(), out int y);
            Console.Clear();
            /*int soma = 0;
            if(x < y){
            	for(int i = x+1; i < y; i++){
            		if(i%2 != 0){
            			soma += i;
            		}
            	}
            }else{
            	for(int i = y+1; i < x; i++){
            		if(i%2 != 0){
            			soma += i;
            		}
            	}
            }
            Console.WriteLine(soma);*
            Console.WriteLine(S.Result(x,y));
    	}
    }
}*/