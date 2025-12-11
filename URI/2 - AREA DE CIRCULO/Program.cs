using System;

namespace uri1003 {
    class Program {
        static void Main(string[] args) {

            double area, raio, pi = 3.14159;
            
            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}