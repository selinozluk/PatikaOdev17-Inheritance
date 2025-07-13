using Inheritance.Models;

class Program
{
    static void Main (string[] args)
    {

        // Öğretmen nesnesi
        Teacher teacher = new Teacher
        {
            FirstName = "Finneas",
            LastName = "O'Connell",
            Salary = 10000
        };

        // Öğrenci nesnesi
        Student student = new Student
        {
            FirstName = "Billie",
            LastName = "Eilish",
            StudentNumber = "181201"
        };

        // Öğretmen bilgilerini yazdırıyor
        Console.WriteLine("Öğretmen Bilgileri: ");
        teacher.PrintTeacherInfo();

        Console.WriteLine("\n ----------------------------- \n ");

        // Öğrenci bilgilerini yazdırıyor
        Console.WriteLine("Öğrenci Bilgileri: ");
        student.PrintStudentInfo();
    }
}
