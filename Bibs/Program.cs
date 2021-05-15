using System;

namespace Bibs
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] instances = new object[10];
            
            GSM test = new GSM("Nokia", "Apple" , 190, "biboy");
            instances[0] = test;
            test.DisInfo();
            Console.WriteLine(test.getmanufacturer);
           
        }
    }
}
