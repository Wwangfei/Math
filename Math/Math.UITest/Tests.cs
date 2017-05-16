using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Math.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            
           // app.Repl();
            app.WaitForElement(e => e.Marked("Try This"));
            app.Tap("Try This");
            app.WaitForElement(e => e.Marked("Question 1"));
        }

        [Test]
        public void QuestionOne()
        {

        }

        [Test]
        public void QuestionTwo()
        {

        }

        [Test]
        public void QuestionThree()
        {

        }


    }
}

