using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static QLPerson ql = new QLPerson();
        static void Main(string[] args)
        {           
            int chon = 0;
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Tao DS.");
                Console.WriteLine("2.Xuat DS");
                Console.WriteLine("3.Xuat Sinh Vien Theo Khoa CNTT");
                Console.WriteLine("4.Xuat Sinh vien Co Diem Nho Hon 5 Theo Khoa CNTT");
                Console.WriteLine("5.Xuat Giao Vien O Quan 9");
                Console.WriteLine("6.Xuat Giao Vien Theo Ma So");
                Console.WriteLine("0.Exit.");
                Console.Write("Chon: ");
                Console.WriteLine("----------------------------");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so Sinh Vien trong DS: ");
                        int sl = int.Parse(Console.ReadLine());
                        LuaChon(sl);
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:

                        ql.XuatStudenKhoaCNTT();
                        break;
                    case 4:
                        ql.XuatStudentDTBNhoHon5ThuocCNTT();

                        break;
                    case 5:
                        Console.Write("Nhap Quan: ");
                        string quan = Console.ReadLine();
                        ql.XuatTeacherQuan9(quan);
                        break;
                    case 6:
                        Console.Write("Nhap Ms Can tim: ");
                        string ms = Console.ReadLine();
                        ql.XuatTeacherTheoMs(ms);
                        break;
                    case 7:
                        ql.XuatStudentDTBCaoNhatThuocCNTT();
                        break;
                    default:
                        chon = 0;
                        break;
                }

            } while (chon != 0);
        }

        static void LuaChon(int sl)
        {
            for(int i = 0; i < sl; i++)
            {
                int chon;
                Console.WriteLine("1.Nhap Sinh Vien.");
                Console.WriteLine("2.Nhap Giao Vien.");
                Console.Write("chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapStudent();
                        break;
                    case 2:
                        ql.NhapTeacher();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
