using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Person
    {
        private string Hoten;
        private string Ms;
        public string hoten { get => Hoten; set => Hoten = value; }
        public string ms { get => Ms; set => Ms = value; }

        public Person()
        {

        }

        public Person(string hoten, string ms)
        {
            Hoten = hoten;
            Ms = ms;
        }

        public virtual void Input()
        {
            Console.Write("Nhap Hoten SV: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap Mssv: ");
            Ms = Console.ReadLine();
        }
        public virtual string Tostring()
        {
            return "Hoten: " + Hoten + " ,Mssv: " + Ms;
        }
    }
}
