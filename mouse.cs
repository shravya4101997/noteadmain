using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Windows.Input;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUITestProject8
{
    class mouse : method
    {
       public static void rightclickmethod()
        {
            method.launch();
            Keyboard.SendKeys("{A}", M.ModifierKeys.Control);
            Playback.Wait(4000);
            
            Keyboard.SendKeys("{F10}", M.ModifierKeys.Shift);
            Playback.Wait(4000);
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{ENTER}");
            Playback.Wait(4000);
            Keyboard.SendKeys("{F10}", M.ModifierKeys.Shift);
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{ENTER}");
            Playback.Wait(4000);

            Keyboard.SendKeys("{F10}", M.ModifierKeys.Shift);
            Playback.Wait(4000);
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{ENTER}");

            Playback.Wait(4000);
            Keyboard.SendKeys("{F10}", M.ModifierKeys.Shift);
            Playback.Wait(4000);
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{Down}");
            Keyboard.SendKeys("{Down}");

            Keyboard.SendKeys("{ENTER}");
            Playback.Wait(4000);
            method.exit();

        }
    }
}
