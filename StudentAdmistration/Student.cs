using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmistration
{
    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<double> Grades { get; set; }

        public Student(string name, int id, List<double> grades)
        {
            Name = name;
            Id = id;
            Grades = grades;
        }

        internal static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Skriv inn Navn:");
            string name = Console.ReadLine();
            Console.WriteLine("skriv inn id");
            string idInput = Console.ReadLine();
            int id = Convert.ToInt32(idInput);
            List<double> grades = new List<double>();

            while (true) {
                Console.WriteLine("skriv inn en karakter (eller 'a' for å avslutte! ");
                string gradeInput = Console.ReadLine();
                if(gradeInput.ToLower() == "a")
                {
                    break;
                }
                if (double.TryParse(gradeInput, out double grade)) { 
                        grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("ugyldig karakter, prøv igjen");
                }
                Student student = new Student(name, id, grades);    
                students.Add(student);

                Console.WriteLine("student lagt til");

             
            }
        }
        internal static void ShowAllStudents(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("ingen studenter");
                return;
            }
            foreach(var student in students)
            {
                Console.WriteLine($"Navn: {student.Name}, Studentnummer: {student.Id}, Karakterer: {string.Join(", ", student.Grades)}");
            }
           
        }

        internal static void CalculateAverageGrade(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("ingen studenter");
                return;
            }
            double total = 0;
            int totalGrades = 0;

            foreach (var student in students) {
                total += student.Grades.Sum();
                totalGrades += student.Grades.Count();
            }
            double average = total / totalGrades;
            Console.WriteLine($"gjennomsnittskarakteren for alle studenter er: {average:F2}");
        }
    }
}
