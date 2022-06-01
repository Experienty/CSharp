using System;
using System.Linq;
using System.Collections.Generic;

namespace Vetor
{
    public class Array 
    {         
        static void Main()
        {
        	//Com a tribuição na variavel
        	int[] x = new int[5];
        	//Com a tribuição na declaração da variavel
        	int[] y = new int[4]{40,80,160,320};
        	//Com a tribuição na declaração ou na variavel
        	string[] z = new string[4]{"Moto","Carro","Avião","Navio"};
        	// valores com bitewise
        	x[0] = 8<<2;
        	x[1] = 16>>2;
        	x[2] = 32<<2;
        	x[3] = 64>>2;
        	x[4] = 128<<2;
        	
        	Console.WriteLine(x[3]);
        	Console.WriteLine(y[1]);
        	Console.WriteLine(z[3]);
        	//array bidimencional
        	int[,] a = new int[2,4]{{10,20,30,40},{50,60,70,80}};
        	Console.WriteLine(a[1,3]);
        }
    }
}