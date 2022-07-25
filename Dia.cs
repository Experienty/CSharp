/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Diagonal
{
    class Dia 
    {         
       static void Main()
       {
       	  var x = new int[][]
       	  {
       	      new int[] {6,0,0,0,0},
       	      new int[] {0,9,0,0,0},
       	      new int[] {0,0,2,0,0},
       	      new int[] {0,0,0,5,0},
       	      new int[] {0,0,0,0,7},
       	  };
       	  var diagonal = true;
       	  
       	  for(int i = 0; i < x.Length; i++){
       	  	for(int y = 0; y < x[i].Length; y++){
       	  		if(i == y){
       	  			if(x[i][y] == 0){
       	  				diagonal = false;
       	  				break;
       	  			}
       	  		}else{
        			if(x[i][y] != 0){
       	  				diagonal = false;
       	  				break;
       	  			}
       	  		}
       	  	 }
       	  }
       	  Console.WriteLine($"The Matrix is diagonal? {diagonal}");
       }
    }
}*/