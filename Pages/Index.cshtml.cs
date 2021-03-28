using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Admin_Web.Repository;

using Admin_Web.Interface;
namespace Admin_Web.Pages
{
    public class IndexModel : PageModel
    {
      
        private readonly IRepository _repository;
        public HashSet<Model.Book> Books =>_repository.Books;
        public int Count => _repository.Books.Count;
        public IndexModel(IRepository repository) => _repository = repository;

        public void OnGet()
        {

        }
    }
}
