using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BooksCalculatesAnAvarageGrade()
        {

           //arrange section
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(77.3);


           //act section
          var result =  book.GetStatistics();

           //assert section 
            Assert.Equal(85.6, result.Average, 1); //(resultado esperado, resultado atual, precisão nas casas decimais)
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
        }
    }

}

