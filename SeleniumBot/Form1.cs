using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace SeleniumBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread bsl = new Thread(basla);
            bsl.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void basla()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread bsl = new Thread(kbasla);
            bsl.Start();
        }

        private void kbasla()
        {
            ChromeOptions proxy = new ChromeOptions();
            proxy.AddArguments("--proxy-server=" + textBox2.Text);
            IWebDriver driver1 = new ChromeDriver(proxy);
            driver1.Navigate().GoToUrl(textBox1.Text);
            Thread.Sleep(3000);
            IWebElement element = driver1.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/main/div[2]/div[1]/div/div[1]/a"));
            element.Click();


            //Thread.Sleep(3000);
            //IWebElement element1 = driver1.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/main/div[2]/div[1]/div/div[1]/a"));
            ////element.Click();
            ///

            //XmlDocument proxy2 = new XmlDocument();
            //List<IWebElement> AuthorList = new List<IWebElement>();
            //AuthorList.Add(driver1.FindElement(By.TagName("a")));
            //System.Console.WriteLine(proxy2.GetElementsByTagName("a"));
        }
        //private void eylem1()
        //{
        //    IWebElement element = driver.FindElement(By.Name("q"));
        //}
    }
}
