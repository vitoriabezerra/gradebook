using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]

        public void Test1()
        {

            //arrange section
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");


            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        public void GetBookReturnsDifferentObjects()
        {

            //arrange section
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2); // sã dois objetos distintos

        }
        public void TwoVarsCanReferenceSameObbect()
        {

            //arrange section
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2); //teste para ver se os dois estão apontando para o mesmo objeto em memoria.
            Assert.True(Object.ReferenceEquals(book1,book2)); //mostra se os ambos estão sob a mesma referência.

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }

}