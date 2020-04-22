using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CodedUITestProject8
{
    public class method
    {
        public static  ApplicationUnderTest note;
        public static void scenarios()
        {
            launch();
            formatmethod();
            wordwrapmethod();
            formatmethod();
            fontmethod();
            okmethod();
            filemethod();
            savemethod();
            viewmethod();
            zoommethod();
            zoominmethod();
            viewmethod();
            zoommethod();
            zoomoutmethod();
            viewmethod();
            zoommethod();
            defaultzoomoutmethod();
            viewmethod();
            statusbarmethod();
            helpmethod();
            viewhelpmethod();
            helpmethod();
            sendfeedbackmethod();
            helpmethod();
            aboutnotepadmethod();
            exit();


        }

        public static void launch() //to launch notepad and maximize and to click on format
        {
            
            note = ApplicationUnderTest.Launch("C:\\Windows\\System32\\notepad.exe");
            note.Maximized = true;
            Playback.Wait(2000);
        
            Keyboard.SendKeys("hii");
            //Keyboard.SendKeys("{A}", ModifierKeys.Control);
            Playback.Wait(2000);

        }
        public static void formatmethod()
        {
            WinWindow SearchButtonWindow = new WinWindow(note) { TechnologyName = "MSAA" };
            SearchButtonWindow.SearchProperties.Add("Name", "Format", "ControlType", "MenuItem");
            Mouse.Click(SearchButtonWindow);
            Playback.Wait(2000);
        }
        
        //wordwrap checkbox
        public static void wordwrapmethod()
        {
            WinWindow Wordwrap = new WinWindow(note) { TechnologyName = "MSAA" };
            Wordwrap.SearchProperties.Add("Name", "Word Wrap","ControlType", "MenuItem");
            Mouse.Click(Wordwrap);
            Playback.Wait(4000);
        }
        //font button

        public static void fontmethod()
        {
            WinWindow Font = new WinWindow(note) { TechnologyName = "MSAA" };
            Font.SearchProperties.Add("Name", "Font...", "ControlType", "MenuItem");
            Mouse.Click(Font);
            Playback.Wait(2000);

           //to select font,font style,size
            Keyboard.SendKeys("Arial");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("Bold");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("12");
            Keyboard.SendKeys("{Tab}");

            Playback.Wait(2000);
        }


        //OK button

        public static void okmethod()
        {
            WinWindow okbutton = new WinWindow(note) { TechnologyName = "MSAA" };
            okbutton.SearchProperties.Add("Name", "OK","ControlType", "Button", "DisplayText", "OK");
            Keyboard.SendKeys("{Enter}");
            Playback.Wait(2000);
        }

        // click on file


        public static void filemethod()
        {
            WinWindow file = new WinWindow(note) { TechnologyName = "MSAA" };
            file.SearchProperties.Add("Name", "File", "ControlType", "MenuItem");
            Mouse.Click(file);
            Playback.Wait(1000);
        }
        //click on save

        public  static void savemethod()
        {

            WinWindow save = new WinWindow(note) { TechnologyName = "MSAA" };
            save.SearchProperties.Add("Name", "Save	Ctrl+S", "ControlType", "MenuItem");
            Mouse.Click(save);
            Playback.Wait(2000);
            Keyboard.SendKeys("ninu");
            Playback.Wait(2000);
            Keyboard.SendKeys("{Enter}");
            Playback.Wait(2000);
        }

        //view
        public static void viewmethod()
        {
            WinWindow view = new WinWindow(note) { TechnologyName = "MSAA" };
            view.SearchProperties.Add("Name", "View", "ControlType", "MenuItem");
            Mouse.Click(view);
            Playback.Wait(2000);
        }
        //zoom

        public  static void zoommethod()
        {
            WinWindow zoom = new WinWindow(note) { TechnologyName = "MSAA" };
            zoom.SearchProperties.Add("Name", "Zoom", "ControlType", "MenuItem");
            Mouse.Click(zoom);
            Playback.Wait(2000);

        }
        //zoomin
        public static void zoominmethod()
        {

            WinWindow zoomin = new WinWindow(note) { TechnologyName = "MSAA" };
            zoomin.SearchProperties.Add("Name", "Zoom In	Ctrl+Plus", "ControlType", "MenuItem");
            Mouse.Click(zoomin);
            Playback.Wait(2000);
        }


        //zoomout

        public static void zoomoutmethod()
        {

            WinWindow zoomout = new WinWindow(note) { TechnologyName = "MSAA" };
            zoomout.SearchProperties.Add("Name", "Zoom Out	Ctrl+Minus", "ControlType", "MenuItem");
            Mouse.Click(zoomout);
            Playback.Wait(2000);
        }

        //restore to default zoom
        public static void defaultzoomoutmethod()
        {
            WinWindow defaultzoom = new WinWindow(note) { TechnologyName = "MSAA" };
            defaultzoom.SearchProperties.Add("Name", "Restore Default Zoom	Ctrl+0", "ControlType", "MenuItem");
            Mouse.Click(defaultzoom);
            //Keyboard.SendKeys("{Enter}");

            Playback.Wait(2000);
        }

       
        //statusbar checkbox

        public static void statusbarmethod()
        {

            WinWindow statusbar = new WinWindow(note) { TechnologyName = "MSAA" };
            statusbar.SearchProperties.Add("Name", "Status Bar", "ControlType", "MenuItem");
            Mouse.Click(statusbar);
            Playback.Wait(4000);

        }

        //help

        public static void helpmethod()
        {
            WinWindow help = new WinWindow(note) { TechnologyName = "MSAA" };
            help.SearchProperties.Add("Name", "Help", "ControlType", "MenuItem");
            Mouse.Click(help);
            Playback.Wait(2000);

        }


        //view help


        public static void viewhelpmethod()
        {
            WinWindow viewhelp = new WinWindow(note) { TechnologyName = "MSAA" };
            viewhelp.SearchProperties.Add("Name", "View Help", "ControlType", "MenuItem");
            Mouse.Click(viewhelp);
            Playback.Wait(4000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

        }


        //send feedback

        public static void sendfeedbackmethod()
        {
            WinWindow sendfeedback = new WinWindow(note) { TechnologyName = "MSAA" };
            sendfeedback.SearchProperties.Add("Name", "Send Feedback", "ControlType", "MenuItem");
            Mouse.Click(sendfeedback);
            Playback.Wait(5000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

        }

        //about notepad

        public static void aboutnotepadmethod()
        {
            WinWindow aboutnotepad = new WinWindow(note) { TechnologyName = "MSAA" };
            aboutnotepad.SearchProperties.Add("Name", "About Notepad", "ControlType", "MenuItem");
            Mouse.Click(aboutnotepad);
            Playback.Wait(5000);
            Keyboard.SendKeys("{Enter}");
            
        }
        public static void exit()
        {
            filemethod();
            WinWindow exit = new WinWindow(note) { TechnologyName = "MSAA" };
            exit.SearchProperties.Add("Name", "Exit", "ControlType", "MenuItem");
            Mouse.Click(exit);
            Playback.Wait(2000);
        }
    }
}
