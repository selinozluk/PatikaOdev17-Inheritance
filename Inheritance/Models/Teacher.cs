using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    // BasePerson içerisindeki özellikleri çekiyor
    internal class Teacher : BasePerson
    {
        public decimal Salary { get; set; }

        // Maaş bilgisi, ad ve soyadı yazdıran metot
        public void PrintTeacherInfo()
        {
            Console.WriteLine($"Maaş ----> {Salary}");
            PrintFullName(); // BasePerson'dan metodu çağırır
        }
    }
}
