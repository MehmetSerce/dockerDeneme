﻿using OpenQA.Selenium;
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
            var capability = DesiredCapabilities.Chrome();
            if (_driver == null)
            {
                _driver = new RemoteWebDriver(new Uri("http://0.0.0.0:4444/wd/hub/"), capability, TimeSpan.FromSeconds(600));
            }

            return _driver;
        }
    }
}
