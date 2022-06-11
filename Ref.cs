/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Referência
{
    public class Ref 
    { 
    	//O Exemplo do Ref é fazer uma copia das variaveis 
        public static void Soma(ref int numero)
        {
        	Console.WriteLine($"A Soma dos Numeros é {numero += 450}\n");
        }
        public static void Mult(ref int numero)
        {
        	Console.WriteLine($"A Multiplicação dos numero é {numero *= 10}\n");
        }
        //Exemplo de Parametros Padroes
        public static double Padrão(double x = 3.4, double y = 6.6)
        {
        	return x + y;
        }
        static void Main()
        {
        	int x = 50;
        	Soma(ref x);
        	Console.WriteLine(x);
        	int y = 50;
        	Mult(ref y);
        	Console.WriteLine(y);
        	Console.WriteLine(Padrão());
        }
    }
}*/