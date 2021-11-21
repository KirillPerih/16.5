using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace ConsoleApplication45
    {
        public class Student
        {
            public Student(string name, string surname, string dateOfBirthday)
            {
                Name = name;
                Surname = surname;
                DateOfBirthday = dateOfBirthday;
            }

            public void ChangeName(Student student, string name)
            {
                if (student != null && student.Name != name)
                {
                    student.Name = name;
                }
            }

            public void ChangeSurname(Student student, string surname)
            {
                if (student != null && student.Name != surname)
                {
                    student.Surname = surname;
                }
            }

            public void ChangeDateOfBirthday(Student student, string dateOfBirthday)
            {
                if (student != null && student.Name != dateOfBirthday)
                {
                    student.DateOfBirthday = dateOfBirthday;
                }
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public string DateOfBirthday { get; set; }
        }
        class StudentGroup
        {
            List<Student> students = new List<Student>();

            public void AddStudent(string name, string surname, string dateOfBirthday)
            {
                Student student = new Student(name, surname, dateOfBirthday);
                students.Add(student);
            }

            public void RemoveStudent(Student student)
            {
                students.Remove(student);
            }

            public string GetStudent(int id)
            {
                return students[id].Name + " " + students[id].Surname + " " + students[id].DateOfBirthday;
            }

            public void ShowAllStudent()
            {
                Console.WriteLine("Все студенты: ");
                foreach (var student in students)
                {
                    Console.WriteLine(student.Name + "\t" + student.Surname + "\t" + student.DateOfBirthday);

                }
            }

            public int GetAmount()
            {
                return students.Count;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                var studentGroup = new StudentGroup();
                studentGroup.AddStudent("Masha", "Ivanova", "30.07.1986");
                studentGroup.AddStudent("Petya", "Petrov", "28.06.1985");
                studentGroup.AddStudent("Ivan", "Sidorov", "05.09.1987");

                Console.Write("Введите id = ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(studentGroup.GetStudent(id));

                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Введите дату рождения: ");
                string dateOfBirthday = Console.ReadLine();

                studentGroup.AddStudent(name, surname, dateOfBirthday);
                Console.Write("Введите id = ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(studentGroup.GetStudent(id));

                studentGroup.ShowAllStudent();
                Console.WriteLine("Общее количество студентов в группе " + studentGroup.GetAmount());

                Console.ReadKey();
            }
        }
    }
}
