﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Sparrow : IBird, IEggDefender, ISinger, IFlyer
    {
        public void DefendEgg()
        {
            Console.WriteLine("Hit the enemy");
        }
        public void Dance()
        {
            Console.WriteLine("Shake your body");
        }

        public void Fly()
        {
            Console.WriteLine("Spread the wings");
        }

        public void ProduceEgg()
        {
            Console.WriteLine("Some magic happens");
        }

        public void SearchForSpause()
        {
            Console.WriteLine("Time to search for the spause");
            this.Sing();
        }

        public void Sing()
        {
            Console.WriteLine("Some Iron Maiden song from 80-th");
        }

        public void Walk()
        {
            Console.WriteLine("Walk this way");
        }
    }
}