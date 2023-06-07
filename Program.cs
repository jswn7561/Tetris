using System.Runtime.InteropServices;

namespace Tetris
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AddFontResource("Assets/Font/kleptocracy titling rg.ttf");
            AddFontResource("Assets/Font/kleptocracy titling bd.ttf");
            ApplicationConfiguration.Initialize();
            Application.Run(MainForm.Instance);
        }

        [DllImport("gdi32.dll", EntryPoint="AddFontResourceW", SetLastError=true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern void AllocConsole();
    }
}