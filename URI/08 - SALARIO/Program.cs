﻿using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string nome;
        double salario, vendas, percentual, comissao, total;
        
        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        percentual = 15.0 / 100;
        comissao = vendas * percentual;
        
        total = salario + comissao;
       
        
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        
               
    }

}