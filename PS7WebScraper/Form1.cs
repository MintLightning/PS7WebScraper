using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.WebAuthn;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;
using Keys = OpenQA.Selenium.Keys;

namespace PS7WebScraper
{
    public partial class WebScraperForm : Form
    {
        ChromeDriver _driver;
        List<Course> _courses;
        List<CourseExt> _coursesExt;

        public WebScraperForm()
        {
            InitializeComponent();
            _driver = new ChromeDriver();
            _courses = new List<Course>();
            _coursesExt = new List<CourseExt>();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            semesterComboBox.SelectedIndex = 0;
            //var _driver = new ChromeDriver();
        }

        private void scrapeButton_Click(object sender, EventArgs e)
        {
            // This code defines what happens when you click on "button1" GUI element

            // HTTP Client Example - Easy Server ??? (where does this go?)
            // Use the following block to set up an HTTP client:
            /*
            HttpClient client = new HttpClient();
            using HttpResponseMessage response = client.GetAsync("http://www.contoso.com/").Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
            Debug.WriteLine(responseBody);
            */

            // Use the following block to post data to your webserver:
            /*
            try {
                var result = await client.PostAsync("https://regres.in/api/users", // URL
                                                    new StringContent("{name:\"morpheus\",job:\"leader\"}")); // DATA
                Debug.WriteLine(result.StatusCode.ToString());
            }
            catch (Exception er) {
                Debug.WriteLine("error trying to post");
            }
            */

            

            // Set implicit wait time (does this go in this section or somewhere else?)
            
            //WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5);

            // Tell the driver to pause
            //Thread.Sleep(5000); // 5 second pause

            Course? foundCourse = getCourseInfo(courseTextBox.Text);
            if (foundCourse == null)
            {
                outputTextBox.AppendText("COURSE NOT FOUND" + Environment.NewLine);
            }
            else
            {
                _courses.Add(foundCourse);
                outputTextBox.AppendText(JsonConvert.SerializeObject(foundCourse) + Environment.NewLine);
            }
        }

        // function to scrape the CS courses, this is called once for each semester
        private string semester_scraper(string url_text, string max_checked)
        {
            //go to the URL
            //scrape the stuff (up to max_checked things)
            //return a string with the stuff
            return "";
        }

        private void WebScraperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _driver.Quit();
        }

        private Course? getCourseInfo(string courseName)
        {
            // Open Main catalog page
            _driver.Navigate().GoToUrl("https://catalog.utah.edu/#/home");
            stall();

            // Click on "Courses" link
            var pageCoursesClick = _driver.FindElement(By.XPath("//*[@id=\"top\"]/div/div[3]/div/nav/ul/li[2]/a"));
            pageCoursesClick.Click();
            stall();

            // Enter course into search bar
            var searchBar = _driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div/div/div/div/div[2]/span/div/div/div/input"));
            searchBar.Clear();
            searchBar.SendKeys(courseName);
            stall();

            // Submit search
            searchBar.SendKeys(Keys.Enter);
            stall();

            // Click on result if there is one
            try
            {
                var courseEntry = _driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div/div/div/div/div[3]/main/div[2]/div[2]/div[2]/div/div[2]/a"));
                courseEntry.Click();
            }
            catch (Exception error)
            {
                outputTextBox.AppendText(error.Message + Environment.NewLine);
                return null;
            }
            stall();

            // Scrape course contents
            Course foundCourse = new Course();
            foundCourse.Title = _driver.FindElement(By.XPath("//*[@id=\"__KUALI_TLP\"]/div/div[2]/div[1]/span/div/div/div/div/div")).Text;
            foundCourse.Credits = int.Parse(_driver.FindElement(By.XPath("//*[@id=\"__KUALI_TLP\"]/div/div[2]/div[2]/span/div/div/div/div/div/div")).Text);
            foundCourse.Prerequisite = _driver.FindElement(By.XPath("//*[@id=\"__KUALI_TLP\"]/div/div[2]/div[3]/span/div/div/div/div/div")).Text;
            foundCourse.Description = _driver.FindElement(By.XPath("//*[@id=\"__KUALI_TLP\"]/div/div[2]/div[4]/span/div/div/div/div/div")).Text;
            var components = _driver.FindElements(By.XPath("//*[@id=\"__KUALI_TLP\"]/div/div[2]/div[5]/span/div/div/div/div/div/div"));
            foreach (var component in components)
            {
                foundCourse.Component.Add(component.Text);
            }

            return foundCourse;
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courseTextBox.Text = "CS2420";
            yearBox.Value = 2023;
            semesterComboBox.SelectedIndex = 0;
            maxCoursesBox.Value = 100;
            outputTextBox.Clear();
        }

        private void stall()
        {
            if (slowModeToolStripMenuItem.Checked)
                Thread.Sleep(3000);
        }

        private void multiscrapeButton_Click(object sender, EventArgs e)
        {
            int year = (int)yearBox.Value;
            var semester = semesterComboBox.SelectedIndex*2 + 4;
            if (year == 2007 && semester != 8) {
                outputTextBox.AppendText("There are no Courses available before Fall of 2007." + Environment.NewLine);
                return;
            }
            
            string yearString = (year % 100).ToString().PadLeft(2, '0');
            var url = "https://student.apps.utah.edu/uofu/stu/ClassSchedules/main/1" + yearString + semester + "/class_list.html?subject=CS";

            _driver.Navigate().GoToUrl(url);
            stall();

            var allLinks = _driver.FindElements(By.TagName("a"));
            var reverseAllLinks = allLinks.Reverse();
            var seatingLink = reverseAllLinks.ElementAt(0);

            foreach (IWebElement element in reverseAllLinks)
            {
                //outputTextBox.AppendText(element.Text + Environment.NewLine);
                if (element.Text == "Seating availability for all CS classes")
                {
                    seatingLink = element;
                    break;
                }
            }

            seatingLink.Click();
            stall();

            // TODO: get and save course information
        }
    }
}