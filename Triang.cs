/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Try
{
    class Retang 
    {  
    	public Retang()
    	{
    		this.Alt = 0;
    		this.Base = 0;
    	}
        private float hight;
        
        public float Alt
        {
        	get{return hight;}
        	set{if(value >= 0){
        		hight = value;
        	}else{
        		hight = 0;
        	};}
        }
        private float baser;
        
        public float Base
        {
        	get{return baser;}
        	set{if(value >= 0){
        		baser = value;
        	}else{
        		baser = 0;
        	};}
        }
        public void Show()
        {
        	Console.WriteLine($"A area do Triangulo é: {hight*baser}");
        }
    }
    class Pro
    {
    	static void Main()
    	{
    		Retang t = new Retang();
    		Console.Write("Imforme o valor da Altura: ");
    		t.Alt = float.Parse(Console.ReadLine());Console.Clear();
    		Console.Clear();Console.Write("Imforme o valor da Base: ");
    		t.Base = float.Parse(Console.ReadLine());Console.Clear();
    		t.Show();
    	}
    }
}*/