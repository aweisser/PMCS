using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMCS.Classes;

namespace PMCSTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void ParseNamespace()
        {
            Parser p = new Parser(new InputSource()
            {
                FileCount = 1,
            });
        }
    }
}
