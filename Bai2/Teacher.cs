using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Teacher : Person
    {
        private string Diachi;
        public string diachi { get => Diachi; set => Diachi = value; }

        public Teacher() : base()
        {

        }

        public Teacher(string hoten, string ms, string diachi) : base(hoten, ms)
        {
            Diachi = diachi;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Dia Chi: ");
            Diachi = Console.ReadLine();
        }
        public override string Tostring()
        {
            return base.Tostring() + ",DiaChi: " + Diachi;
        }
    }
}
