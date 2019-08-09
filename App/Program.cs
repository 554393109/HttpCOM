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
        private const string pathDll = @"D:\GitHub.Repository\HttpCOM\Lib\CySoft.Http.dll";

        [DllImport(pathDll, CharSet = CharSet.Ansi/*, CallingConvention = CallingConvention.StdCall*/)]
        public static extern int Post();
        //public static extern string Post(string url, string content);

        static void Main(string[] args)
        {
            int result = Post();
            //var result = Post("aaa", "bbb");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
