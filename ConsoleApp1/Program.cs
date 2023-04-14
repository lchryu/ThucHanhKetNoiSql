using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sao lại  ngứa
            SinhVien[] sv = new SinhVien[3];
            sv[0] = new SinhVien("nam");
            sv[1] = new SinhVien("Huệ");
            sv[2] = new SinhVien("Chó");
            //giờ mảng này có 3 sinh viên// là nam, huệ chó

            //mình có thể duyệt như này foreach
            foreach (SinhVien i in sv)
            {
                Console.WriteLine(i.Name);//đúng r duyệt theo value. t ko nghĩ ra từ value =)). nch nó là duyệt tuần tự
            }
            Console.ReadLine();
        }
    }
}
