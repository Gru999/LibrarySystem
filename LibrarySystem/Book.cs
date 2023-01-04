using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem {
    public class Book : Media{
        public int ISBN { get; set; }
        public Book(int isbn, string author, string title, int year, string publisher, int mediaId) : base(author, title, year, publisher, mediaId){ 
            ISBN = isbn;
        }

        //find way to get _mediaId
        public override string ToString() {
            return $"Author: {Author}, Title: {Title}, Year: {Year}, Publisher: {Publisher}, ISBN: {ISBN}";
        }
        //Polymorphism is changes from a base class to a sub class
        //(the methods and construtorrs that change)
    }
}
