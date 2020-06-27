﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Projetos\WebScrap\bin\Debug\netcoreapp3.1");
            driver.Url = "https://www.google.com";

            Console.WriteLine(driver.Title);
            IWebElement textbox = driver.FindElement(By.Name("q"));
            textbox.SendKeys("Cat Pictures");

            
            textbox.Submit();
            Console.WriteLine(driver.Title);

            driver.Quit();


        }
    }
