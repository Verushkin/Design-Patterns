using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BirdHandler
    {
        //здесь был нарушен принцип Dependency Inversion, так как у нас была
        //зависимость на реализацию класса Bird Producer.
        //Я избавилась от этой зависимости , дописав интерфейс по созданию птиц.
        protected IBirdProducer birdProducer;
        public BirdHandler(IBirdProducer birdProducer)
        {
            this.birdProducer = birdProducer;
        }

        internal void DoBirdAction()
        {
            Sparrow sparrow = this.birdProducer.ProduceBird("Sparrow") as Sparrow;
            Pinguin pinguin = this.birdProducer.ProduceBird("Pinguin") as Pinguin;

            this.HandleBirdMoves(sparrow);
            this.HandleBirdMoves(pinguin);

            this.HandleBirdMultiplies(sparrow);
            this.HandleBirdMultiplies(pinguin);

            this.HandleBirdGrowsAChild(sparrow);
            this.HandleBirdGrowsAChild(pinguin);
        }

        public void HandleBirdMoves(IBird bird)
        {
            bird.Walk();

            if (bird is IFlyer flyer)
            {
                flyer.Fly();
            }
        }

        public void HandleBirdMultiplies(IBird bird)
        {
            bird.SearchForSpause();

            if (bird is ISinger singer)
            {
                singer.Sing();
            }

            bird.Dance();
        }

        public void HandleBirdGrowsAChild(IBird bird)
        {
            bird.ProduceEgg();

            if (bird is IEggDefender defender)
            {
                defender.DefendEgg();
            }
        }
    }
}