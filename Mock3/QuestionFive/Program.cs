using System;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShop carShop = new CarShop();
            Car sportCar = carShop.sellCar("SportCar");
            Car flyingCar = carShop.sellCar("FlyingCar");
        }
    }
}
