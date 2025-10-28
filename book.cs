using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым!");
                title = value;
            }
        }
        public int Pages { get; set; } = 1; 

        public bool IsLong => Pages > 300; 

        public Book(string title)
        {
            Title = title; 
        }

        public void Info()
        {
            Console.WriteLine($"Книга: {title}, страниц: {Pages}, длинная: {(IsLong ? "да" : "нет")}");
        }
    }   
}
