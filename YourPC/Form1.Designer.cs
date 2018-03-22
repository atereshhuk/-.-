namespace YourPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_Gun = new System.Windows.Forms.TextBox();
            this.TB_OSVersion = new System.Windows.Forms.TextBox();
            this.TB_64_86 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PCName = new System.Windows.Forms.TextBox();
            this.BT_InfoAboutUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_MBNumber = new System.Windows.Forms.TextBox();
            this.TB_MatName = new System.Windows.Forms.TextBox();
            this.TB_BiosDate = new System.Windows.Forms.TextBox();
            this.TB_BiosVersion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_Keyboard = new System.Windows.Forms.TextBox();
            this.TB_Mouse = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_FreeSpace = new System.Windows.Forms.TextBox();
            this.TB_FullSpace = new System.Windows.Forms.TextBox();
            this.TB_FileSystem = new System.Windows.Forms.TextBox();
            this.TB_IDName = new System.Windows.Forms.TextBox();
            this.TB_DiskType = new System.Windows.Forms.TextBox();
            this.LV_AllDisks = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_IDProcessor = new System.Windows.Forms.TextBox();
            this.TB_ProccesName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Mhz = new System.Windows.Forms.TextBox();
            this.TB_ProccesorCount = new System.Windows.Forms.TextBox();
            this.BT_DiskInfo = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Gun
            // 
            this.TB_Gun.Location = new System.Drawing.Point(227, 45);
            this.TB_Gun.Name = "TB_Gun";
            this.TB_Gun.ReadOnly = true;
            this.TB_Gun.Size = new System.Drawing.Size(119, 20);
            this.TB_Gun.TabIndex = 0;
            // 
            // TB_OSVersion
            // 
            this.TB_OSVersion.Location = new System.Drawing.Point(74, 19);
            this.TB_OSVersion.Name = "TB_OSVersion";
            this.TB_OSVersion.ReadOnly = true;
            this.TB_OSVersion.Size = new System.Drawing.Size(178, 20);
            this.TB_OSVersion.TabIndex = 0;
            // 
            // TB_64_86
            // 
            this.TB_64_86.Location = new System.Drawing.Point(258, 19);
            this.TB_64_86.Name = "TB_64_86";
            this.TB_64_86.ReadOnly = true;
            this.TB_64_86.Size = new System.Drawing.Size(88, 20);
            this.TB_64_86.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Gun);
            this.groupBox1.Controls.Add(this.TB_PCName);
            this.groupBox1.Controls.Add(this.TB_64_86);
            this.groupBox1.Controls.Add(this.TB_OSVersion);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Система";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя PC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Версия ОС";
            // 
            // TB_PCName
            // 
            this.TB_PCName.Location = new System.Drawing.Point(74, 45);
            this.TB_PCName.Name = "TB_PCName";
            this.TB_PCName.ReadOnly = true;
            this.TB_PCName.Size = new System.Drawing.Size(112, 20);
            this.TB_PCName.TabIndex = 0;
            // 
            // BT_InfoAboutUser
            // 
            this.BT_InfoAboutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_InfoAboutUser.Location = new System.Drawing.Point(12, 12);
            this.BT_InfoAboutUser.Name = "BT_InfoAboutUser";
            this.BT_InfoAboutUser.Size = new System.Drawing.Size(322, 23);
            this.BT_InfoAboutUser.TabIndex = 2;
            this.BT_InfoAboutUser.Text = "Получить информацию";
            this.BT_InfoAboutUser.UseVisualStyleBackColor = true;
            this.BT_InfoAboutUser.Click += new System.EventHandler(this.BT_InfoAboutUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TB_MBNumber);
            this.groupBox2.Controls.Add(this.TB_MatName);
            this.groupBox2.Controls.Add(this.TB_BiosDate);
            this.groupBox2.Controls.Add(this.TB_BiosVersion);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BIOS и Материнская плата";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(194, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Плата";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(194, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Версия BIOS";
            // 
            // TB_MBNumber
            // 
            this.TB_MBNumber.Location = new System.Drawing.Point(241, 42);
            this.TB_MBNumber.Name = "TB_MBNumber";
            this.TB_MBNumber.ReadOnly = true;
            this.TB_MBNumber.Size = new System.Drawing.Size(99, 20);
            this.TB_MBNumber.TabIndex = 0;
            // 
            // TB_MatName
            // 
            this.TB_MatName.Location = new System.Drawing.Point(52, 42);
            this.TB_MatName.Name = "TB_MatName";
            this.TB_MatName.ReadOnly = true;
            this.TB_MatName.Size = new System.Drawing.Size(113, 20);
            this.TB_MatName.TabIndex = 0;
            // 
            // TB_BiosDate
            // 
            this.TB_BiosDate.Location = new System.Drawing.Point(241, 12);
            this.TB_BiosDate.Name = "TB_BiosDate";
            this.TB_BiosDate.ReadOnly = true;
            this.TB_BiosDate.Size = new System.Drawing.Size(99, 20);
            this.TB_BiosDate.TabIndex = 0;
            // 
            // TB_BiosVersion
            // 
            this.TB_BiosVersion.Location = new System.Drawing.Point(86, 16);
            this.TB_BiosVersion.Name = "TB_BiosVersion";
            this.TB_BiosVersion.ReadOnly = true;
            this.TB_BiosVersion.Size = new System.Drawing.Size(79, 20);
            this.TB_BiosVersion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TB_Keyboard);
            this.groupBox3.Controls.Add(this.TB_Mouse);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Устройства";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Клавиатура";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Мышь";
            // 
            // TB_Keyboard
            // 
            this.TB_Keyboard.Location = new System.Drawing.Point(121, 45);
            this.TB_Keyboard.Name = "TB_Keyboard";
            this.TB_Keyboard.ReadOnly = true;
            this.TB_Keyboard.Size = new System.Drawing.Size(225, 20);
            this.TB_Keyboard.TabIndex = 0;
            // 
            // TB_Mouse
            // 
            this.TB_Mouse.Location = new System.Drawing.Point(121, 19);
            this.TB_Mouse.Name = "TB_Mouse";
            this.TB_Mouse.ReadOnly = true;
            this.TB_Mouse.Size = new System.Drawing.Size(225, 20);
            this.TB_Mouse.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TB_FreeSpace);
            this.groupBox4.Controls.Add(this.TB_FullSpace);
            this.groupBox4.Controls.Add(this.TB_FileSystem);
            this.groupBox4.Controls.Add(this.TB_IDName);
            this.groupBox4.Controls.Add(this.TB_DiskType);
            this.groupBox4.Controls.Add(this.LV_AllDisks);
            this.groupBox4.Location = new System.Drawing.Point(370, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 156);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о дисках";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Доступно памяти";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Всего памяти";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Файловая система";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Имя диска";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Тип диска";
            // 
            // TB_FreeSpace
            // 
            this.TB_FreeSpace.Location = new System.Drawing.Point(177, 123);
            this.TB_FreeSpace.Name = "TB_FreeSpace";
            this.TB_FreeSpace.ReadOnly = true;
            this.TB_FreeSpace.Size = new System.Drawing.Size(188, 20);
            this.TB_FreeSpace.TabIndex = 5;
            // 
            // TB_FullSpace
            // 
            this.TB_FullSpace.Location = new System.Drawing.Point(158, 97);
            this.TB_FullSpace.Name = "TB_FullSpace";
            this.TB_FullSpace.ReadOnly = true;
            this.TB_FullSpace.Size = new System.Drawing.Size(207, 20);
            this.TB_FullSpace.TabIndex = 4;
            // 
            // TB_FileSystem
            // 
            this.TB_FileSystem.Location = new System.Drawing.Point(187, 68);
            this.TB_FileSystem.Name = "TB_FileSystem";
            this.TB_FileSystem.ReadOnly = true;
            this.TB_FileSystem.Size = new System.Drawing.Size(178, 20);
            this.TB_FileSystem.TabIndex = 3;
            // 
            // TB_IDName
            // 
            this.TB_IDName.Location = new System.Drawing.Point(143, 42);
            this.TB_IDName.Name = "TB_IDName";
            this.TB_IDName.ReadOnly = true;
            this.TB_IDName.Size = new System.Drawing.Size(222, 20);
            this.TB_IDName.TabIndex = 2;
            // 
            // TB_DiskType
            // 
            this.TB_DiskType.Location = new System.Drawing.Point(140, 16);
            this.TB_DiskType.Name = "TB_DiskType";
            this.TB_DiskType.ReadOnly = true;
            this.TB_DiskType.Size = new System.Drawing.Size(226, 20);
            this.TB_DiskType.TabIndex = 1;
            // 
            // LV_AllDisks
            // 
            this.LV_AllDisks.Location = new System.Drawing.Point(6, 16);
            this.LV_AllDisks.Name = "LV_AllDisks";
            this.LV_AllDisks.Size = new System.Drawing.Size(63, 134);
            this.LV_AllDisks.TabIndex = 0;
            this.LV_AllDisks.UseCompatibleStateImageBehavior = false;
            this.LV_AllDisks.View = System.Windows.Forms.View.SmallIcon;
            this.LV_AllDisks.ItemActivate += new System.EventHandler(this.LV_AllDisks_ItemActivate);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.TB_IDProcessor);
            this.groupBox5.Controls.Add(this.TB_ProccesName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.TB_Mhz);
            this.groupBox5.Controls.Add(this.TB_ProccesorCount);
            this.groupBox5.Location = new System.Drawing.Point(370, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Процессор";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Частота";
            // 
            // TB_IDProcessor
            // 
            this.TB_IDProcessor.Location = new System.Drawing.Point(78, 45);
            this.TB_IDProcessor.Name = "TB_IDProcessor";
            this.TB_IDProcessor.ReadOnly = true;
            this.TB_IDProcessor.Size = new System.Drawing.Size(287, 20);
            this.TB_IDProcessor.TabIndex = 0;
            // 
            // TB_ProccesName
            // 
            this.TB_ProccesName.Location = new System.Drawing.Point(78, 22);
            this.TB_ProccesName.Name = "TB_ProccesName";
            this.TB_ProccesName.ReadOnly = true;
            this.TB_ProccesName.Size = new System.Drawing.Size(287, 20);
            this.TB_ProccesName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество ядер";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Процессор";
            // 
            // TB_Mhz
            // 
            this.TB_Mhz.Location = new System.Drawing.Point(210, 71);
            this.TB_Mhz.Name = "TB_Mhz";
            this.TB_Mhz.ReadOnly = true;
            this.TB_Mhz.Size = new System.Drawing.Size(155, 20);
            this.TB_Mhz.TabIndex = 0;
            // 
            // TB_ProccesorCount
            // 
            this.TB_ProccesorCount.Location = new System.Drawing.Point(105, 71);
            this.TB_ProccesorCount.Name = "TB_ProccesorCount";
            this.TB_ProccesorCount.ReadOnly = true;
            this.TB_ProccesorCount.Size = new System.Drawing.Size(32, 20);
            this.TB_ProccesorCount.TabIndex = 0;
            // 
            // BT_DiskInfo
            // 
            this.BT_DiskInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_DiskInfo.Location = new System.Drawing.Point(370, 12);
            this.BT_DiskInfo.Name = "BT_DiskInfo";
            this.BT_DiskInfo.Size = new System.Drawing.Size(372, 23);
            this.BT_DiskInfo.TabIndex = 7;
            this.BT_DiskInfo.Text = "Разделы";
            this.BT_DiskInfo.UseVisualStyleBackColor = true;
            this.BT_DiskInfo.Click += new System.EventHandler(this.BT_DiskInfo_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(12, 306);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Ver 0.01";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(561, 306);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Разработчик: Александр Терещук";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 324);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BT_DiskInfo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BT_InfoAboutUser);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YourPC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Gun;
        private System.Windows.Forms.TextBox TB_OSVersion;
        private System.Windows.Forms.TextBox TB_64_86;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_InfoAboutUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_BiosVersion;
        private System.Windows.Forms.TextBox TB_PCName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_Keyboard;
        private System.Windows.Forms.TextBox TB_Mouse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Mhz;
        private System.Windows.Forms.TextBox TB_ProccesName;
        private System.Windows.Forms.TextBox TB_ProccesorCount;
        private System.Windows.Forms.Button BT_DiskInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_MatName;
        private System.Windows.Forms.ListView LV_AllDisks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_FreeSpace;
        private System.Windows.Forms.TextBox TB_FullSpace;
        private System.Windows.Forms.TextBox TB_FileSystem;
        private System.Windows.Forms.TextBox TB_IDName;
        private System.Windows.Forms.TextBox TB_DiskType;
        private System.Windows.Forms.TextBox TB_IDProcessor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_MBNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_BiosDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

