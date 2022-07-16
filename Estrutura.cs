/*using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Whily
{
    public class Estrutura 
    {         
        static void Main()
        {
        	double idade, soma = 0, media;
        	int cont = 0;
        	idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        	
        	while(idade >= 0){
        		soma += idade;
        		cont += 1;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        	}
        	if(cont == 0){
        		Console.Write(" Impossivel de Calcular");
        	}else{
        		media = soma/ cont;
        		Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        		//Console.ReadLine();
        	}
        }
    }
}*/