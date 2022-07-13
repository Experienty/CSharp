/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Met
{
    public class Metod 
    {         
        static void Main()
        {
        	int[] vetor = new int[5]{0,1,2,3,4};
        	int[] vetor1 = new int[5]{1,2,3,4,5};
        	int[] vetor2 = new int[5]{1,2,3,4,5};
        	int[] vetor3 = new int[5]{1,2,3,4,5};
        	int[,] matrix = new int[2,5]{{10,20,30,40,50},{60,70,80,90,100}};
        	
        	Random random = new Random();
        	for(int i = 0; i < vetor1.Length; i++){
        		vetor1[i] = random.Next(50);
        	}
        	Console.WriteLine("Elementos dos vetor 1: ");
        	foreach(int x in vetor1){
        		Console.WriteLine(x);
        	}
        	//BinarySearch Procurar um Elemento Dentro do Array
        	Console.WriteLine("BinarySearch");
        	int procurar = 40;
        	int pos = Array.BinarySearch(vetor1,procurar);
        	Console.WriteLine($"O valor {procurar} Esta na posição {pos}");
        	Console.WriteLine();
        	//Copy copia os Elementos de uma Array para outra Array vazia
        	Console.WriteLine("Copy");
        	Array.Copy(vetor1,vetor2,vetor1.Length);
        	Console.WriteLine();
        	//CopyTo copia os elementos de outro array aperte da posição
        	Console.WriteLine("CopyTo");
        	vetor1.CopyTo(vetor3,0);
        	foreach(int y in vetor3){
        		Console.WriteLine(y);
        		Console.WriteLine();
        	}
        	//GetLongLenghBound retorna a quantidade de elementos da array
        	Console.WriteLine("GetLongLenghBound");
        	long qtdd = vetor1.GetLongLength(0);
        	Console.WriteLine($"Quantidade de indice {qtdd}");
        	Console.WriteLine();
        	//GetLowerBound retorna o Menor Indice do Array ou vetor
        	Console.WriteLine("GetLowerBound");
        	int MIV = vetor1.GetLowerBound(0);
        	int VIM = matrix.GetLowerBound(1);
        	Console.WriteLine($"Menor Indice do Vetor: {MIV}");
        	Console.WriteLine($"Menor Indice da Matrix: {VIM}");
        	Console.WriteLine();
        	//GetUpperBound retorna o Maior valor do Array ou do vetor
        	Console.WriteLine("GetUpperBound");
        	int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        	int MaiorIndiceMatrix = matrix.GetUpperBound(1);
        	Console.WriteLine($"Maior Indice do valor: {MaiorIndiceVetor}");
        	Console.WriteLine($"MaiorIndiceMatrix: {MaiorIndiceMatrix}");
        	Console.WriteLine();
        	//GetValue returna um valor aperte de um indice
        	Console.WriteLine("GetValue");
        	int v = Convert.ToInt32(vetor1.GetValue(3));
        	int m = Convert.ToInt32(matrix.GetValue(1,3));
        	Console.WriteLine($"O valor da 3 Posição do vetor1: {v}");
        	Console.WriteLine();
        	//IndexOf retorna um indice do valor do Array 
        	Console.WriteLine("IndexOf");
        	int indice = Array.IndexOf(vetor1,3);
        	Console.WriteLine($"Indice do Primeiro Valor 3: {indice}");
        	Console.WriteLine();
        	//LastIndexOf retorna o ultimo indice do vetor ou array
        	Console.WriteLine("LastIndexOf");
        	int indice1 = Array.LastIndexOf(vetor1,3);
        	Console.WriteLine($"Indice do ultimo valor: {indice1}");
        	Console.WriteLine();
        	//Array.Reverse 
        	Console.WriteLine("Array.Reverse");
        	Array.Reverse(vetor1);
        	foreach(int z in vetor1){
        		Console.WriteLine(z);
        	}
        	//SetValue para definir um valor em uma posição
        	vetor2.SetValue(90,0);
        	for(int w = 0; w < vetor2.Length; w++){
        		vetor2.SetValue(0,w);
        	}
        	Console.WriteLine("Vetor2");
        	foreach(int d in vetor2){
        		Console.WriteLine(v);
        	}
        	Console.WriteLine();
        	//Array.Sort é para ordenar em orde crescente
        	Console.WriteLine("Array.Sort");
        	Array.Sort(vetor1);
        	Array.Sort(vetor2);
        	Array.Sort(vetor3);
        	Console.WriteLine("vetor1: ");
        	foreach(int t in vetor1){
        		Console.WriteLine(t);
        	}
        	Console.WriteLine("\nvetor2: ");
        	foreach(int u in vetor2){
        		Console.WriteLine(u);
        	}
        	Console.WriteLine("\nvetor3: ");
        	foreach(int r in vetor3){
        		Console.WriteLine(r);
        	}
        }
    }
}*/