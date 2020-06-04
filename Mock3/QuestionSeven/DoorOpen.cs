using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionSeven
{
 public   class DoorOpen : State
    {
        public override void SwitchMotor()
        {
            Console.WriteLine("Motor off");
        
        }

        public override void SwitchLights()
        {
            Console.WriteLine("Lights turned on");
        }

        public override void OperateDoor()
        {
                Console.WriteLine("Door Open changes the state of the context i.e. Door is closed next.");
               this._context.TransitionTo(new DoorClosed());
        }
    }
}
