using BackgroundQueue.API.Background;
using BackgroundQueue.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundQueue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBackgroundQueue<Book> queue;

        public BooksController(IBackgroundQueue<Book> queue)
        {
            this.queue = queue;
        }

        [HttpPost]
        public IActionResult Publish([FromBody] Book book)
        {
            queue.Enqueue(book);
            return Accepted();
        }
    }
}
