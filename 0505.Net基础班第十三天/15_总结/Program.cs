using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_总结
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 什么时候用虚方法来实现多态
            // 什么时候用抽象类来实现多态
            // 什么时候用接口来实现多态

            // 真的鸭子会游泳    木头鸭子不会游泳    橡皮鸭子会游泳
            ISwimming swimming = new RealDuck();
            swimming.Swimming();

            swimming = new MuDuck();
            swimming.Swimming();

            swimming = new XPDuck();
            swimming.Swimming();

            Console.ReadKey();
        }

        public class RealDuck : ISwimming
        {
            public void Swimming()
            {
                Console.WriteLine("真的鸭子靠翅膀游泳");
            }
        }

        public class MuDuck : ISwimming
        {
            public void Swimming()
            {
                Console.WriteLine("木鸭子不会游泳");
            }
        }
        
        public class XPDuck : ISwimming
        {
            public void Swimming()
            {
                Console.WriteLine("橡皮鸭子飘着游泳");
            }
        }

        public interface ISwimming
        {
            void Swimming();
        }
    }
}
