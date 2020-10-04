using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon_case4
{
    class Program
    {
        static void Main(string[] args)
        {
            String searchQuery = "Samsung";


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.n11.com");
            IWebElement kvkk_buttton_element = driver.FindElement(By.ClassName("btnHolder"));
            IWebElement login_button_element = driver.FindElement(By.ClassName("btnSignIn"));
            IWebElement header_element = driver.FindElement(By.Id("header"));

            System.Threading.Thread.Sleep(2000);
            kvkk_buttton_element.Click();
            Console.WriteLine("My title" + driver.Title);
            System.Threading.Thread.Sleep(2000);
            login_button_element.Click();

            
            Console.WriteLine("My title"+driver.FindElement(By.TagName("title")).Text);
            System.Threading.Thread.Sleep(3000);
            IWebElement email_element = driver.FindElement(By.Id("email"));
            IWebElement password_element = driver.FindElement(By.Id("password"));
            IWebElement login_submit_element = driver.FindElement(By.Id("returnUrl"));
            email_element.SendKeys("vicif59918@bboygarage.com");
            password_element.SendKeys("password123");
            System.Threading.Thread.Sleep(2000);
            login_submit_element.Submit();
            
          
            

            IWebElement search_input_element = driver.FindElement(By.Id("searchData"));
            IWebElement search_button_element = driver.FindElement(By.ClassName("searchBtn"));
            search_input_element.SendKeys(searchQuery);
            search_button_element.Click();
            System.Threading.Thread.Sleep(3000);

            if (driver.FindElement(By.Id("searchResultNotFound")).Displayed)
            {
                Console.WriteLine("Ürün bulunamadı");
            }
            else
            {
                Console.WriteLine("Ürün var");

            }
        }
    }
}
