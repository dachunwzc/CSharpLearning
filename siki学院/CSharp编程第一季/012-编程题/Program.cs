using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提取数字的百位，十位，个位
            int number = Convert.ToInt32(Console.ReadLine());

            int ge = number % 10;
            int shi = (number / 10) % 10;
            int bai = (number / 100) % 10;

            Console.WriteLine("number的百位是{0}，十位是{1}，个位是{2}", bai, shi, ge);
        }
    }
}
