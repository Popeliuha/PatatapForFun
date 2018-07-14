using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatatapMusic
{
    public class Action
    {
        IWebDriver driver;

        public Action(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CreateAction(string text, double sleep)
        {
            double res = sleep * 1000;
            Thread.Sleep((int)res);
            new Actions(driver).SendKeys(text).Perform();
        }

    }
}
