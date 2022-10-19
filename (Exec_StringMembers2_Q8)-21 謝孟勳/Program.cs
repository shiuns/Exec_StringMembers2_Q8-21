using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Exec_StringMembers2_Q8__21_謝孟勳
{
    //隱藏手機的資訊 呈現 0935****46
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入您的手機號碼 :");
            string sid = Console.ReadLine();

            if (string.IsNullOrEmpty(sid) || sid.Length != 10)
            {
                Console.WriteLine("sid 格式不對");
                return;
            }

            string sid2 = sid.Substring(0, 4) + new string('*', 4) + sid.Substring(8, 2);

            Console.WriteLine(sid2);
        }
    }
}
