using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{

    // BasePerson'dan miras alıyor
    internal class Student : BasePerson
    {
        // Öğrenci numarası
        public string StudentNumber { get; set; }

        // Öğrenci bilgilerini yazdıran metot
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Öğrenci No ----> {StudentNumber}");
            PrintFullName(); // Ad ve soyad bilgilerini yazdırır
        }

        
    }
}
