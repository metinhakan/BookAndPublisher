// See https://aka.ms/new-console-template for more information

using BookAndPublisher.Models;


BookPublisherDataContext db = new BookPublisherDataContext();


//Add publishers to the database
Publisher publisher = new Publisher()
{
    PublisherName = "Can Yayınları"
};
Publisher publisher1 = new Publisher()
{
    PublisherName = "Doğan Kitap"
};
Publisher publisher2 = new Publisher()
{
    PublisherName = "İş Bankası Yayınları"
};
db.Publisher.Add(publisher);
db.Publisher.Add(publisher1);
db.Publisher.Add(publisher2);
db.SaveChanges(); 
    

//Add books to the database
Books books1 = new Books()
{
    BookName = "De Profundis",
    BookPublisherId = 1
};

Books books2 = new Books()
{
    BookName = "Med-Cezir",
    BookPublisherId = 2
};


Books books3 = new Books()
{
    BookName = "Yakıcı Sır",
    BookPublisherId = 3
};

db.Books.Add(books1);
db.Books.Add(books2);
db.Books.Add(books3);
db.SaveChanges();

List<Books> books = db.Books.ToList();
foreach (Books book in books)
{
    Console.WriteLine($"Book Name:{book.BookName}"); //get all the books in the list 

    if (book.Id == 2)  //get book with specific id
    {
        Console.WriteLine("İki numaralı kitap " + book.BookName);
    }
}


var booktochange = db.Books.Where(a => a.Id == 4).FirstOrDefault();  //changes the book name that's id = 3.
if (booktochange != null)
{
    booktochange.BookName = "Amok Koşucusu";
    
}

else
{
    Console.WriteLine("Book not found");
}

db.SaveChanges();







