

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTest;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        IWordProcessor wordProcessor = new WordProcessor();

        [TestMethod]
        public void WordSort()
        {        
            Assert.AreEqual("Boom Zoom", wordProcessor.BeautifyText("Zoom Boom"));
        }

        [TestMethod]
        public void CaseSort()
        {        
            Assert.AreEqual("Boom boom", wordProcessor.BeautifyText("boom Boom"));
        }

         [TestMethod]
        public void RemoveInvalidChars()
        {        
            Assert.AreEqual("b b", wordProcessor.BeautifyText("b, b"));
        }

        [TestMethod]
        public void SimpleTest1()
        {        
            Assert.AreEqual("baby Go go", wordProcessor.BeautifyText("Go baby, go"));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Assert.AreEqual("ABC aBc abc CBA CBA cba", wordProcessor.BeautifyText("CBA, abc aBc ABC cba CBA."));
        }

        [TestMethod]
        public void EmptyStringReturnsEmpty()
        {
            Assert.AreEqual(string.Empty, wordProcessor.BeautifyText(string.Empty));
        }
    }
}