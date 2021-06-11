using System;
using System.Runtime.InteropServices;

namespace StartMenuAlternativeApp
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
           UIntPtr dwExtraInfo);
        const byte KEY_CTRL = 0x11;
        const byte KEY_ESC = 0x1B;
        const uint KEYEVENTF_KEYUP = 0x02;

        public static void OpenStartMenu()
        {
            keybd_event(KEY_CTRL, 0, 0, UIntPtr.Zero);
            keybd_event(KEY_ESC, 0, 0, UIntPtr.Zero);

            keybd_event(KEY_CTRL, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            keybd_event(KEY_ESC, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);

            return;
        }

        static void Main()
        {
            OpenStartMenu();

            return;
        }
    }
}
