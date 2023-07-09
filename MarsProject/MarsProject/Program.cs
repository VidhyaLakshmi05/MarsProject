using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Collections.Specialized.BitVector32;

//open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch Mars portal
driver.Navigate().GoToUrl("http://localhost:5000/Home");

//identify signin button and click on it
IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signinButton.Click();

//identify emailaddress textbox and enter valid emailaddress
IWebElement emailaddressTextbox = driver.FindElement(By.Name("email"));
emailaddressTextbox.SendKeys("vidhya.cv@yahoo.com");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
passwordTextbox.SendKeys("Vidhya@05");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();
Thread.Sleep(3000);


//identify addnew language button and click on it
IWebElement addnewlanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
addnewlanguageButton.Click();


//identify addlanguage textbox and enter valid emailaddress
IWebElement addlanguageTextbox = driver.FindElement(By.Name("name"));
addlanguageTextbox.SendKeys("Tamil");

//select native/bilingual option from dropdown
IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
languageLevelDropdown.Click();

IWebElement nativeOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
nativeOption.Click();

//identify add language button and click on it
IWebElement addlanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
addlanguageButton.Click();
Thread.Sleep(4000);

//identify language modify button and click on it
IWebElement modifylanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
modifylanguageButton.Click();

// Modidy language to select fluent option from dropdown
IWebElement languageLevelDropdown1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
languageLevelDropdown1.Click();

IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
fluentOption.Click();
Thread.Sleep(3000);

//identify update language button and click on it
IWebElement updatelanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
updatelanguageButton.Click();
Thread.Sleep(2000);

//identify skills tab and click on it
IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
skillsTab.Click();

//identify addnew skills button and click on it
IWebElement addnewskillsButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
addnewskillsButton.Click();
Thread.Sleep(2000);

//identify addskill textbox and enter a skill
IWebElement addskillTextbox = driver.FindElement(By.Name("name"));
addskillTextbox.SendKeys("Painting");

//select skill level dropdown and click intermdiate option from dropdown
IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
skillLevelDropdown.Click();

IWebElement intermediateOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
intermediateOption.Click();

//identify add button and click on it
IWebElement addskillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
addskillButton.Click();















