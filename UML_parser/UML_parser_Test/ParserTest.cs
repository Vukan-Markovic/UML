using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using UML_parser;

namespace UML_parser_Test
{
    [TestFixture]
    class ParserTest
    {
        Parser p;
  
        [OneTimeSetUp]
        public void SetUp()
        {
            p = new Parser();
        }

        [TestCase("string", "ime", "private", "-ime: string")]
        [TestCase("string", "prezime", "private", "-prezime: string")]
        [TestCase("string", "mesto", "private", "-mesto: string")]
        public void FormatPropertieParamTest(string type, string propertieName, string accessor, string expectedOutput)
        {
            Assert.AreEqual(expectedOutput, p.FormatPropertie(type, propertieName, accessor), "Provera pravilnog formatiranja propertija.");
        }

        [TestCase("prijaviIspit", "public", "+prijaviIspit()")]
        [TestCase("ponistiOcenu", "public", "+ponistiOcenu()")]
        [TestCase("upisiGodinu", "protected", "#upisiGodinu()")]
        public void FormatMethodParamTest(string methodName, string accessor, string expectedOutput)
        {
            Assert.AreEqual(expectedOutput, p.FormatMethod(methodName, accessor), "Provera pravilnog formatiranja metode.");
        }

        [TearDown]
        public void MessagesAfterTests()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                Console.WriteLine(TestContext.CurrentContext.Test.FullName + " test je prosao");
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine(TestContext.CurrentContext.Test.FullName + " test nije prosao");
            }

            TestContext.Out.WriteLine(TestContext.CurrentContext.Result.Outcome);
        }
    }
}