using System;
using Microsoft.Win32;

namespace AutoDarkMode.Core
{
    public class WindowsTheme
    {
        private readonly string registryPath = @$"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private readonly int enable = 1;
        private readonly int disable = 0;

        public void Start()
        {
            if (DateTime.Now.IsMorning())
            {
                this.LightMode();
            }
            else
            {
                this.DarkMode();
            }
        }

        private void LightMode()
        {
            Registry.SetValue(this.registryPath, PersonalizeRegistryKey.AppsUseLightTheme, this.enable, RegistryValueKind.DWord);
            Registry.SetValue(this.registryPath, PersonalizeRegistryKey.SystemUsesLightTheme, this.enable, RegistryValueKind.DWord);
        }

        private void DarkMode()
        {
            Registry.SetValue(this.registryPath, PersonalizeRegistryKey.AppsUseLightTheme, this.disable, RegistryValueKind.DWord);
            Registry.SetValue(this.registryPath, PersonalizeRegistryKey.SystemUsesLightTheme, this.disable, RegistryValueKind.DWord);
        }
    }
}
