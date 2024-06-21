namespace StudentAdmistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Legg til en student
            //Vis alle studenter
            //Beregn gjennomsnittskarakter for alle studenter
            //Avslutt

            List<Student> students = new List<Student>();
            Console.WriteLine("Velkommen til stundetoversikten");
            Console.WriteLine("1. for å legge til student");
            Console.WriteLine("2. for å vise alle studentene");
            Console.WriteLine("3. for å bergene grannomsnittskarakterer for alle studentene");

            Student therese = new Student("therese", 2, [2, 4, 6, 4, 5]);
            Student linn = new Student("linn", 2, [3, 4, 3, 4, 3]);
            Student rebecka = new Student("rebecka", 2, [6, 5, 6, 4, 5]);
            students.Add(therese);
            students.Add(linn);
            students.Add(rebecka);

            var userChoice = Console.ReadLine();
            int choice = Convert.ToInt32(userChoice);
            if (choice == 1)
            {
                Student.AddStudent(students);
            }
            else if (choice == 2)
            {
                Student.ShowAllStudents(students);

            }
            else if (choice == 3)
            {
                Student.CalculateAverageGrade(students);
            }
            else { Console.WriteLine("ugyldig input"); }
            
        }
    }
}
