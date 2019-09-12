using PhonedataCore;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PhonedataBenchmarkCore
{
    class Program
    {
        static string[] s;
        static void Benchmark_add_element()
        {
            s = File.ReadAllLines("test.txt");
        }
        static void Benchmark_test()
        {
            PhoneData pd = new PhoneData("phone.dat");
            DateTime dt1 = DateTime.Now;
            Parallel.ForEach(s, (i) =>
            {
                pd.Lookup(i);

            });
            //foreach (var item in s)
            //{
            //    pd.Lookup(item);
            //}
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("并行计算 {0}个手机号码的查找，用时： {1}毫秒。\n", s.Length, (dt2 - dt1).TotalMilliseconds);


        }
        static void Main(string[] args)
        {
            Benchmark_add_element();
            Benchmark_test();
            Console.ReadKey();
        }
    }
}
