using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Constrains_Task2
{
    internal abstract class Car
    {
        readonly protected string model;
        readonly protected int id;
        public Car(string model, int id)
        {
            this.model = model;
            this.id = id;
        }
        public abstract void ShowCar();
    }
    internal class Toyota : Car
    {
        
        public Toyota(string model, int id):base(model, id)
        {

        }
        public override void ShowCar()
        {
            Console.WriteLine("This is Toyota {0} with id: {1}", model, id );
        }
    }

    internal class BMW : Car
    {

        public BMW(string model, int id) : base(model, id)
        {

        }
        public override void ShowCar()
        {
            Console.WriteLine("This is BMW {0} with id: {1}", model, id);
        }
    }

    internal class JAGUAR : Car
    {

        public JAGUAR(string model, int id) : base(model, id)
        {

        }
        public override void ShowCar()
        {
            Console.WriteLine("This is JAGUAR {0} with id: {1}", model, id);
        }
    }

    internal class BENTLEY : Car
    {

        public BENTLEY(string model, int id) : base(model, id)
        {

        }
        public override void ShowCar()
        {
            Console.WriteLine("This is BENTLEY{0} with id: {1}", model, id);
        }
    }

    internal class GEELY : Car
    {

        public GEELY(string model, int id) : base(model, id)
        {

        }
        public override void ShowCar()
        {
            Console.WriteLine("This is GEELY {0} with id: {1}", model, id);
        }
    }
}
