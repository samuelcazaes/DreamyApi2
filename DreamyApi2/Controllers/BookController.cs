using DreamyApi2.Model;
using DreamyApi2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamyApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        public readonly IBookRepository _bk;
        public BookController(IBookRepository bk)
        {
            _bk = bk;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                return Ok(await _bk.Get());
            }
            catch
            {
                return null;
            }            
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBooksById(int id)
        {
            try
            {
                return Ok(await _bk.Get(id));
            }
            catch
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveBooks([FromBody] Book book)
        {
            try
            {         
                return Ok(await _bk.Save(book));
            }
            catch
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                var bookToDelete = await _bk.Get(id);

                if (bookToDelete == null)
                    return NotFound();

                await _bk.Delete(bookToDelete.Id);
                return Ok();
            }
            catch
            {
                return null;
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            try
            {
                if (id == book.Id)
                    return BadRequest();
                    await _bk.Update(book);
                return Ok();
            }
            catch
            {
                return null;
            }
        }


    }
}
