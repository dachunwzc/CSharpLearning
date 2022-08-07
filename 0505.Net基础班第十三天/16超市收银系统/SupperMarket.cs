using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    internal class SupperMarket
    {
        CangKu cangKu = new CangKu();

        /// <summary>
        /// 创建仓库的时候给仓库的货架上导入货物
        /// </summary>
        public SupperMarket()
        {
            cangKu.JinPros("Acer", 1000);
            cangKu.JinPros("SamSung", 100);
            cangKu.JinPros("Banana", 10);
            cangKu.JinPros("JiangYou", 1);
            cangKu.ShowPros();
            Console.ReadKey();
        }

        /// <summary>
        /// 跟用户交互的过程
        /// </summary>
        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么");
            Console.WriteLine("欢我们有Acer，SamSung，Banana，JiangYou");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少");
            int count = Convert.ToInt32(Console.ReadLine());

            // 去仓库区货物
            ProductFather[] pros = cangKu.QuPros(strType, count);
            // 计算价钱
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付：{0}元", realMoney);
            Console.WriteLine("请选择您的打折方式    1--不打折    2--打九折    3--打八五折    4--买三百减五十    5--买五百减一百");
            string input = Console.ReadLine();
            // 通过简单工厂的设计模式，根据用户的输入返回一个打折对象
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元", totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称：" + item.Name + "," + "\t" + "货物单价：" + item.Price + "," + "\t" + "货物编号：" + item.ID);
            }
        }

        /// <summary>
        /// 根据用户选择的打折方式返回一个打折对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回指向子类的父类对象</returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }

        /// <summary>
        /// 根据用户买的货物计算总价钱
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            cangKu.ShowPros();
        }
    }
}
