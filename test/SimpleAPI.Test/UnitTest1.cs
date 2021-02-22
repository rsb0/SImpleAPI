using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        /* Create new test. Typically name test method after 
        what you expect a positive result to be */
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Rune Brekke", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
