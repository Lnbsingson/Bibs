using System;

namespace Bibs
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] instances = new object[10];
            
            GSM test = new GSM("Nokia", "Apple" , 190, "biboy");
            Battery Batttest = new Battery("energier", 242, 212421);
            Display Display = new Display();
            instances[0] = test;
            instances[1] = Batttest;
            instances[2] = Display;
            test.DisInfo();
            Console.WriteLine(test.NokiaStatic());
            Console.WriteLine(test.getmanufacturer);
            
        }
    }
}
