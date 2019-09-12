using PhonedataCore;
using System;

namespace PhonedataCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData pd = new PhoneData("phone.dat");
            string output;
            output = pd.Lookup("14794299760").ToString();
            Console.WriteLine(output);
            Console.ReadKey();
            /*
             * 1344710142
             * 1344711000
             */
        }
    }
}
