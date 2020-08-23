using System;

namespace Week8.Gus
{
    class Program
    {
        static void Main(string[] args)
        { 
            Gus ga = new Gus("ga",5,10);
            Gus gaga = new Gus("gaga",3,11);
            Gus gagaga = new Gus("gagaga",4,11);

            Fight.SetWinner(ga, gaga, gagaga);
        }
    }
}
