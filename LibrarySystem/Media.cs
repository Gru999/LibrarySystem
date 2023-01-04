using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Media
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }

        private int _mediaId;

        public int MediaID
        {
            get { return  _mediaId;; }
            //set {  _mediaId; = value; }
        }

        public Media(string author, string title, int year, string publisher, int mediaId)
        {
            //Possible way to check year
            //if (year < 2010) {
            //    throw new ArgumentException("Materialet er fra før 2010");
            //}
            Author = author;
            Title = title;
            Year = year;
            Publisher = publisher;
            _mediaId = mediaId;
        }

        public override string ToString()
        {
            return $"Author: {Author}, Title: {Title}, Year: {Year}, Publisher: {Publisher}, MediaID: {_mediaId}";
        }
    }
}
