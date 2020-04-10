using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class TestTest
    {
        [Fact]
        public void AddTwoNumbers()
        {
            var actual = 12 + 50;
            var expected = 62;

            Assert.Equal(expected, actual);
        }
    }
}
