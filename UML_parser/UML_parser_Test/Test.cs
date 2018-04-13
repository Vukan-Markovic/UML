using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using UML_parser;

namespace UML_parser_Test
{
    [TestFixture]
    class Test
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
            StringAssert.AreEqualIgnoringCase(expectedOutput, p.FormatPropertie(type, propertieName, accessor));
        }

        [TestCase("prijaviIspit", "public", "+prijaviIspit()")]
        [TestCase("ponistiOcenu", "public", "+ponistiOcenu()")]
        [TestCase("upisiGodinu", "protected", "#upisiGodinu()")]
        public void FormatMethodParamTest(string methodName, string accessor, string expectedOutput)
        {
            StringAssert.AreEqualIgnoringCase(expectedOutput, p.FormatMethod(methodName, accessor));
        }

        [TearDown]
        public void Message()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine(TestContext.CurrentContext.Test.FullName);
                Console.WriteLine(TestContext.CurrentContext.Result.Outcome + " test nije prosao");
            }
            else if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                Console.WriteLine(TestContext.CurrentContext.Test.FullName);
                Console.WriteLine(TestContext.CurrentContext.Result.Outcome + " test je prosao");
            }
        }
    }
}