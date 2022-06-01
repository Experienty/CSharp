/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Entrada
{
    public class Args 
    {   //Exemplo do "string[] args"  abaixo   
        static void Main(string[] args)
        {
        	int res = 0;
        	if(args.Length > 0){
        		Console.WriteLine($"Quantidade de Argumentos: {args.Length}");
        		for(int i = 0; i < args.Length; i++){
        			res += Int32.Parse(args[i]);
        			Console.WriteLine("Argumentos: {0} {1}", i, args[i]);
        		}
        		Console.WriteLine($"A soma é: {res}");
        	}else{
        		Console.WriteLine("Não Foi Passado Argumentos");
        	}
        }
    }
}*/