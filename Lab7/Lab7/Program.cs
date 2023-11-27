using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            object[] books = new object[] { book1, book2,book3,book4,book5};
            
            
            book1.SetBook("aboba","amobus",30,1980);
            book2.SetBook("aboba", "amobus", 30, 1480);
            book3.SetBook("aboba", "amobus", 30, 1983);
            book4.SetBook("aboba", "amobus", 30, 1946);
            book5.SetBook("aboba", "amobus", 30, 1540);
            book1.Show();
            Array.Sort(books);
            string ab = book1.Format(book1);
            Console.WriteLine(ab);

            foreach(object b in books)
            {
                Book ini = (Book)b;
                string a = ini.Format(ini);
                Console.WriteLine("Book year ={0}",a);
            }
            Console.Read();
        }
        
           
        
    }
}
