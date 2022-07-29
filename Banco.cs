/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Bank
{
    public class Banco 
    {         
        public int agencia;
        public int numero;
        public double saldo;
        
        public Banco()
        {
        	
        }
        public Banco(int agencia, int numero, double saldo)
        {
        	this.agencia = agencia;
        	this.numero = numero;
        	this.saldo = saldo;
        }
        public void Depositar(double valor)
        {
        	saldo += valor;
        }
        public void Retirada(double valor){
        	saldo -= valor;
        }
        public double VerificarSaldo()
        {
        	return saldo;
        }
    }
    class Pro
    {
    	static void Main()
    	{
    		Banco b = new Banco();
    		b.saldo = 100.00;
    		b.Depositar(1.500);
    		Console.WriteLine(b.VerificarSaldo());
    	}
    }
}*/