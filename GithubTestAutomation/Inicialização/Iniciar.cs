using GithubTestAutomation.Encerramento;
using GithubTestAutomation.Model;
using GithubTestAutomation.Processamento;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GithubTestAutomation.Inicialização
{
    class Iniciar
    {
        XmlDocument document = new XmlDocument();
        Usuario user = new Usuario();
        Login login = new Login();
        CloneRepository clonar = new CloneRepository();

        IWebDriver chromeDriver;

        public Iniciar()
        {
            chromeDriver = Config.ConfigNavegadorChrome();
        }

        public void Configrar()
        {
            LerXMl();
            login.FazerLogin(chromeDriver, user);
            clonar.ClonarRepositorio(chromeDriver, user);

            Encerrar.FecharBrowser(chromeDriver);

        }
        public void LerXMl()
        {
            document.Load("C:/XML/DadosGitHub.xml");

            XmlNodeList xnList = document.GetElementsByTagName("Usuario");

            for (int i = 0; i < xnList.Count; i++)
            {
                user.Login = xnList[i]["Login"].InnerText;
                user.Senha = xnList[i]["Senha"].InnerText;
                user.Repositorio = xnList[i]["Repositorio"].InnerText;
            }
        }
    }
}
