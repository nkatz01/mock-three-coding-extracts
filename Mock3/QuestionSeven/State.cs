using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionSeven
{
 public   abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void SwitchLights();

        public abstract void SwitchMotor();
        public abstract void OperateDoor();
    }
}
