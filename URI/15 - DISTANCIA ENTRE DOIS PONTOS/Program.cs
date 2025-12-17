﻿using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

        double ponto1X, ponto1Y, ponto2X, ponto2Y, distancia;
        
        string [] vet1 = Console.ReadLine().Split(' ');

        ponto1X = double.Parse(vet1[0], CultureInfo.InvariantCulture);
        ponto1Y = double.Parse(vet1[1], CultureInfo.InvariantCulture);
        
         string [] vet2 = Console.ReadLine().Split(' ');
        
        ponto2X = double.Parse(vet2[0], CultureInfo.InvariantCulture);
        ponto2Y = double.Parse(vet2[1], CultureInfo.InvariantCulture);

        distancia = Math.Sqrt(Math.Pow
        (ponto2X - ponto1X, 2) + Math.Pow(ponto2Y - ponto1Y, 2));
     
        Console.WriteLine(distancia.ToString("F4"));
        

    }

}