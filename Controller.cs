namespace CProject
{
using System;    
    class Controller
    {
        short controller;

        Controller() {
            this.controller = 1;
        }
        Controller(short controller) {
            this.controller = controller;
        }
        
        public short ControllerCheck() {
            if (this.controller > 0){
                Console.WriteLine("User find controller,");
            }
            else{ 
                Console.WriteLine("User is not find controller."); return 0;
            }
        }
    }
}