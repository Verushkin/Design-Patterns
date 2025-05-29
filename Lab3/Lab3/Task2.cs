using Lab3.Abstraction;

namespace Lab3
{

    // Абстрактный медиатор
    public interface IAirTrafficControl
    {
        void RegisterAircraft(Aircraft aircraft);
        void SendMessage(string message, Aircraft sender);
        bool CanLand(Aircraft aircraft);
    }

    // Конкретный медиатор (диспетчер)
    public class AirTrafficController : IAirTrafficControl
    {
        private List<Aircraft> aircrafts = new List<Aircraft>();
        private bool runwayAvailable = true;

        public void RegisterAircraft(Aircraft aircraft)
        {
            if (!aircrafts.Contains(aircraft))
            {
                aircrafts.Add(aircraft);
                aircraft.SetMediator(this);
            }
        }

        public void SendMessage(string message, Aircraft sender)
        {
            foreach (var aircraft in aircrafts)
            {
                if (aircraft != sender)
                {
                    aircraft.Receive(message, sender.CallSign);
                }
            }
        }

        public bool CanLand(Aircraft aircraft)
        {
            if (runwayAvailable)
            {
                Console.WriteLine($"{aircraft.CallSign} разрешено посадку.");
                runwayAvailable = false;
                return true;
            }
            else
            {
                Console.WriteLine($"{aircraft.CallSign} отказано в посадке — ВПП занята.");
                return false;
            }
        }

        // Метод, имитирующий освобождение ВПП
        public void RunwayCleared()
        {
            Console.WriteLine("ВПП освобождена.");
            runwayAvailable = true;
        }
    }

    // Абстрактный самолет
    public abstract class Aircraft
    {
        protected IAirTrafficControl mediator;
        public string CallSign { get; }

        public Aircraft(string callSign)
        {
            CallSign = callSign;
        }

        public void SetMediator(IAirTrafficControl atc)
        {
            mediator = atc;
        }

        public abstract void Receive(string message, string from);
        public abstract void RequestLanding();
    }

    // Конкретный самолет
    public class Plane : Aircraft
    {
        public Plane(string callSign) : base(callSign) { }

        public override void Receive(string message, string from)
        {
            Console.WriteLine($"{CallSign} получил сообщение от {from}: {message}");
        }

        public override void RequestLanding()
        {
            Console.WriteLine($"{CallSign} запрашивает посадку...");
            bool permission = mediator.CanLand(this);

            if (permission)
            {
                Console.WriteLine($"{CallSign} садится...");
            }
            else
            {
                Console.WriteLine($"{CallSign} уходит на второй круг.");
            }
        }
    }
    public class Task2 : IExamplePattern
    {
        public void Do()
        {
            // Создаем диспетчера (медиатора)
            AirTrafficController atc = new AirTrafficController();

            // Создаем самолеты
            var boeing = new Plane("Boeing-777");
            var airbus = new Plane("Airbus-A320");
            var sukhoi = new Plane("Sukhoi-SJ100");

            // Регистрируем самолеты в диспетчере
            atc.RegisterAircraft(boeing);
            atc.RegisterAircraft(airbus);
            atc.RegisterAircraft(sukhoi);

            Console.WriteLine();

            // Самолеты запрашивают посадку
            boeing.RequestLanding();
            Console.WriteLine();

            airbus.RequestLanding();
            Console.WriteLine();

            // Освобождаем ВПП
            atc.RunwayCleared();
            Console.WriteLine();

            // Третий самолет запрашивает посадку
            sukhoi.RequestLanding();
            Console.WriteLine();
        }
    }

}
