using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CangKu cangKu = new CangKu();
            cangKu.JinPros("Acer", 1000);
            cangKu.JinPros("SamSung", 100);
            cangKu.JinPros("Banana", 10);
            cangKu.JinPros("JiangYou", 1);
            cangKu.ShowPros();
            Console.ReadKey();
        }
    }
}
