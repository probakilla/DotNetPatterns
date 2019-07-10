using DotNetPatterns.Creational.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPatterns.Creational
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void TestPrototypeCopy()
        {
            Screen screen = new LedScreen(32);
            Screen clonedScreen = screen.Clone();
            Assert.AreEqual(32, clonedScreen.Size);
        }

        [TestMethod]
        public void TestPrototypeCopyModification()
        {
            Screen screen = new LedScreen(32);
            Screen cloned = screen.Clone();
            cloned.Size = 42;
            Assert.AreEqual(32, screen.Size);
        }
    }
}
