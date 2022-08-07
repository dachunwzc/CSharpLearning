using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01MD5加密
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
        }

        public static string GetMD5(string str)
        {
            // 创建MD5对象
            MD5 mD5 = MD5.Create();
            // 开始加密
            // 将字符串转成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] mD5Buffer = mD5.ComputeHash(buffer);
            // 将字节输入转换成字符串
            // return Encoding.Default.GetString(mD5Buffer);

            // 将字节数组转换成字符串
            // 字节数组———字符串
            // 将字节数组中每个元素按照指定的编码格式解析成字符串
            // 直接将数组ToString();
            // 将字节数组中的每个元素ToString()

            // 189 273 345 我爱你
            // 189 273 345
            String strNew = "";
            for (int i = 0; i < mD5Buffer.Length; i++)
            {
                // ToString("X") --> 转换成16进制
                strNew += mD5Buffer[i].ToString("X");
            }
            return strNew;
        }
    }
}
