namespace CProject
{
using System;    
    class Temperature
    {
        public int TemperatureCheck(int temperature, int required_temperature) {
            if (temperature > required_temperature) {
                Console.WriteLine("Temperature is higher than desired (tmpr--)"); return 1;
            }
            else return 0;
        }
    }
}