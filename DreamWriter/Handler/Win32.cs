using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DreamWriter.Handler
{
    public static class Win32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        public static void Write(string Text)
        {
            Console.WriteLine(Text);
        }
    }
}
