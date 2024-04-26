using Module18.SuzukuBuilder.Conveyors;
using System;

namespace Module18.SuzukuBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var carTask = new CarConveyor();

            var runner = new ConveyorRunner();
            runner.Construct(carTask);
            carTask.Product.Show();
            
        }
    }
}
