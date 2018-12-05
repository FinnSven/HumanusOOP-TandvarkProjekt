using TandVarkSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TandVarkSQL.Tests
{
    public class TestingTests
    {
        [Fact]
        public void AddUserTest_InCorrectInputInt()
        {
            
            var result = new ValidatorInt().Validate("abcs");
            Assert.False(result.IsValid);
        }
        [Fact]
        public void AddUserTest_CorrectInputInt()
        {
            var result = new ValidatorInt().Validate("12345");
            Assert.True(result.IsValid);
        }
        [Fact]
        public void AddUserTest_InCorrectInputIntChar()
        {
            var result = new ValidatorInt().Validate("12ThreeFour56");
            Assert.False(result.IsValid);
        }
        [Fact]
        public void AddUserTest_CorrectInputCharName()
        {
            var result = new Validator().Validate("James");
            Assert.True(result.IsValid);
        }
        [Fact]
        public void AddUserTest_InCorrectInputCharName()
        {
            var result = new Validator().Validate("");
            Assert.False(result.IsValid);
        }
        [Fact] 
        public void AddUserTest_InCorrectInputCharNameShort()
        {
            var result = new Validator().Validate("At");
            Assert.False(result.IsValid);
        }
        [Fact]
        public void AddUserTest_CorrectInputCharPass()
        {
            var result = new Validator().Validate("Enter");
            Assert.True(result.IsValid);
        }
        [Fact]
        public void AddUserTest_IncorrectInputCharPass()
        {
            var result = new Validator().Validate("");
            Assert.False(result.IsValid);
        }
        [Fact]
        public void AddUserTest_IncorrectInputCharPassShort()
        {
            var result = new Validator().Validate("123");
            Assert.False(result.IsValid);
        }
    }
}