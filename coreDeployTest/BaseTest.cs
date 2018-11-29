using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreDeployTest
{
    public abstract class BaseTest
    {
        private IWebDriver _driver;

        public string Url => "http://www.google.co.uk";

        public IWebDriver GetDriver()
        {
            var capabilities = new DesiredCapabilities();
            // Created object of DesiredCapabilities class.
            
            capabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
            
            
            capabilities.SetCapability(CapabilityType.Platform, "Linux");

            
            if (_driver == null)
            {
                _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub/"), capabilities, TimeSpan.FromSeconds(600));
            }

            return _driver;
        }
    }
}
