using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        [DllImport("D:\\GitHub.Repository\\HttpCOM\\Lib\\CySoft.Http.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        public static extern string Post(string url, string content);

        static void Main(string[] args)
        {
            var result = Post("aaa", "bbb");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
