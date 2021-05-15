using System;

namespace Bibs
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM test = new GSM("Nokia", "Apple" , 190, "biboy");

            test.DisInfo();
            Console.WriteLine(test.getmanufacturer);
           
        }
    }
}
