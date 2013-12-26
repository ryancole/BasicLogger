using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicLogger;

namespace BasicLogger.Test
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            Logging.Enabled = true;
        }

        [TestMethod]
        public void CanWriteLine()
        {
            Logging.WriteLine("Test @ {0}", DateTime.Now);
        }
    }
}
