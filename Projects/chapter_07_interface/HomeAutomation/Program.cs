namespace HomeAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            Thermostat homeThermostat = new Thermostat();
            SecuritySystem homeSecurity = new SecuritySystem();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Turn on Living Room Light");
                Console.WriteLine("2. Turn off Living Room Light");
                Console.WriteLine("3. Dim Living Room Light");
                Console.WriteLine("4. Turn on Thermostat");
                Console.WriteLine("5. Turn off Thermostat");
                Console.WriteLine("6. Set Thermostat Temperature");
                Console.WriteLine("7. Turn on Security System");
                Console.WriteLine("8. Turn off Security System");
                Console.WriteLine("9. Activate Security Alarm");
                Console.WriteLine("10. Deactivate Security Alarm");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        livingRoomLight.TurnOn();
                        break;
                    case "2":
                        livingRoomLight.TurnOff();
                        break;
                    case "3":
                        Console.Write("Enter dim level (1-10): ");
                        if (int.TryParse(Console.ReadLine(), out int level))
                        {
                            livingRoomLight.Dim(level);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "4":
                        homeThermostat.TurnOn();
                        break;
                    case "5":
                        homeThermostat.TurnOff();
                        break;
                    case "6":
                        Console.Write("Enter temperature: ");
                        if (int.TryParse(Console.ReadLine(), out int temp))
                        {
                            homeThermostat.SetTemperature(temp);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "7":
                        homeSecurity.TurnOn();
                        break;
                    case "8":
                        homeSecurity.TurnOff();
                        break;
                    case "9":
                        homeSecurity.ActivateAlarm();
                        break;
                    case "10":
                        homeSecurity.DeactivateAlarm();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 10.");
                        break;
                }
            }
        }
    }
}