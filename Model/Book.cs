using System;

namespace Admin_Web.Model{
    public class Book{
        
        private int _id;
        public int Id{
            get{return _id;}
            set{_id = value;}
                }
        private string _title = "A new Book";
        public string Title{get=> _title;
        set{_title=value;}}
        public string Authors{get; set;} = "Authors";
        public string Publisher{get;set;} = "Publisher";
        public int Year = DateTime.Now.Year;
        public string Description{get; set;} = "";


    }
}