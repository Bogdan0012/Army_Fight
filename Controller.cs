namespace CProject
{
using System;    
    class Controller
    {
        short controller;

        public Controller() {
            this.controller = 1;
        }
        public Controller(short controller) {
            this.controller = controller;
        }
        
        public short ControllerCheck() {
            if (this.controller > 0) return 1;
            else  return 0;
        }
    }
}