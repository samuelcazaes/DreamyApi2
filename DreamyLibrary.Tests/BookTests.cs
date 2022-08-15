using Autofac.Extras.Moq;
using DreamyApi2.Controllers;
using DreamyApi2.Model;
using DreamyApi2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DreamyApi.Tests
{
    public class BookTests
    {
        //[Fact]
        //public void LoadBook_ValidCall()
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        // Arrange      
        //        var bkr = mock.Create<BookRepository>();

        //        //Act
        //        var actual = bkr.Get();

        //        //Assert
        //        Assert.True(actual != null);
        //    }
        //    throw new NotImplementedException();
        //}

        //public List<Book> GetSampleBooks()
        //{
        //    List<Book> bookList = new()
        //    {
        //        new Book
        //        {
        //            Title = "O senhor dos aneis",
        //            Author = "Tolkien",
        //            Description = "Pequenos hobbits se envolvendo em grandes " +
        //            "confusões por causa de um anel",
        //        },
        //        new Book
        //        {
        //            Title = "Hobbit",
        //            Author = "Tolkien",
        //            Description = "Pequenos hobbits se envolvendo em grandes " +
        //            "confusões por causa de um anel",
        //        },
        //        new Book
        //        {
        //            Title = "Harry Potter",
        //            Author = "J. K. Rowling",
        //            Description = "Um menino que se descobre bruxo vai para uma escola de magia" +
        //            "chamada Hogwarts ",
        //        }
        //    };
        //    return bookList;
        //}
    }
}

