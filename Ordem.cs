/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Crescente
{
    class Ordem 
    {         
        static void Main()
        {
        	Console.Write("Imforme o valor 1: ");
        	int.TryParse(Console.ReadLine(), out int v1);
        	Console.Write("Imforme o valor 2: ");
        	int.TryParse(Console.ReadLine(), out int v2);
        	Console.Write("Imforme o valor 3: ");
            int.TryParse(Console.ReadLine(), out int v3);
        	int aux;
        	if(v1 > v2){
        		aux = v1;
        		v1 = v2;
        		v2 = aux;
        	}
        	if(v1 > v3){
        		aux = v1;
        		v1 = v3;
        		v3 = aux;
        	}
        	if(v2 > v3){
        		aux = v2;
        		v2 = v3;
        		v3 = aux;
        	}
        	Console.Clear();Console.WriteLine($"Valores Ordenados: {v1} {v2} {v3}");
        }
    }
}*/