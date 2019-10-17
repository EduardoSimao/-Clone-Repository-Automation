using GithubTestAutomation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GithubTestAutomation.Processamento
{
    class Login
    {
        public IWebDriver FazerLogin(IWebDriver chromeDriver, Usuario user)
        {
            Thread.Sleep(1000);

            IWebElement username = chromeDriver.FindElement(By.Id("login_field"));
            username.SendKeys(user.Login);
            Thread.Sleep(2000);

            IWebElement password = chromeDriver.FindElement(By.Id("password"));
            password.SendKeys(user.Senha);
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.Name("commit")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            return chromeDriver;
        }
    }
}
