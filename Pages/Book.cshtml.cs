using System;
using Admin_Web.Model;
using Admin_Web.Interface;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Web.Pages{

    public class BookModel: PageModel{
        public enum Action {Detail, Delete, Create, Update}
        private readonly IRepository _repository;
        public BookModel(IRepository repository){
            _repository = repository;
        }
        public Action Job{get; private set;}
        public Book Book{get; private set;}

        public void OnGet(int id){
            Job = Action.Detail;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "Book not found" : $"Book - {Book.Title}";
        }

        public void OnGetDelete(int id){
            Job = Action.Delete;
            Book = _repository.Get(id);
            ViewData["Title"]= Book==null ?"Book not found or delete fail": $"Confirm - {Book.Title} delete?";

        }
        
        public IActionResult OnGetConfirm(int id){
             Book = _repository.Get(id);
            bool IsDelete = _repository.Delete(id);
            return new RedirectToPageResult("index");
        }
        public void OnGetCreate(){
            Job = Action.Create;
            ViewData["Title"] = "Create a new Book";
        }
        public IActionResult OnPostCreate(Book book){
            Book = _repository.Create(book);
            _repository.Add(Book);
            return new RedirectToPageResult("Index");
        }
    }
}