using System;
using Xunit;
using FakeItEasy;
using TandVark.Domain.Repositories.Interfaces;
using TandVark.Domain.Models.Interfaces;
using TandVark.Domain.Models;
using System.Collections.Generic;


using TandVark_ASP.NETCORE_REACT.Controllers;

using System.ComponentModel.DataAnnotations;


namespace TandVark.Test
{
    public class TandVarkTests
    {
        [Theory]
        [InlineData(true, null, "Authenticated")]          // Valid input
        [InlineData(false, "0x003", "Not authenticated")]
        public void AuthenticateCard_ParameterizedInput_AuthenticationWillOnlyWorkWithValidInputAndCorrectErrorMessagesWillBeReturned(bool isValid, string errorCode, string message)
        {
            //Arrange
            
            var expectedAuthenticationResult = isValid;
            var expectedMessage = message;
            var expectedErrorCode = errorCode;

            var fakeUser = A.Fake<User> ();
            var fakeRepository = A.Fake<IUserRepository>();


             A.CallTo(() => fakeRepository.AuthenticateUser(fakeUser)).Returns(expectedAuthenticationResult);
              

            var sut = new AuthenticationController(fakeRepository);

            //Act
            var result = sut.AuthenticateUser(fakeUser);

            //Assert
            Assert.Equal(expectedAuthenticationResult, result.Authenticated);
            Assert.Equal(expectedMessage, result.Message);
            Assert.Equal(expectedErrorCode, result.Code);
        }

    }
}
