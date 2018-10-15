using System;
using Xunit;
using FakeItEasy;
using TandVark.Domain.Repositories.Interfaces;
using TandVark.Domain.Models.Interfaces;
using TandVark_ASP.NETCORE_REACT.Controllers;

using System.ComponentModel.DataAnnotations;


namespace TandVark.Test
{
    public class TandVarkTests
    {
        [Theory]
        [InlineData("1234", true, null, "Authenticated", false)]          // Valid input
        public void AuthenticateCard_ParameterizedInput_AuthenticationWillOnlyWorkWithValidInputAndCorrectErrorMessagesWillBeReturned(string testPassword, bool isValid, string errorCode, string message, bool willThrow)
        {
            //Arrange
            var pin = testPassword;
            var expectedAuthenticationResult = isValid;
            var expectedMessage = message;
            var expectedErrorCode = errorCode;

            var fakeCard = A.Fake<IUser>();
            var fakeRepository = A.Fake<IUserRepository>();

            (!willThrow ? (Action)
                (() => A.CallTo(() => fakeRepository.AuthenticateUser(fakeCard, pin)).Returns(expectedAuthenticationResult)) :
                (() => A.CallTo(() => fakeRepository.AuthenticateUser(fakeCard, pin)).Throws(new ArgumentException())))();

            var sut = new AuthenticationController(fakeRepository);

            //Act
            var result = sut.AuthenticateUser(fakeCard, pin);

            //Assert
            Assert.Equal(expectedAuthenticationResult, result.Authenticated);
            Assert.Equal(expectedMessage, result.Message);
            Assert.Equal(expectedErrorCode, result.Code);
        }
    }
}
