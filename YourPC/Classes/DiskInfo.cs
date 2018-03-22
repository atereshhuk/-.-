using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace YourPC.Classes
{
    class DiskInfo
    {
        public void AllDisks(ListView LV_AllDisks)
        {
            string[] disks = Environment.GetLogicalDrives();
            foreach (string d in disks)
            {
                LV_AllDisks.Items.Add(d);
            }
        }
        public void TypeDisk(TextBox TB_TypeDisk, string diskname)
        {           
            TB_TypeDisk.Text = new DriveInfo(diskname).DriveType.ToString();
        }

        public void IDName(TextBox TB_IDName, string diskname)
        {
            TB_IDName.Text = new DriveInfo(diskname).VolumeLabel;
        }

        public void FileSystem(TextBox TB_FileSystem, string diskname)
        {
            TB_FileSystem.Text = new DriveInfo(diskname).DriveFormat;
        }

        public void FullSpace(TextBox TB_FullSpace, string diskname)
        {
            long gb = new DriveInfo(diskname).TotalSize / 1073741824;
            TB_FullSpace.Text = gb.ToString() +  " Гб";
        }

        public void FreeSpace(TextBox TB_FreeSpace, string diskname)
        {
            long gb = new DriveInfo(diskname).TotalFreeSpace / 1073741824;
            TB_FreeSpace.Text = gb.ToString() + " Гб";
        }
    }
}