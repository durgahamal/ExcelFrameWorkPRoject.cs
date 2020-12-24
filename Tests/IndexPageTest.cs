using ExcelFrameWorkPRoject.cs.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelFrameWorkPRoject.cs.Tests
{
    class IndexPageTest:BasePageTest
    {
        [Test]
        public void LogoTest()

        {
            IndexPageView indexPageView = new IndexPageView();
            bool islogpresent = indexPageView.LogoIsPresent();
            Assert.IsTrue(islogpresent);

        }

    }
}
