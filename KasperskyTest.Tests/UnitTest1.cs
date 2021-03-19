using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KasperskyTest.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void typeHTML_processedAsHTML()
        {
            var factory = new FactoryFileProcessorHTML();
            var fileProcessor = factory.GetFileProcessor();


            Assert.AreEqual(new FileProcessorHTML().type, fileProcessor.type);
        }

        [TestMethod]
        public void typeText_processedAsText()
        {
            var factory = new FactoryFileProcessorText();
            var fileProcessor = factory.GetFileProcessor();


            Assert.AreEqual(new FileProcessorText().type, fileProcessor.type);
        }

        [TestMethod]
        public void typeJSON_processedAsJSON()
        {
            var factory = new FactoryFileProcessorJSON();
            var fileProcessor = factory.GetFileProcessor();


            Assert.AreEqual(new FileProcessorJSON().type, fileProcessor.type);
        }
    }
}
