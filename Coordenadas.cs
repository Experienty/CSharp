/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Cartesiano
{
    public class Coordenadas 
    {         
        static void Main()
        {
        	Console.Write("digite o valor de x: ");
        	double.TryParse(Console.ReadLine(), out double x);
        	Console.Clear();
        	Console.Write("digite o valor de y: ");
        	double.TryParse(Console.ReadLine(), out double y);
        	Console.Clear();
        	if(x == 0.0 && y == 0.0){
        		Console.WriteLine("Origem");
        	}else{
        		if(x == 0.0){
        			Console.WriteLine("Eixo x");
        		}else{
        			if(y == 0.0){
        				Console.WriteLine("Eixo y");
        			}else{
        			    if(x > 0.0 && y > 0.0){
        				    Console.WriteLine("Quadrante #1");
        			    }else{
        				   if(x < 0.0 && y > 0.0){
        					   Console.WriteLine("Quadrante #2");
        				   }else{
        					  if(x < 0.0 && y < 0.0){
        						  Console.WriteLine("Quadrante #3");
        					  }else{
        						 if(x > 0.0 && y < 0.0){
        							 Console.WriteLine("Quadrante #4");
        						    }
        					    }
        					}
        				}
        			}
        		}
        	}
        }
    }
}*/