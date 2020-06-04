using System;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new DoorOpen());
            context.Request1();
            context.Request2();
            context.Request3();
            context.Request1();
            context.Request2();
            context.Request3();
        }
    }
}
