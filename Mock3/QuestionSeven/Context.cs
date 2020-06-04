using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionSeven
{
  public  class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        
        public void Request1()
        {
            this._state.SwitchLights();
        }

        public void Request2()
        {
            this._state.SwitchMotor();
        }

        public void Request3()
        {
            this._state.OperateDoor();
        }
    }
}
