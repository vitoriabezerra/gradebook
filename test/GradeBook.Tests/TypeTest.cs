using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]


         public void Test()
        {

            //arrange section
            var value = GetInt();
            SetInt(ref value);
            Assert.Equal(4, value);

        }

        private void SetInt(ref int x)
        {
            x = 4;
        }

        private int GetInt()//estou passando por referência a localização de onde a variavel está armazenada.
        {
            return 3; //contruindo uma instancai 
        }
        public void CSharpIsPassedByRef()
        {

            //arrange section
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");


            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(out Book book, string name)//estou passando por referência a localização de onde a variavel está armazenada.
        {
            book = new Book(name); //contruindo uma instancai 

        }

        public void CSharpIsPassedByValue()
        {

            //arrange section
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");


            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name); //contruindo uma instancai 

        }

        public void CanSetNameFromReference()
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