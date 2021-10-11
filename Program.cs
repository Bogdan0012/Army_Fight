using System;

namespace CProject
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("\n");
            User user = new User();
            user.search();
            
            Controller controller = new Controller(1);
            if (controller.ControllerCheck() == 0){
                Console.WriteLine("User is not find controller."); return;
            }
            else
                Console.WriteLine("User find controller,");
            AirConditioner conditioner = new AirConditioner(1);
            if (conditioner.ElectricityCheck() == 0){
                Console.WriteLine("No power supply."); return;
            }
            else
                Console.WriteLine("Power supply is normal,");
            conditioner.ON();
            
            Temperature obj = new Temperature();
            int temperature = 29;
            int required_temperature = 24;
            Console.WriteLine($"\nTemperature before: {temperature}\n");
            while (obj.TemperatureCheck(temperature, required_temperature) == 1){
                temperature = conditioner.TemperatureDrop(temperature);
            }
            Console.WriteLine($"\nTemperature after: {temperature}");
            conditioner.OFF();
            Console.Read();
        }
    }
}
