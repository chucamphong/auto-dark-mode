using System;
using System.Threading;
using AutoDarkMode.Core;

namespace AutoDarkMode
{
    internal class Program
    {
        private static void Main()
        {
            WindowsTheme windowsTheme = new WindowsTheme();

            while (true)
            {
                windowsTheme.Start();
                Thread.Sleep(TimeSpan.FromMinutes(1));
            }
        }
    }
}
