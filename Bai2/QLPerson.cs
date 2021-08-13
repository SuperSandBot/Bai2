using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class QLPerson
    {
        public List<Person> Persons;

        public QLPerson()
        {
            Persons = new List<Person>();
        }

        public void NhapStudent()
        {
            Person p = new Student();

            p.Input();

            Persons.Add(p);
        }
        public void NhapTeacher()
        {
            Person p = new Teacher();

            p.Input();

            Persons.Add(p);
        }

        public void XuatDS()
        {
            Console.WriteLine("--------DSStudent----------");
            XuatDSStudent(StudentList());
            Console.WriteLine("--------DSTeacher----------");
            XuatDSTeacher(TeacherList());
        }

        public void XuatDSStudent(List<Student> list)
        {
            Console.WriteLine("--------DSStudent----------");
            int i = 1;
            foreach (Student s in list)
            {
                Console.WriteLine(i + "." + s.Tostring());
                i++;
            }
        }

        public void XuatDSTeacher(List<Teacher> list)
        {
            Console.WriteLine("--------DSTeacher----------");
            int i = 1;
            foreach (Teacher t in list)
            {
                Console.WriteLine(i + "." + t.Tostring());
                i++;
            }
        }

        public List<Student> StudentList()
        {
            List<Student> list = new List<Student>();

            foreach(Person p in Persons)
            {
                if(p is Student)
                {
                    list.Add((Student)p);
                }
            }
            return list;
        }

        public List<Teacher> TeacherList()
        {
            List<Teacher> list = new List<Teacher>();

            foreach (Person p in Persons)
            {
                if (p is Teacher)
                {
                    list.Add((Teacher)p);
                }
            }
            return list;
        }

        public void XuatStudenKhoaCNTT()
        {
            List<Student> List = StudentList().Where(p => p.khoavien == "CNTT").ToList();

            XuatDSStudent(List);
        }

        public void XuatStudentDTBNhoHon5ThuocCNTT()
        {
            List<Student> List = StudentList().Where(p => p.diemtb >= 5 && p.khoavien == "CNTT").ToList();

            XuatDSStudent(List);
        }

        public void XuatTeacherQuan9(string s)
        {
            List<Teacher> List= TeacherList().Where(p => p.diachi.StartsWith(s)).ToList();

            XuatDSTeacher(List);
        }

        public void XuatTeacherTheoMs(string s)
        {
            List<Teacher> List = TeacherList().Where(p => p.ms == s).ToList();

            XuatDSTeacher(List);
        }

        public void XuatStudentDTBCaoNhatThuocCNTT()
        {
            List<Student> List = StudentList().Where(p => p.khoavien == "CNTT").ToList();

            Student s = List.OrderBy(p => p.diemtb).Last();

            Console.WriteLine(s.Tostring());
        }
    }
}
