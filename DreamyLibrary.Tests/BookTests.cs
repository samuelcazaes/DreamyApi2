using Autofac.Extras.Moq;
using DreamyApi2.Controllers;
using DreamyApi2.Model;
using DreamyApi2.Repositories;
using Microsoft.AspNetCore.Http;
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
        private readonly BookController _bookCtrl;
        private readonly Mock<IBookRepository> _bookR;
        public BookTests()
        {

            _bookR = new Mock<IBookRepository>();
            _bookCtrl = new BookController(_bookR.Object);
        }



        [Fact]
        public void BooksControllerGetMethod_ValidHttpResponse()
        {
            //Arrange
          
            //Act
            var actual = _bookCtrl.GetBooks().Result as OkObjectResult;

            //Assert
            Assert.True(actual != null);
            Assert.Equal(StatusCodes.Status200OK, actual.StatusCode);
        }

        [Fact]
        public void BooksControllerSaveMethod_ValidHttpResponse()
        {
            //Arrange           
            var testObject = GetSampleBooks()[0];

            //Act
            var actual = _bookCtrl.SaveBooks(testObject).Result as OkObjectResult;

            //Assert
            Assert.True(actual != null);
            Assert.Equal(StatusCodes.Status200OK, actual.StatusCode);
        }

        [Fact]
        public void BooksControllerGetByIdMethod_ValidHttpResponse()
        {
            //Arrange
            var testId = GetSampleBooks()[2].Id;

            //Act
            var actual = _bookCtrl.GetBooksById(testId).Result as OkObjectResult;

            //Assert
            Assert.True(actual != null);
            Assert.Equal(StatusCodes.Status200OK, actual.StatusCode);
        }

        public List<Book> GetSampleBooks()
        {
            List<Book> bookList = new()
            {
                new Book
                {
                    Id = 1,
                    Title = "O senhor dos aneis",
                    Author = "Tolkien",
                    Description = "Pequenos hobbits se envolvendo em grandes " +
                    "confusões por causa de um anel",
                },
                new Book
                {
                    Id = 2,
                    Title = "Hobbit",
                    Author = "Tolkien",
                    Description = "Pequenos hobbits se envolvendo em grandes " +
                    "confusões por causa de um anel",
                },
                new Book
                {
                    Id = 3,
                    Title = "Harry Potter",
                    Author = "J. K. Rowling",
                    Description = "Um menino que se descobre bruxo vai para uma escola de magia" +
                    "chamada Hogwarts ",
                }
            };
            return bookList;
        }
    }
}

