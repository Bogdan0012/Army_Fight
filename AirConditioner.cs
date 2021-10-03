namespace CProject
{
using System;    
    class AirConditioner
    {
        short electric_power;

        AirConditioner() {
            this.electric_power = 1;
        }
        AirConditioner(short electric_power) {
            this.electric_power = electric_power;
        }
        
        public short ElectricityCheck() {
            if (electric_power > 0){
                Console.WriteLine("Power supply is normal,");
            }
            else{ 
                Console.WriteLine("No power supply."); return 0;
            }
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