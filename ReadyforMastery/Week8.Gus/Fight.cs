using System;
using System.Collections.Generic;
using System.Text;

namespace Week8.Gus
{
    class Fight
    {
        public static void SetWinner(Gus gus1, Gus gus2, Gus gus3)
        {
            if (gus1.Weight > gus2.Weight && gus1.Age > gus2.Age)
            {
                if (gus1.Weight > gus3.Weight && gus1.Age > gus3.Age)
                {
                    Console.WriteLine($"{gus1.Name} is the winner");
                }
                else
                {
                    Console.WriteLine($"{gus3.Name} is the winner");
                }
            }
            else if (gus2.Weight > gus1.Weight && gus2.Age > gus1.Age)
            {
                if (gus2.Weight > gus3.Weight && gus2.Age > gus3.Age)
                {
                    Console.WriteLine($"{gus2.Name} is the winner");
                }
                else
                {
                    Console.WriteLine($"{gus3.Name} is the winner");
                }
            }
        }
    }
}
