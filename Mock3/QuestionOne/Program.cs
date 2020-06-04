using System;
using System.Diagnostics;

namespace QuestionOne
{
   public class Program
    {
        static void Main(string[] args)
        {
            var flour = new Box(name : "flour", 4);
            Debug.Assert(flour.CostOfTheBox(grocery : true) == 4);
            var sunscreen = new Box(name: "sunscreen", 3);
            Console.WriteLine(sunscreen.CostOfTheBox());
            Debug.Assert(sunscreen.CostOfTheBox() == 3.3);
            var tv = new Box(name: "television", 500);
            Debug.Assert(tv.CostOfTheBox(taxRate: 0.06) == 530);
        }

      
    }

    public class Box
    {
        private string Name {get; set;}
    private double Price { get; set; }

        public  Box(string name, double price) {Name =name; Price = price;}

        public double CostOfTheBox(bool grocery = false, bool medication = false, double taxRate = 0.10)

         => (grocery == true || medication == true) ? Price : Price + Price * taxRate; 
        

    }


    }
 
