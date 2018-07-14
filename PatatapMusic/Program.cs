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
    class Program
    {
        static void Main(string[] args)
        {
            Container cont = new Container(new ChromeDriver());
            Thread.Sleep(3000);
            cont.Music.CreateTrack1();
            Thread.Sleep(1000);
        }
    }
}
