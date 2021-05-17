using LAB5.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LAB5.Steps
{
    [Binding]
    public class TestSteps
    {
        Functionalities productPage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://adoring-pasteur-3ae17d.netlify.app");
            productPage = new Functionalities(webDriver);
        }

        [Given(@"I click on any product category")]
        public void GivenIClickOnAnyProductCategory()
        {
            productPage.selectMenPage();
        }
        
        [Given(@"I enter click on sort by function")]
        public void GivenIEnterClickOnSortByFunction()
        {
            productPage.SelectElement();
        }
        
        [Given(@"I select ascending sort Name\(A-Z\)")]
        public void GivenISelectAscendingSortNameA_Z()
        {
            productPage.Sort();
        }
        
        [Then(@"I should see product page sorted in ascending way")]
        public void ThenIShouldeSeeProductPageSortedInAscendingWay()
        {
            Assert.That(productPage.IsSortedAsc(), Is.True);
        }

        //--------------------------------------------------

        [Given(@"I go to women page")]
        public void GivenIGoToWomenPage()
        {
            productPage.selectWomenPage();
        }

        [Given(@"I click on Quick view button")]
        public void GivenIClickOnQuickViewButton()
        {
            productPage.MoveCursor("inner-men-cart-pro");
            productPage.ClickElementByClass("link-product-add-cart");
        }

        [Then(@"I should see the product single page")]
        public void ThenIShouldeSeeProductSinglePage()
        {
            Assert.That(productPage.IsOnPage(), Is.True);
        }

        //---------------------------------------

        [Given(@"Click on add to cart button")]
        public void GivenClickOnAddToCartButton()
        {
            productPage.ClickElementByClass("button");
        }

        [Given(@"Click on remove button")]
        public void GivenClickOnRemoveButton()
        {
            productPage.ClickButtonByClass("minicart-remove");
        }

        [Then(@"Product should be deleted")]
        public void ThenProductShouldBeDeleted()
        {
            Assert.That(productPage.ElementIsPresentById("PPMiniCart"), Is.False);
        }
    }
}
