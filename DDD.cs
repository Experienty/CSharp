/*using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    public class D 
    {         
        static void Main()
        {
        	inicio:
        	Console.Write("Informe o DDD: ");
        	int.TryParse(Console.ReadLine(), out int DDD);
        	Console.Clear();
        	if(DDD == 61){
        		Console.WriteLine("Brasilia");
        	}else if(DDD == 71){
        		Console.WriteLine("Savador");
        	}else if(DDD == 11){
        		Console.WriteLine("São Paulo");
        	}else if(DDD == 21){
        		Console.WriteLine("Rio de Janeiro");
        	}else if(DDD == 32){
        		Console.WriteLine("Juiz de Fora");
        	}else if(DDD == 19){
        		Console.WriteLine("Carpina");
        	}else if(DDD == 27){
        		Console.WriteLine("Vitoria");
        	}else if(DDD == 31){
        		Console.WriteLine("Belo Horizonte");
        	}else{
        		Console.Clear();
        		Console.WriteLine("DDD não Cadastrado Pressione qualquer tecla para continuar..");
        		Console.ReadKey();
        		Console.Clear();
        	}
        	Erro:
        	char Escolha;
        	Console.WriteLine("Deseja digitar um novo DDD: y or n? ");
        	Escolha = char.Parse(Console.ReadLine());
        	switch(Escolha){
        		case 'y':
        		   Console.Clear();
        		   goto inicio;
        		   break;
        		case 'n':
        		   Console.Clear();
        		   Console.WriteLine("Exit");
        		   break;
        		default:
        		   Console.Clear();
        		   Console.WriteLine("Erro Opção não informada");
        		   Console.ReadKey();
        		   Console.Clear();
        		   goto Erro;
        		   break;
        	}
        }
    }
}*/