/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Choose
{
    class Chooise 
    {         
        public int Adicao(int a,int b)
        {
        	return a + b;
        }
        public int Divisao(int c,int d)
        {
        	return c / d;
        }
        public int Subtracao(int e,int f)
        {
        	return e - f;
        }
        public int Multiplicacao(int g,int h)
        {
        	return g * h;
        }
    }
    class Pro
    {
    	static void Main()
    	{
    	    Chooise c = new Chooise();
    		Console.Write("informe o qual tipo de operação deseja efetuar:/,*,+,÷: ");
    		char.TryParse(Console.ReadLine(),out char operaçao);Console.Clear();
    		Console.Write("imforme o primeiro valor: ");
    		int.TryParse(Console.ReadLine(),out int x);Console.Clear();
    		Console.Write("imforme o segundo valor: ");
    		int.TryParse(Console.ReadLine(),out int y);Console.Clear();
    		
    		switch(operaçao)
    		{
    			case '+': 
    			  Console.WriteLine($"O calculo da soma é: {c.Adicao(x,y)}");
    			  break;
    			case '-': 
    			  Console.WriteLine($"O calculo da Subtração é: {c.Subtracao(x,y)}");
    			  break;
    			case '*': 
    			  Console.WriteLine($"O calculo da Multiplicação é: {c.Multiplicacao(x,y)}");
    			  break;
    			case '/': 
    			  Console.WriteLine($"O calculo da divisão é: {c.Divisao(x,y)}");
    			  break;
    		}
    	}
    }
}*/