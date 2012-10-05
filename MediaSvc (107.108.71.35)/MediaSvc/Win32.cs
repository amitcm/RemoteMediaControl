using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace MediaSvc
{
    public class Win32
    {
        public const int WM_COMMAND = 0x111;

        
        [DllImport("User32.dll")]
        public static extern int FindWindow(string strClassName, string strWindowName);

       
        [DllImport("User32.dll")]
        public static extern int FindWindowEx(int hwndParent, int hwndChildAfter, string strClassName, string strWindowName);


       
        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            int hWnd,               // handle to destination window
            int Msg,                // message
            int wParam,             // first message parameter
            [MarshalAs(UnmanagedType.LPStr)] string lParam); // second message parameter

        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            int hWnd,               // handle to destination window
            int Msg,                // message
            int wParam,             // first message parameter
            int lParam);			// second message parameter

        public Win32()
        {

        }

        ~Win32()
        {

        }

    }
}
