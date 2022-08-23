/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Opcoes
{
    public class Menu
    {         
        static void Main()
        {
        	Console.WriteLine("******************");
        	Console.WriteLine("* Menu de Opções *");
        	Console.WriteLine("******************");
        	Console.WriteLine("   1 - Pastel");
        	Console.WriteLine("   2 - Coxinha");
        	Console.WriteLine("   3 - Sorvete");
        	Console.WriteLine("   4 - Acai");
        	Console.WriteLine("******************\n");
        	Console.Write("Escolha uma Opçãos: ");
        	short.TryParse(Console.ReadLine(), out short M);
        	Console.Clear();Console.Write("imforme a quantidade: ");
        	short.TryParse(Console.ReadLine(), out short q);
        	
        	switch(M)
        	{
        		case 1:
        		  Console.Clear();
        		  Console.WriteLine($"O preço do(s) Pastel(s) é {4.50*q:c}");
        		  break;
        		case 2: 
        		  Console.Clear();
        		  Console.WriteLine($"O preço da(s) Coxinha é {2.00*q:c}");
        		  break;
        		case 3: 
        		  Console.Clear();
        		  Console.WriteLine($"O preço do(s) Sorvete(s) é {3.00*q:c}");
        		  break;
        		case 4: 
        		  Console.Clear();
        		  Console.WriteLine($"O preço do(s) Açai(s) é {5.00*q:c}");
        		  break;
        	}
        }
    }
}*/