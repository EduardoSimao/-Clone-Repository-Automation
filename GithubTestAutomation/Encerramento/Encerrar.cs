using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GithubTestAutomation.Encerramento
{
    class Encerrar
    {
        public static void FecharBrowser(IWebDriver driver)
        {
            driver.Quit();
        }

    }
}
