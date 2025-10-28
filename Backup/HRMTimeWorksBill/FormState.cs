using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HRMTimeWorksBill
{
    /// <summary>
    /// Selected Win AI Function Calls
    /// </summary>
    
    public class WinApi
    {
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);

        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int which);

        [DllImport("user32.dll")]
        public static extern void 
            SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
                         int X, int Y, int width, int height, uint flags);        
        
        private const int SM_CXSCREEN = 0;
	    private const int SM_CYSCREEN = 1;
        private static IntPtr HWND_TOP = IntPtr.Zero;
        private const int SWP_SHOWWINDOW = 64; // 0x0040
        
        public static int ScreenX
        {
            get { return GetSystemMetrics(SM_CXSCREEN);}
        }
        
        public static int ScreenY
        {
            get { return GetSystemMetrics(SM_CYSCREEN);}
        }
        
        public static void SetWinFullScreen(IntPtr hwnd)
        {
            SetWindowPos(hwnd, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW);
        }
    }
    
    /// <summary>
    /// Class used to preserve / restore state of the form
    /// </summary>
    public class FormState
    {
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;

        private bool _IsMaximized = false;

        public bool IsMaximized
        {
            get { return _IsMaximized; }
        }
       
        public Rectangle Bounds
        {
            get { return bounds; }
        }

        public void Maximize(Form targetForm)
        {
            if (!_IsMaximized)
            {
                _IsMaximized = true;
                Save(targetForm);
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.TopMost = true;
                WinApi.SetWinFullScreen(targetForm.Handle);
            }
        }
        
        public void Save(Form targetForm)
        {
            winState = targetForm.WindowState;
            brdStyle = targetForm.FormBorderStyle;
            topMost = targetForm.TopMost;
            bounds = targetForm.Bounds;
        }

        public void Restore(Form targetForm)
        {
            targetForm.WindowState = winState;
            targetForm.FormBorderStyle = brdStyle;
            targetForm.TopMost = topMost;
            targetForm.Bounds = bounds;
            _IsMaximized = false;
        }
    }
}
