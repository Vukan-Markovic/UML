using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using UML_parser;
using System.Windows.Forms;

namespace UML_parser_Test
{
    [TestFixture]
    class ParserTests
    {
        Parser p;
        object obj;
        EventArgs e;
        MouseEventArgs click;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            obj = new object();
            e = new EventArgs();
            click = new MouseEventArgs(MouseButtons.Middle, 1, 160, 160, 1);
        }

        [SetUp]
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

        [Test]
        public void ClearScreenButtonTest()
        {
            p.BtnClearScreen_Click(obj, e);

            Assert.Multiple(() =>
            {
                Assert.Zero(p.ListOfClasses.Count, "Provera da li su nakon pritiska na dugme Clear screen izbrisane sve klase.");
                Assert.Zero(p.ListOfRelationships.Count, "Provera da li su nakon pritiska na dugme Clear screen izbrisane sve veze.");
            });
        }

        [Test]
        public void DrawClassTest()
        {
            p.rdbClass.Checked = true;
            p.txtClassName.Text = "student";
            p.PnlCenter_MouseClick(obj, click);

            Assert.AreEqual(1, p.ListOfClasses.Count, "Provera iscrtavanja klase.");
        }

        [Test]
        public void ClassNameTest()
        {
            p.rdbClass.Checked = true;
            p.txtClassName.Text = "student";
            p.PnlCenter_MouseClick(obj, click);

            Assert.AreEqual("student", p.ListOfClasses[0].Name, "Provera dodeljivanja imena unetog od strane korisnika klasi prilikom iscrtavanja.");
        }

        [Test]
        public void SelectClassTest()
        {
            p.rdbClass.Checked = true;
            p.txtClassName.Text = "predmet";
            p.PnlCenter_MouseClick(obj, click);

            p.rdbSelectTool.Checked = true;
            p.PnlCenter_MouseClick(obj, click);

            Assert.True(p.ListOfClasses[0].Selected, "Provera selektovanja klase.");
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