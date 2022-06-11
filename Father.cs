/*using System;
using System.Linq;
using System.Collections.Generic;
//Exemplo do metodo :base() abaixo
namespace Fat
{
    public class Exemplo1
    {         
        public Exemplo1()
        {
            Console.WriteLine("A\n");
        }
        public Exemplo1(string firts)
        {
        	Console.WriteLine($"Primeiro e unico {firts}\n");
        }
    }
    class Exemplo:Exemplo1
    {
    	public Exemplo()
    	{
    		Console.WriteLine("B\n");
    	}
    	public Exemplo(string firts):base(firts)
    	{
    		Console.WriteLine($"Segundo e unico {firts}\n");
    	}
    }
    class Program
    {
    	static void Main()
        {
        	Exemplo1 e = new Exemplo1("God");
        	Exemplo a = new Exemplo("Jesus");
        }
    }
}*/