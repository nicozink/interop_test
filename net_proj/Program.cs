using System;
using System.Runtime.InteropServices;
using System.Text;

class User32
{
    //[DllImport("user32.dll")]
    //public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

    //[DllImport("libc", EntryPoint = "read")]
    //public static extern int Read(int handle, byte[] buf, int n);
}

class Math
{
    [DllImport("native_library")]
    public static extern int Add(int a, int b);
}

namespace InteropTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CWD: {0}", System.IO.Directory.GetCurrentDirectory());

            //var buffer = new byte[100];
            //User32.Read(0, buffer, 100);

            //Console.WriteLine("Input value is:" + Encoding.UTF8.GetString(buffer));

            //User32.MessageBox(IntPtr.Zero, "Command-line message box", "Attention!", 0);

            int result = Math.Add(1, 2);
            Console.WriteLine("Hello World! {0}", result);
        }
    }
}
