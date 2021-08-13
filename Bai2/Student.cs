using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Student : Person
    {

        private float Diemtb;
        private string Khoavien;
        public float diemtb { get => Diemtb; set => Diemtb = value; }
        public string khoavien { get => Khoavien; set => Khoavien = value; }

        public Student() : base()
        {

        }

        public Student(string hoten, string ms, float diemtb, string khoavien) : base(hoten, ms)
        {
            Diemtb = diemtb;
            Khoavien = khoavien;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap DiemTB: ");
            Diemtb = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa Vien: ");
            Khoavien = Console.ReadLine();
        }
        public override string Tostring()
        {
            return base.Tostring() + " ,DiemTB: " + Diemtb + ",KhoaVien: " + Khoavien;
        }
    }

}
