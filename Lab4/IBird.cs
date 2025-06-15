using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
   // Тут был нарушен принцип Interface Segregation. Не все птицы умеют летать, петь, защищать яйца. 
   // Поэтому я вынесла эти функции в отдельные интерфейсы 
    public interface IBird
    {
        void Dance();
        void Walk();
        void ProduceEgg();
        void SearchForSpause();
    }
    public interface IFlyer 
    {
        void Fly();
    }

    public interface IEggDefender 
    {
        void DefendEgg();
    }
    public interface ISinger 
    {
        void Sing();
    }
}