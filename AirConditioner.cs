namespace CProject
{
using System;    
    class AirConditioner
    {
        short electric_power;

        public AirConditioner() {
            this.electric_power = 1;
        }
        public AirConditioner(short electric_power) {
            this.electric_power = electric_power;
        }
        
        public short ElectricityCheck() {
            if (electric_power > 0) return 1;
            else  return 0;
        }
        
        public void ON() {
            Console.WriteLine("Air conditioner ON");
        }
        public void OFF() {
            Console.WriteLine("Air conditioner OFF");
        }
        
        public int TemperatureDrop(int temperature) {
            return --temperature;
        }
    }
}