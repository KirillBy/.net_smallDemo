using System;
using System.Collections.Generic;

namespace ListTrain
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Neighbour> neighbours = new List<Neighbour>();
            neighbours.Add(new Neighbour("Ivanov", 12, "+375291001010"));
            neighbours.Add(new Neighbour("Petrov", 11, "+375291002020"));
            neighbours.Add(new Neighbour("Sidorov", 13, "+375291003030"));
            neighbours.Add(new Neighbour("Trump", 15, "+375291000000"));
            neighbours.Add(new Neighbour("Obama", 16, "+375291001000"));
            Console.WriteLine("Please a flat number");
            ushort userChoise = ushort.Parse(Console.ReadLine());
            foreach (var item in neighbours)
            {
                if (item.FlatNumber == userChoise)
                    item.DisplayInfo();
            }
        }
    }
}
