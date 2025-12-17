﻿using System;
using System.Globalization;

namespace uri1017 {
    class Program {
        static void Main(string[] args) {
        
        int horas, velocidade, viagem;
        double litros;
        
        horas = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());
        viagem = horas * velocidade;
        
        litros = viagem / 12.0;
        
        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        

        }
    }
}