using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionSeven
{
  public  class DoorClosed : State
    {
        public override void SwitchMotor()
        {
            Console.WriteLine("Motor On");
           
        }

        public override void SwitchLights()
        {
            Console.WriteLine("Lights turned off");
        }

        public override void OperateDoor()
        {
                Console.WriteLine("Door Open wants to change the state of the context i.e. Door is opened next.");
               this._context.TransitionTo(new DoorOpen());
        }
    }
}
