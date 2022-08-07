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
            // 创建超市对象
            SupperMarket supperMarket = new SupperMarket();
            // 展示货物
            supperMarket.ShowPros();
            // 跟用户交互
            supperMarket.AskBuying();
            Console.ReadKey();
        }
    }
}
