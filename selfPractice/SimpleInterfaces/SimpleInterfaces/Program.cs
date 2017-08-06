using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepherd bigDog = new GermanShepherd();
            Yorkie littleDog = new Yorkie();

            GiveTreat(bigDog);
            GiveTreat(littleDog);

            Console.ReadLine();
        }

        static void GiveTreat(IDog dog)
        {
            if (dog is GermanShepherd)
            {
                ((GermanShepherd)dog).SniffForDrugs();
            }
            dog.Bark();
        }
    }
}
