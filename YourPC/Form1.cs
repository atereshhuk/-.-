using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using YourPC.Classes;

namespace YourPC
{
    public partial class Form1 : Form
    {
        UserInfo UI = new UserInfo();
        DiskInfo DI = new DiskInfo();
        
        string User = SystemInformation.UserName;
        public Form1()
        {
            InitializeComponent();           
        }

        private void BT_InfoAboutUser_Click(object sender, EventArgs e)
        {
            UI.GetUserName(TB_Gun);
            UI.OSVersion(TB_OSVersion);
            UI.Type(TB_64_86);
            UI.PCName(TB_PCName);
            UI.Bios(TB_BiosVersion, TB_BiosDate);
            UI.ProccesorCount(TB_ProccesorCount);
            UI.CurrentProccesor(TB_ProccesName);
            UI.IDProc(TB_IDProcessor);
            UI.Mhz(TB_Mhz);
            UI.MatName(TB_MatName, TB_MBNumber);

            UI.Mouse(TB_Mouse);
            UI.Keyboard(TB_Keyboard);
        }

        private void BT_DiskInfo_Click(object sender, EventArgs e)
        {
            DI.AllDisks(LV_AllDisks);
        }

        private void LV_AllDisks_ItemActivate(object sender, EventArgs e)
        {
            string item = LV_AllDisks.SelectedItems[0].Text;
            DI.TypeDisk(TB_DiskType, item);
            DI.IDName(TB_IDName, item);
            DI.FileSystem(TB_FileSystem, item);
            DI.FullSpace(TB_FullSpace,item);
            DI.FreeSpace(TB_FreeSpace,item);

            if (TB_IDName.Text == "")
            {
                TB_IDName.Text = "Локальный диск " + item;
            }
        }

    }
}
