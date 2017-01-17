using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tw2cn = "她來聽我　的演唱會　在十七歲的初戀　第一次約會，繁轉簡";
                string cn2tw = "她来听我　的演唱会　在十七岁的初恋　第一次约会，簡轉繁";
                Console.Out.WriteLine("繁轉簡 : " + tw2cn +" ---> "+ Kernel32Converter.ToSimplified(tw2cn));
                Console.Out.WriteLine("簡轉繁 : " + cn2tw + " ---> " + Kernel32Converter.ToTraditional(cn2tw));
                while (Console.Read() != 'q') ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
