using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Здесь был нарушем принцип Open Closed Principle.
    //Здесь пришлось бы переписывать первоначальный код метода ProduceBird, если бы появился новый тип птиц.
    //Поэтому я сделала словарь с типами птиц 
    internal interface IBirdProducer 
    {
        public IBird ProduceBird(string birdType);
    }
    public class BirdProducer: IBirdProducer
    {
        internal static readonly Dictionary<string, Func<IBird>> birdCreators = new()
    {
        { "Pinguin", () => new Pinguin() },
        { "Sparrow", () => new Sparrow() }
    };

        public IBird ProduceBird(string birdType)
        {
            if (birdCreators.TryGetValue(birdType, out var creator))
            {
                return creator();
            }

            throw new ArgumentException($"Bird type '{birdType}' is not supported.");
        }
    }
}