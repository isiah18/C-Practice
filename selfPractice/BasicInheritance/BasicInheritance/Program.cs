using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance Demo ******");
            Car myCar = new Car(80);

            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);


            MiniVan myMiniVan = new MiniVan();
            myMiniVan.Speed = 60;
            Console.WriteLine("My van is going {0} MPH", myMiniVan.Speed);

            List<Car> myCars = new List<Car>();
            for (int i = 40; i < 90; i += 10)
            {
                myCars.Add(new MiniVan(i));
            }

            foreach (Car car in myCars)
            {
                Console.WriteLine("The car has a max spped of {0}", car.maxSpeed);
            }

            Console.ReadLine();
        }
    }
}
