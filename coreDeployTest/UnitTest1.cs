using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using Xunit;

namespace coreDeployTest
{
    public class UnitTest1:BaseTest
    {

        [Fact]
        public void Test1()
        {
            using (var driver = GetDriver())
            {
                driver.Navigate().GoToUrl(Url);
              string getir=  driver.Title;
               // _wait.Until(ExpectedConditions.ElementExists(By.Id("tsf")));
                //var res = driver.FindElement(By.Id("tsf"));
                //Assert.True(res != null);
                Assert.Equal("Google", getir);
            }
        }

        //[Fact]
        //public void Test2()
        //{
        //    using (var driver = GetDriver())
        //    {
        //        driver.Navigate().GoToUrl(Url);
        //        var res = driver.FindElement(By.Id("lst-ib"));
        //        Assert.True(res != null);
        //    }
        //}

        //[Fact]
        //public void Test3()
        //{
        //    using (var driver = GetDriver())
        //    {
        //        driver.Navigate().GoToUrl(Url);
        //        var res = driver.FindElement(By.Id("lst-ib"));
        //        Assert.True(res != null);
        //    }
        //}


    }
}
