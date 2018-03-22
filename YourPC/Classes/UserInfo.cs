using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;

namespace YourPC
{
    class UserInfo
    {
        public void GetUserName(TextBox TB_GUN)
        {
            TB_GUN.Text = Environment.UserName.ToString();
        }
        public void OSVersion(TextBox TB_OSVersion)
        {
            TB_OSVersion.Text = (string)Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\").GetValue("ProductName");
        }
        public void Type(TextBox TB_64_86)
        {
            TB_64_86.Text = Environment.Is64BitOperatingSystem ? "x64" : "x32/x86"; //тернарный оператор
        }
        public void PCName(TextBox TB_PCName)
        {
            TB_PCName.Text = Environment.MachineName.ToString();
        }
        public void Bios(TextBox TB_Bios, TextBox TB_BiosDate)
        {
            TB_Bios.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS").GetValue("BIOSVersion");
            TB_BiosDate.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS").GetValue("BIOSReleaseDate");
        }

        public void Mouse(TextBox TB_Mouse)
        {
            RegistryKey mouse = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse");
            if (mouse == null)
            {
                TB_Mouse.Text = "Мышь отключена!";
            }
            else TB_Mouse.Text = "Мышь подключена!";
        }
        public void Keyboard(TextBox TB_Keyboard)
        {
            RegistryKey keyboard = Registry.CurrentUser.OpenSubKey(@"Control Panel\Keyboard");
            if (keyboard == null)
            {
                TB_Keyboard.Text = "Клавиатура отсутствует!";
            }
            else TB_Keyboard.Text = "Клавиатура подключена";
        }

        public void ProccesorCount(TextBox TB_ProccesorCount)
        {
            TB_ProccesorCount.Text = Environment.ProcessorCount.ToString();
        }
        public void CurrentProccesor(TextBox TB_CurrentProccesor)
        {
            TB_CurrentProccesor.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString");
        }
        public void IDProc(TextBox TB_IDProc)
        {
            TB_IDProc.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("Identifier");
        }
        public void Mhz(TextBox TB_Mhz)
        {
            TB_Mhz.Text = Convert.ToString((int)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("~MHz")) + "MHz";
        }
        public void MatName(TextBox TB_MatName, TextBox TB_MBNumber)
        {
            TB_MatName.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS").GetValue("BaseBoardManufacturer");
            TB_MBNumber.Text = (string)Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS").GetValue("BaseBoardProduct");
        }
    }
}