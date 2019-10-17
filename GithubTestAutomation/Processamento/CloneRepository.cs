using GithubTestAutomation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GithubTestAutomation.Processamento
{
    class CloneRepository
    {
        public IWebDriver ClonarRepositorio(IWebDriver chromeDriver, Usuario user)
        {
            Thread.Sleep(1000);

            chromeDriver.FindElement(By.XPath("//summary[@aria-label='View profile and more']")).Click();
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.XPath("//a[text()='Your repositories']")).Click();
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.Id("your-repos-filter")).SendKeys(user.Repositorio);
            Thread.Sleep(2000);


            //Pega o nick do usuario
            var username = chromeDriver.FindElement(By.XPath("//span[@class='p-nickname vcard-username d-block']")).Text;

            chromeDriver.FindElement(By.XPath("//a[@href='/"+username+"/"+ user.Repositorio+"']")).Click();
            Thread.Sleep(2000);

            var btnClone = chromeDriver.FindElement(By.XPath("//summary[@class='btn btn-sm ml-2 btn-primary']"));
            btnClone.Click();
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.XPath("//a[text()='Download ZIP']")).Click();
            Thread.Sleep(2000);

            btnClone.Click();
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.XPath("//summary[@aria-label='View profile and more']")).Click();
            Thread.Sleep(2000);

            chromeDriver.FindElement(By.XPath("//button[@class='dropdown-item dropdown-signout']")).Click();
            Thread.Sleep(2000);

            return chromeDriver;
        }
    }
}
