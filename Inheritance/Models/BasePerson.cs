using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    
    internal class BasePerson
    {
        // Ad özelliği
        public string FirstName { get; set; }
        
        // Soyad özelliği
        public string LastName { get; set; }

        // Ad ve soyad bilgilerini yazdıran metot
        public void PrintFullName()
        {
            Console.WriteLine($"Ad ----> {FirstName}");
            Console.WriteLine($"Soyad ----> {LastName}");
        }
    }
}
