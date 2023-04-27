using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Helpers;

namespace TestProject1.Fixtures
{
    public class TestFixture : IDisposable
    {
        // Funções SETUP e TEARDOWN do meu teste
        public IWebDriver drive { get; private set; }

        public TestFixture()
        {
            drive = new ChromeDriver(TestHelper.PastaChromeDriver);
        }

        public void Dispose()
        {
            drive.Quit();
        }
    }
}
