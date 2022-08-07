using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    internal class CangKu
    {
        // 存储货物
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        // list[0]存储Acer电脑
        // list[1]存储SamSung手机
        // list[2]存储香蕉
        // list[3]存储酱油

        /// <summary>
        /// 在创建仓库的时候向仓库中添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        public void ShowPros()
        {
            foreach (var item in list)
            {
                JinPros("Acer", 1000);
                Console.WriteLine("我们超市有:" + item[0].Name + "," + "\t" + item.Count + "个," + "\t" + "每个" + item[0].Price + "元");
            }
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(1000, "宏碁笔记本电脑", Guid.NewGuid().ToString()));
                            break;
                    case "SamSung":
                        list[1].Add(new SamSung(100, "三星手机", Guid.NewGuid().ToString()));
                        break;
                    case "Banana":
                        list[2].Add(new Banana(10, "香蕉", Guid.NewGuid().ToString()));
                        break;
                    case "JiangYou":
                        list[3].Add(new JiangYou(1, "酱油", Guid.NewGuid().ToString()));
                        break;
                }
            }
        }

        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
        }
    }
}
