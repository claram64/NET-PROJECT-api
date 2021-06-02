using NET_PROJECT_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NET_PROJECT_api.Controllers
{

    public class BooksController : ApiController
    {

        List<Book> books = new List<Book>();

        public BooksController()
        {//aici sunt cartile si ar trebui descarcate cu un call sau ceva?
            books.Add(new Book { Title="The castle", Author="Kafka",Id= 1 });
            books.Add(new Book { Title = "Alice in wonderland", Author = "unknown", Id = 2 });
            books.Add(new Book { Title = "Brothers Karamazov", Author = "Dost", Id = 3 });
            books.Add(new Book { Title = "Faust", Author = "Goethe", Id = 4 });
        }

        // GET: api/Books
        public List<Book> Get()
        {
            return books;
        }

        // GET: api/Books/5
        public Book Get(int id)
        {
            return books.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Books
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
        }
    }
}
