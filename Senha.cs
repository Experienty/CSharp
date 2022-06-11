/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Permitir
{
    public class Senha
    {         
        static void Main()
        {
        //Exemplo exercicio de senha com Metodo
        	int senha(int x){
        		if(x == 2002){
        			return 1;
        		}else{
        			return 0;
        		}
        	}
        	inicio:
        	Console.Write("digite a Senha: ");
        	while(int.TryParse(Console.ReadLine(), out int N)){
        		if(senha(N) == 1){
        			Console.Clear();
        			Console.WriteLine("Acesso Permitida");
        			break;
        		}else{
        			Console.Clear();
        			Console.WriteLine("Senha Invalida\n");
        			Console.WriteLine("Aperte qualquer teclar para continuar tentando...");
        			Console.ReadKey();
        			Console.Clear();
        			goto inicio;
        		}
        	}
        }
    }
}*/