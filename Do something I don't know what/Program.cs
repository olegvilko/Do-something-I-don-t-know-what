using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_something_I_don_t_know_what
{
    class Program
    {
        static int Decode(string str)
        {
            str = str.Replace(".", string.Empty);
            int num = Int32.Parse(str);
            num = num % 1024;
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Decode("1...2"));
        }
    }
}
