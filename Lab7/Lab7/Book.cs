using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Book : IComparable
    {
         string author;
         string title;
         int pages;
         int year;
       
        public string Format(object value)
        {
            
            return year.ToString();
        }
        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
        public void SetBook(String author, String title, int pages,
int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("Книга: Автор: {0} Название: {1}Год издания:{3}  {2}стр.", author, title, pages,year);
 }
    }
   
    }
