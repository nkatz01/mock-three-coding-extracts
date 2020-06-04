using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionFive
{
   public class CarFactory
    {
        //based on this: https://medium.com/@ddst/design-pattern-101-singleton-and-factory-pattern-f0908a56d044

        public Car getCar(String carType)
        {
            if (carType.Equals("SportCar", StringComparison.InvariantCultureIgnoreCase))
            {
                return new SportCar();

            }
            else if (carType.Equals("FamilyCar", StringComparison.InvariantCultureIgnoreCase))
            {
                return new FamilyCar();

            }
            

            return null;
        }
    }
}
