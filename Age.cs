/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Cal
{
       class Age 
       {
       	    private int year;
       	    
       	    public int Ano
       	    {
       	    	get{return year;}
       	    	set{year = value;}
       	    }
       	    
       	    private string nome;
       	    
       	    public string Name
       	    {
       	    	get{return nome;}
       	    	set{nome = value;}
       	    }
       	    
       	    public void Exibir()
       	    {
       	    	Console.WriteLine($"Nome do Usurio: {nome}");
       	    	Console.WriteLine($"Idade do usuario: {year}");
       	    	Console.WriteLine($"O ano de nascimento é: {CalculateAge()}");
       	    }
       	    
       	    private int CalculateAge()
       	    {
       	    	DateTime data = DateTime.Now;
       	    	int ano = data.Year;
       	    	int id = ano - year;
       	    	return id;
       	    }
       }
       class Pro
       {
       	    static void Main()
       	    {
       	    	Console.WriteLine("Programa que calcula a idade de uma pessoa");
       	    	Age c = new Age();
       	    	Console.Write("Nome da Pessoa: ");
       	    	c.Name = Console.ReadLine().ToUpper();
       	    	Console.Write("Idade da Pessoa: ");
       	    	c.Ano = int.Parse(Console.ReadLine());
       	    	Console.ForegroundColor = ConsoleColor.Green;
       	    	Console.Clear();c.Exibir();
       	    }
       }
  }*/