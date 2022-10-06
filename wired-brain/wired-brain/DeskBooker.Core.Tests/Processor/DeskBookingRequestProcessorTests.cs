using System;
using Xunit;
using DeskBooker.Core.Domain;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        private readonly DeskBookingRequestProcessor _processor;

        public DeskBookingRequestProcessorTests()
        {
           _processor = new DeskBookingRequestProcessor();
        }

        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValues()
        {
        // arrange
        var request = new DeskBookingRequest
        {
            FirstName = "Thiago André de",
            LastName = "Almeida",
            Email = "sac@thiagoalmeida.info",
            DateTime = new DateTime(2022, 10, 29)
        };
         //act
         DeskBookingResult result = _processor.BookDesk(request);

            //assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.DateTime, result.DateTime);
        }

        [Fact]
        public void ShouldReturnArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookDesk(null));
            Assert.Equal("request", exception.ParamName);
        }
    }
}