using OpenQA.Selenium;

namespace PatatapMusic
{
    public class Music
    {
        private readonly IWebDriver driver;

        public Music(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CreateTrack1()
        {
            Action a = new Action( driver);
            
            {
                a.CreateAction("  ", 2);
                a.CreateAction("jpg", 1);
                a.CreateAction("et", 1);
                a.CreateAction("is", 1);
                a.CreateAction("et", 1);

                a.CreateAction("jp", 1);
                a.CreateAction("aEt", 1);
                a.CreateAction("dt", 1);
                a.CreateAction("e", 0.3);
                a.CreateAction("e", 0.3);
                a.CreateAction("e", 0.3);

                a.CreateAction("rr", 0.5);
                a.CreateAction("pg", 0.5);
                a.CreateAction("et", 1);
                a.CreateAction("is", 1);
                a.CreateAction("et", 1);

                a.CreateAction("jp", 1);
                a.CreateAction("ny", 1);
                //TODO
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);

                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);
                a.CreateAction("e", 0.016);

                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);

                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);

                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);
                //a.CreateAction("e", 0.08);
            }
            
        }
    }
}
