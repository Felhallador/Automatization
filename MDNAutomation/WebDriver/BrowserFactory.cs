using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.

namespace MDNAutomation.WebDriver
{
    class BrowserFactory
    {
        private static string DownloadFolder { get; set; }
        public static string GetDownloadFolder()
        {
            return DownloadFolder;
        }
    }
}
