using PhoneataCore;
using System;

namespace PhonedataCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData pd = new PhoneData("phone.dat");
            string output;
            output = pd.Lookup("1325444878").ToString();
            Console.WriteLine(output);
            Console.ReadKey();
            /*
             * 1325444878
             * 1325444878
             */
        }
    }
}
