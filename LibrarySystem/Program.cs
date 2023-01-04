
using LibrarySystem;

Media m1 = new Media("J.K Rowling", "The Hobbit", 2000, "NoStarchPress", 1);
Media m2 = new Media("Walt Disney", "Anders And", 2015, "Gyldendahl", 2);
Media m3 = new Media("Jussi Adler-Olsen", "Afdeling Q", 2010, "Saxo", 3);

Book b1 = new Book(100, "Suzanne Collins", "The Hunger Games", 2008, "Scholastic Press", 4);
Book b2 = new Book(101, "J.K Rowling", "Harry Potter and the Order of the Phoenix", 2004, "Scholastic Inc.", 5);
Book b3 = new Book(102, "Jane Austen", "Pride and Prejudice", 2000, "Modern Library", 6);

MediaCatalog mediacatalog = new MediaCatalog();

try { 
    mediacatalog.AddMedia(m1);
    mediacatalog.AddMedia(m2);
    mediacatalog.AddMedia(m3);
    mediacatalog.AddMedia(b1);
    mediacatalog.AddMedia(b2);
    mediacatalog.AddMedia(b3);
}
catch (Exception ex) {
    Console.WriteLine("The media is not valid" + ex.Message);
}

mediacatalog.PrintMediaList();

List<Media> testList = mediacatalog.GetMediaByAuthor("J.K Rowling");
foreach (var item in testList) {
    Console.WriteLine(item);
}

