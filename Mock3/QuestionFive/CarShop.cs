using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionFive
{
   public class CarShop
    {
        public CarFactory CarFactory {get; set;}
        static int carSold;
        public CarShop()
        {
            carSold = 0;
            CarFactory = new CarFactory();
        }
       
        
        
        //function to sell our car, as it returns car
        public Car sellCar(string carType)
        {
            carSold++;
            return CarFactory.getCar(carType);
        }
    }
}
 
