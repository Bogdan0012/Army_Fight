using System;

namespace CProject
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("\n");
            User user = new User();
            user.search();
            
            Controller controller = new Controller();
            if (controller.ControllerCheck() == 0) return 0;
            
            AirConditioner conditioner = new AirConditioner();
            if (conditioner.ElectricityCheck() == 0) return 0;
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
