using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace HelloWorld
{
    [TestFixture]
    class Class1
    {
        [Test]
        public void FirstTest()
        {
            Assert.True(true);
        }
    }
}
