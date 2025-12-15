using System;

namespace uri1003 {
    class Program {
        static void Main(string[] args) {

            int km, minuto;
           
            km = int.Parse(Console.ReadLine());
            minuto = km * 2;              
                        
            Console.WriteLine(minuto + " minutos");
        }
    }
}