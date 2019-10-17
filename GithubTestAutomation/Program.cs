using GithubTestAutomation.Inicialização;
using System;
using System.Threading;

namespace GithubTestAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Iniciar inicialização = new Iniciar();
            inicialização.Configrar();
            Thread.Sleep(1000);

        }
    }
}
