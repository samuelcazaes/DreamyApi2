using DreamyApi2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamyApi2.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BookContext _db;
        public BookRepository(BookContext db)
        {
            _db = db;
        }
        public async Task Delete(int id)
        {
            try
            {
                var bookToDelete = await _db.Books.FindAsync(id);
                _db.Books.Remove(bookToDelete);
                await _db.SaveChangesAsync();
            }
            catch (Exception) 
            {
                
            }
        }

        public async Task<IEnumerable<Book>> Get()
        {
            try
            {
               return await _db.Books.ToListAsync();
            }
            catch (Exception) 
            { 
                return null;
            }
        }

        public async Task<Book> Get(int id)
        {
            try
            {
                return await _db.Books.FindAsync(id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Book> Save(Book book)
        {
            try
            {
                _db.Books.Add(book);
                await _db.SaveChangesAsync();

                return book;
            }
            catch (Exception) 
            { 
                return null;
            }
        }

        public async Task Update(Book book)
        {
            try
            {
                _db.Entry(book).State = EntityState.Modified;
                await _db.SaveChangesAsync();
            }
            catch
            {
                
            }
        }
    }
}
