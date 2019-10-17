using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace GithubTestAutomation.Inicialização
{
    class Config
    {
        public static IWebDriver ConfigNavegadorChrome()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://github.com/login");
            chromeDriver.Manage().Window.Maximize();

            return chromeDriver;
        }
    }
}
