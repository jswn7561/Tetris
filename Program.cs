using System.Runtime.InteropServices;

namespace Tetris
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AddFontResource(@"C:\Users\admin\Documents\GitHub\Tetris\Assets\Font\kleptocracy titling rg.ttf");
            AddFontResource(@"C:\Users\admin\Documents\GitHub\Tetris\Assets\Font\kleptocracy titling bd.ttf");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GameView());
        }

        [DllImport("gdi32.dll", EntryPoint="AddFontResourceW", SetLastError=true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
            string lpFileName);
    }
}