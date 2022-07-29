/*using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace Retorno
{
    class Yield 
    {         
        static void Main()
        {
        	WriteLine("Antes de chamar o Foo...");
        	var foo = Foo();
        	WriteLine("Depois de chamar o Foo...");
        	
        	foreach(var elem in foo){
        		WriteLine($"Antes de Imprimir o elem {elem}...");
        		WriteLine(elem);
        		WriteLine($"Depois de Imprimir o elem {elem}...");
        	}
        }
        static IEnumerable<int> Foo()
        {
        	WriteLine("Antes de iniciar o loop for...");
        	for(int i = 0; i < 4; i++){
        		WriteLine($"Antes do yield return {i}...");
        		yield return i;
        		WriteLine($"Depois do yield return {i}...");
        	}
        	WriteLine("Depois de Encerrar o loop for...");
        }
    }
}*/