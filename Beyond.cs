/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Beyond
{
    class Village
    {         
        protected string name = "Saitama";
        protected int id = 243;
        protected string pais = "Japão";
        
        public virtual void Person()
        {
            Console.WriteLine($"Seu Nome é: {name} Sua idade {id} Seu Pais {pais}");
        }
    }
    class City:Village
    {
    	public override void Person()
    	{
    		string mac = "fc:27:dt:h7:8j9";
    		base.Person();
    		Console.WriteLine($"Seu Mac é: {mac}");
    	}
    }
    class Program
    {
    	static void Main()
    	{
    		City c = new City();
    		c.Person();
    	}
    }
}*/