using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Skyline.DataMiner.Automation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ScriptTests
    {
        [TestMethod()]
        public void RunTest()
        {
            var s = new Script();
            Mock<IEngine> fakeEngine = new Mock<IEngine>();
            s.Run(fakeEngine.Object);
            Assert.Fail();
        }
    }
}