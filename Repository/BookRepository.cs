using System.Collections.Generic;
using System.Linq;

using Admin_Web.Interface;
using Admin_Web.Model;

namespace Admin_Web.Repository{
    public class BookRepository : IRepository {
        public HashSet<Book> Books {get;set;} = new HashSet<Book> {
            new Book {Id = 1, Title = "ASP.NET Core for dummy",Publisher = "Apress", Year = 2018, Authors = "Donald Trump"},
            new Book{Id =2, Title = "Alo Book2", Publisher = "Publisher2", Year = 2018, Authors = "Authors2"},
            new Book{Id =3, Title = "Alo Book3", Publisher = "Publisher3", Year = 2018, Authors = "Authors3"},
            new Book{Id =4, Title = "Alo Book4", Publisher = "Publisher4", Year = 2018, Authors = "Authors4"},
            new Book{Id =5, Title = "Alo Book5", Publisher = "Publisher5", Year = 2018, Authors = "Authors5"}
        };

        public Book Get(int id) => Books.SingleOrDefault(b=>b.Id==id);

        public bool Delete(int id) {
            var book = Get(id);
            return book!=null?Books.Remove(book):false;
        }

        public Book Create(Book book){
            var max = Books.Max(b=>b.Id);
            var newBook = new Book(){Id=++max, Authors=book.Authors, Title=book.Title, Publisher=book.Publisher,Year=book.Year, Description=book.Description};
            return newBook;}
        public bool Add(Book book){
            return Books.Add(book);
            
        }

    }
}
