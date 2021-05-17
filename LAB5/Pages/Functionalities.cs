using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Telerik.JustMock;

namespace LAB5.Pages
{
    public class Functionalities
    {
        private readonly IWebDriver webDriver;

        SelectElement select = null;

        String singlePageUrl = "https://adoring-pasteur-3ae17d.netlify.app/single.html";

        public Functionalities(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement LinkProductGender => webDriver.FindElement(By.PartialLinkText("Men's wear"));

        public IWebElement womenPage => webDriver.FindElement(By.PartialLinkText("Women's wear"));
        public IWebElement LinkProductCategory => webDriver.FindElement(By.LinkText("Clothing"));

        public IWebElement linkWomenClothing => webDriver.FindElement(By.LinkText("Women Clothing"));

        public void selectMenPage()
        {
            LinkProductGender.Click();
            //Thread.Sleep(3000);
            LinkProductCategory.Click();
           // Thread.Sleep(3000);
        }

        public void selectWomenPage()
        {
            womenPage.Click();
           // Thread.Sleep(3000);
            linkWomenClothing.Click();
           // Thread.Sleep(3000);
        }

        public void SelectElement()
        {
            select = new SelectElement(webDriver.FindElement(By.Id("country1")));
           // Thread.Sleep(3000);
        }

        public void MoveCursor(String element)
        {
            var image = webDriver.FindElement(By.ClassName(element));
            Actions action = new Actions(webDriver);
            action.MoveToElement(image).Perform();
            //Thread.Sleep(3000);
        }

        public void ClickElementByName(String element)
        {
            IWebElement selectElement = webDriver.FindElement(By.Name(element));
            selectElement.Click();
            //Thread.Sleep(3000);
        }

        public void ClickElementByClass(String element)
        {
            IWebElement selectElement = webDriver.FindElement(By.ClassName(element));
            selectElement.Click();
            //Thread.Sleep(3000);
        }

        public void ClickButtonByClass(String element)
        {
            IWebElement selectElement = webDriver.FindElement(By.ClassName(element));
            selectElement.Click();
            //Thread.Sleep(3000);
        }

        public void Sort()
        {
            select.SelectByText("Name(A - Z)");
           // Thread.Sleep(3000);
        }

        public bool IsSortedAsc()
        {
            var firstItemFromPage = webDriver.FindElement(By.ClassName("product-men"));
            Console.WriteLine("First product from page: " + firstItemFromPage);
            var item = webDriver.FindElement(By.LinkText("Analog Watch"));
            Console.WriteLine("Product that should be first: " + item);
            if (firstItemFromPage != item)
            {
                webDriver.Quit();
                return true;
            }

            webDriver.Quit();
            return false;
        }

        public bool IsOnPage()
        {
            bool isElementDisplayed = webDriver.FindElement(By.ClassName("single-right-left")).Displayed;
            webDriver.Quit();
            return isElementDisplayed;
        }


        public bool ElementIsPresentById(String element)
        {
            bool isElementDisplayed = webDriver.FindElement(By.Id(element)).Displayed;
            webDriver.Quit();
            return isElementDisplayed;
        }
    }
}
