



public class Thermostat : Appliance
    {
        private int _temperature;

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"Temperature set to {_temperature} degrees.");
        }

        public int GetTemperature()
        {
            return _temperature;
        }
    }
