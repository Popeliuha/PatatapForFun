using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatatapMusic
{
    class Container
    {
        private readonly IWebDriver _driver;
        private Action _action;
        private Music _music;
        public Container(IWebDriver driver)
        {
            _driver = driver;
            driver.Navigate().GoToUrl("https://patatap.com/");
        }

        public Action Action
        {
            get
            {
                if (_action != null)
                {
                    return _action;
                }
                _action = new Action(_driver);
                return _action;
            }
        }

        public Music Music
        {
            get
            {
                if (_music != null)
                {
                    return _music;
                }
                _music = new Music(_driver);
                return _music;
            }
        }
    }
}
