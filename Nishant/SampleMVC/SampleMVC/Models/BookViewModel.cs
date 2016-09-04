using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class BookViewModel
    {
        public Book[] Books
        {
            set;
            get;
        }

        public void FillBooks()
        {
            using (CartClient client = new CartClient())
            {
                Books = client.getItemByTitle(string.Empty);
            }
        }
    }
}