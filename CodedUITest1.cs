using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.SqlServer.Server;
using IronOcr;

namespace CodedUITestProject8
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        //public ApplicationUnderTest note;

        [TestMethod]
        public void testmethods()
        {
            ApplicationUnderTest note = ApplicationUnderTest.Launch("C:\\Windows\\System32\\notepad.exe");
            UITestControl num = new UITestControl();
            num.TechnologyName = "MSAA";
            num.SearchProperties[UITestControl.PropertyNames.Name] = "Untitled - Notepad";
            UITestControl but = new WinButton(num);
            UITestControlCollection control = but.FindMatchingControls();
            var controlbutton = control.GetNamesOfControls();
            foreach(var c in controlbutton)
            {

                Keyboard.SendKeys(c+"\n");
            }


            // var Ocr = new AutoOcr();
            //var Result = Ocr.Read(@"C:\Users\shravya.shastri\Desktop\qrcode.png");
            // Console.WriteLine(Result.Text);
            // string n = Result.ToString();
            // method.launch();
            // Keyboard.SendKeys(n);
            // method.filemethod();
            // method.savemethod();
            // method.scenarios();
            //mouse.rightclickmethod();




        }





        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
