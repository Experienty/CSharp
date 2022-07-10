/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Ac
{
    public class Acao 
    {         
        static void Main(string[] args)
        {
        	Action ac;
        	
        	ac = () => MyFunction("Eu Sou Uma Função");
        	
        	ac();
        	
        	void MyFunction(string texto)
        	  => Console.WriteLine(texto);
        	//Encadeamento de Funçoes abaixo
        	Action handle;
        	
        	handle = ValorDoSaldo;
        	handle += CasaDomestica;
        	handle += DiminuirSaldo;
        	handle += AumentarSaldo;
        	
        	handle();
        	
        	void ValorDoSaldo()=> Console.WriteLine("1");
        	void CasaDomestica()=> Console.WriteLine("2");
        	void DiminuirSaldo()=> Console.WriteLine("3");
        	void AumentarSaldo()=> Console.WriteLine("4");
        }
    }
}*/