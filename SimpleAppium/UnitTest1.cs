using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace SimpleAppium
{
    [TestClass]
    public class UnitTest1
    {
        //Initiating Appium driver 
        AppiumDriver<IWebElement> driver;
        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "donatello");
            capabilities.SetCapability("apppackage", "com.example.calculator");

            //Launch the Android Driver
            driver = new AndroidDriver<IWebElement>();
        }
    }
}
