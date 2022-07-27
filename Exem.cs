/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Exe7
{
    public class Exem 
    {         
        static void Main()
        {
        	Exem e = new Exem();
        	Console.Write("Informe Seu Salario: ");
        	double.TryParse(Console.ReadLine(), out double Salario);
        	
        	Console.Clear();
        	
        	Console.Write("Salario Atual: ");
        	Console.ForegroundColor = ConsoleColor.Red;
        	Console.WriteLine(Salario.ToString());
        	Console.Write("Pressione enter para exibir seu novo salario...");Console.ReadKey(); Console.Clear();
        	Console.Write("Novo Salario ");
        	Console.ForegroundColor = ConsoleColor.Green;
        	Console.Write(e.CalculoSalario(Salario));
        }
        private double CalculoSalario(double salario)
        {
        	double novosalario;
        	
        	if(salario > 1.200){
        		novosalario = (salario + 300);
        	}else{
        		novosalario = (salario + 200);
        	}
        	return novosalario;
        }
    }
}*/