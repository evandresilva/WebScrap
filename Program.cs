using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebScrap
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.bna.ao/#/");
            IWebElement table = driver.FindElement(By.ClassName("text-capitalize"));

            var moedas = table.FindElements(By.TagName("tr"));
            foreach (var moeda in moedas)
            {
                var linha = moeda.Text;
                Console.WriteLine($"{linha}");
            }
            Console.ReadKey();
            driver.Quit();
        }
    }
}
