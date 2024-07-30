
public abstract class Appliance : IControllable
    {
        public bool IsPoweredOn { get; private set; }

        public virtual void TurnOn()
        {
            IsPoweredOn = true;
            Console.WriteLine($"{GetType().Name} is now ON.");
        }

        public virtual void TurnOff()
        {
            IsPoweredOn = false;
            Console.WriteLine($"{GetType().Name} is now OFF.");
        }

        public virtual bool IsOn()
        {
            return IsPoweredOn;
        }
    }
