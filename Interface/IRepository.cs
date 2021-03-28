using System.Collections.Generic;

using Admin_Web.Model;

namespace Admin_Web.Interface
{
    public interface IRepository
    {
        public HashSet<Book> Books { get; set; } 
        public Book Get(int id);

        public bool Delete(int id);
        public Book Create(Book book);
        public bool Add(Book book);
    }
}
