namespace SetTime1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNow = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSureRset = new System.Windows.Forms.Button();
            this.cbbHoursRset = new System.Windows.Forms.ComboBox();
            this.cbbMinsRset = new System.Windows.Forms.ComboBox();
            this.cbbSecondsRset = new System.Windows.Forms.ComboBox();
            this.lblHoursRset = new System.Windows.Forms.Label();
            this.lblMinsRset = new System.Windows.Forms.Label();
            this.lblSecondsRset = new System.Windows.Forms.Label();
            this.BtnCancelRset = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSure2 = new System.Windows.Forms.Button();
            this.cbbHours2 = new System.Windows.Forms.ComboBox();
            this.cbbMins2 = new System.Windows.Forms.ComboBox();
            this.cbbDays = new System.Windows.Forms.ComboBox();
            this.lblHours2 = new System.Windows.Forms.Label();
            this.lblMins2 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbMonths = new System.Windows.Forms.ComboBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSure1 = new System.Windows.Forms.Button();
            this.cbbHours1 = new System.Windows.Forms.ComboBox();
            this.cbbMins1 = new System.Windows.Forms.ComboBox();
            this.cbbSeconds1 = new System.Windows.Forms.ComboBox();
            this.lblHours1 = new System.Windows.Forms.Label();
            this.lblMins1 = new System.Windows.Forms.Label();
            this.lblSeconds1 = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.BackColor = System.Drawing.Color.Transparent;
            this.lblNow.Location = new System.Drawing.Point(153, 7);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(0, 12);
            this.lblNow.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(336, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 19);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMin.Location = new System.Drawing.Point(318, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 19);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.BtnCancelRset);
            this.tabPage3.Controls.Add(this.lblSecondsRset);
            this.tabPage3.Controls.Add(this.lblMinsRset);
            this.tabPage3.Controls.Add(this.lblHoursRset);
            this.tabPage3.Controls.Add(this.cbbSecondsRset);
            this.tabPage3.Controls.Add(this.cbbMinsRset);
            this.tabPage3.Controls.Add(this.cbbHoursRset);
            this.tabPage3.Controls.Add(this.btnSureRset);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(349, 24);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "重启";
            // 
            // btnSureRset
            // 
            this.btnSureRset.Location = new System.Drawing.Point(260, 0);
            this.btnSureRset.Name = "btnSureRset";
            this.btnSureRset.Size = new System.Drawing.Size(40, 23);
            this.btnSureRset.TabIndex = 8;
            this.btnSureRset.Text = "确定";
            this.btnSureRset.UseVisualStyleBackColor = true;
            this.btnSureRset.Click += new System.EventHandler(this.btnSureRset_Click);
            // 
            // cbbHoursRset
            // 
            this.cbbHoursRset.FormattingEnabled = true;
            this.cbbHoursRset.Location = new System.Drawing.Point(6, 2);
            this.cbbHoursRset.Margin = new System.Windows.Forms.Padding(0);
            this.cbbHoursRset.Name = "cbbHoursRset";
            this.cbbHoursRset.Size = new System.Drawing.Size(38, 20);
            this.cbbHoursRset.TabIndex = 9;
            // 
            // cbbMinsRset
            // 
            this.cbbMinsRset.FormattingEnabled = true;
            this.cbbMinsRset.Location = new System.Drawing.Point(77, 3);
            this.cbbMinsRset.Name = "cbbMinsRset";
            this.cbbMinsRset.Size = new System.Drawing.Size(38, 20);
            this.cbbMinsRset.TabIndex = 10;
            // 
            // cbbSecondsRset
            // 
            this.cbbSecondsRset.FormattingEnabled = true;
            this.cbbSecondsRset.Location = new System.Drawing.Point(156, 3);
            this.cbbSecondsRset.Name = "cbbSecondsRset";
            this.cbbSecondsRset.Size = new System.Drawing.Size(33, 20);
            this.cbbSecondsRset.TabIndex = 11;
            // 
            // lblHoursRset
            // 
            this.lblHoursRset.AutoSize = true;
            this.lblHoursRset.Location = new System.Drawing.Point(42, 7);
            this.lblHoursRset.Name = "lblHoursRset";
            this.lblHoursRset.Size = new System.Drawing.Size(29, 12);
            this.lblHoursRset.TabIndex = 12;
            this.lblHoursRset.Text = "小时";
            // 
            // lblMinsRset
            // 
            this.lblMinsRset.AutoSize = true;
            this.lblMinsRset.Location = new System.Drawing.Point(121, 6);
            this.lblMinsRset.Name = "lblMinsRset";
            this.lblMinsRset.Size = new System.Drawing.Size(29, 12);
            this.lblMinsRset.TabIndex = 13;
            this.lblMinsRset.Text = "分钟";
            // 
            // lblSecondsRset
            // 
            this.lblSecondsRset.AutoSize = true;
            this.lblSecondsRset.Location = new System.Drawing.Point(192, 6);
            this.lblSecondsRset.Name = "lblSecondsRset";
            this.lblSecondsRset.Size = new System.Drawing.Size(65, 12);
            this.lblSecondsRset.TabIndex = 14;
            this.lblSecondsRset.Text = "秒  后重启";
            // 
            // BtnCancelRset
            // 
            this.BtnCancelRset.Location = new System.Drawing.Point(306, 0);
            this.BtnCancelRset.Name = "BtnCancelRset";
            this.BtnCancelRset.Size = new System.Drawing.Size(40, 23);
            this.BtnCancelRset.TabIndex = 15;
            this.BtnCancelRset.Text = "取消";
            this.BtnCancelRset.UseVisualStyleBackColor = true;
            this.BtnCancelRset.Click += new System.EventHandler(this.BtnCancelRset_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.lblMonths);
            this.tabPage2.Controls.Add(this.cbbMonths);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.lblDays);
            this.tabPage2.Controls.Add(this.lblMins2);
            this.tabPage2.Controls.Add(this.lblHours2);
            this.tabPage2.Controls.Add(this.cbbDays);
            this.tabPage2.Controls.Add(this.cbbMins2);
            this.tabPage2.Controls.Add(this.cbbHours2);
            this.tabPage2.Controls.Add(this.btnSure2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 24);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定时关机";
            // 
            // btnSure2
            // 
            this.btnSure2.Location = new System.Drawing.Point(266, 1);
            this.btnSure2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSure2.Name = "btnSure2";
            this.btnSure2.Size = new System.Drawing.Size(40, 23);
            this.btnSure2.TabIndex = 8;
            this.btnSure2.Text = "确定";
            this.btnSure2.UseVisualStyleBackColor = true;
            this.btnSure2.Click += new System.EventHandler(this.btnSure2_Click);
            // 
            // cbbHours2
            // 
            this.cbbHours2.FormattingEnabled = true;
            this.cbbHours2.Location = new System.Drawing.Point(135, 4);
            this.cbbHours2.Name = "cbbHours2";
            this.cbbHours2.Size = new System.Drawing.Size(38, 20);
            this.cbbHours2.TabIndex = 9;
            // 
            // cbbMins2
            // 
            this.cbbMins2.FormattingEnabled = true;
            this.cbbMins2.Location = new System.Drawing.Point(202, 3);
            this.cbbMins2.Name = "cbbMins2";
            this.cbbMins2.Size = new System.Drawing.Size(38, 20);
            this.cbbMins2.TabIndex = 10;
            // 
            // cbbDays
            // 
            this.cbbDays.FormattingEnabled = true;
            this.cbbDays.Location = new System.Drawing.Point(72, 4);
            this.cbbDays.Name = "cbbDays";
            this.cbbDays.Size = new System.Drawing.Size(33, 20);
            this.cbbDays.TabIndex = 11;
            // 
            // lblHours2
            // 
            this.lblHours2.AutoSize = true;
            this.lblHours2.Location = new System.Drawing.Point(179, 7);
            this.lblHours2.Name = "lblHours2";
            this.lblHours2.Size = new System.Drawing.Size(17, 12);
            this.lblHours2.TabIndex = 12;
            this.lblHours2.Text = "时";
            // 
            // lblMins2
            // 
            this.lblMins2.AutoSize = true;
            this.lblMins2.Location = new System.Drawing.Point(246, 6);
            this.lblMins2.Name = "lblMins2";
            this.lblMins2.Size = new System.Drawing.Size(17, 12);
            this.lblMins2.TabIndex = 13;
            this.lblMins2.Text = "分";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(112, 7);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(17, 12);
            this.lblDays.TabIndex = 14;
            this.lblDays.Text = "日";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbMonths
            // 
            this.cbbMonths.FormattingEnabled = true;
            this.cbbMonths.Location = new System.Drawing.Point(9, 4);
            this.cbbMonths.Name = "cbbMonths";
            this.cbbMonths.Size = new System.Drawing.Size(38, 20);
            this.cbbMonths.TabIndex = 16;
            this.cbbMonths.SelectedIndexChanged += new System.EventHandler(this.cbbMonths_SelectedIndexChanged);
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(49, 7);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(17, 12);
            this.lblMonths.TabIndex = 17;
            this.lblMonths.Text = "月";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnCancel1);
            this.tabPage1.Controls.Add(this.lblSeconds1);
            this.tabPage1.Controls.Add(this.lblMins1);
            this.tabPage1.Controls.Add(this.lblHours1);
            this.tabPage1.Controls.Add(this.cbbSeconds1);
            this.tabPage1.Controls.Add(this.cbbMins1);
            this.tabPage1.Controls.Add(this.cbbHours1);
            this.tabPage1.Controls.Add(this.btnSure1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 24);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "关机";
            // 
            // btnSure1
            // 
            this.btnSure1.BackColor = System.Drawing.Color.Transparent;
            this.btnSure1.Location = new System.Drawing.Point(258, -2);
            this.btnSure1.Name = "btnSure1";
            this.btnSure1.Size = new System.Drawing.Size(40, 23);
            this.btnSure1.TabIndex = 0;
            this.btnSure1.Text = "确定";
            this.btnSure1.UseVisualStyleBackColor = false;
            this.btnSure1.Click += new System.EventHandler(this.btnSure1_Click);
            // 
            // cbbHours1
            // 
            this.cbbHours1.FormattingEnabled = true;
            this.cbbHours1.Location = new System.Drawing.Point(7, 1);
            this.cbbHours1.Margin = new System.Windows.Forms.Padding(0);
            this.cbbHours1.Name = "cbbHours1";
            this.cbbHours1.Size = new System.Drawing.Size(38, 20);
            this.cbbHours1.TabIndex = 1;
            // 
            // cbbMins1
            // 
            this.cbbMins1.FormattingEnabled = true;
            this.cbbMins1.Location = new System.Drawing.Point(77, 1);
            this.cbbMins1.Name = "cbbMins1";
            this.cbbMins1.Size = new System.Drawing.Size(38, 20);
            this.cbbMins1.TabIndex = 2;
            // 
            // cbbSeconds1
            // 
            this.cbbSeconds1.FormattingEnabled = true;
            this.cbbSeconds1.Location = new System.Drawing.Point(153, 1);
            this.cbbSeconds1.Name = "cbbSeconds1";
            this.cbbSeconds1.Size = new System.Drawing.Size(33, 20);
            this.cbbSeconds1.TabIndex = 3;
            this.cbbSeconds1.SelectedIndexChanged += new System.EventHandler(this.cbbSeconds1_SelectedIndexChanged);
            // 
            // lblHours1
            // 
            this.lblHours1.AutoSize = true;
            this.lblHours1.BackColor = System.Drawing.Color.Transparent;
            this.lblHours1.Location = new System.Drawing.Point(45, 6);
            this.lblHours1.Margin = new System.Windows.Forms.Padding(0);
            this.lblHours1.Name = "lblHours1";
            this.lblHours1.Size = new System.Drawing.Size(29, 12);
            this.lblHours1.TabIndex = 4;
            this.lblHours1.Text = "小时";
            // 
            // lblMins1
            // 
            this.lblMins1.AutoSize = true;
            this.lblMins1.BackColor = System.Drawing.Color.Transparent;
            this.lblMins1.Location = new System.Drawing.Point(118, 6);
            this.lblMins1.Name = "lblMins1";
            this.lblMins1.Size = new System.Drawing.Size(29, 12);
            this.lblMins1.TabIndex = 5;
            this.lblMins1.Text = "分钟";
            // 
            // lblSeconds1
            // 
            this.lblSeconds1.AutoSize = true;
            this.lblSeconds1.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds1.Location = new System.Drawing.Point(192, 6);
            this.lblSeconds1.Name = "lblSeconds1";
            this.lblSeconds1.Size = new System.Drawing.Size(59, 12);
            this.lblSeconds1.TabIndex = 6;
            this.lblSeconds1.Text = "秒 后关机";
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel1.Location = new System.Drawing.Point(304, -2);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(40, 23);
            this.btnCancel1.TabIndex = 7;
            this.btnCancel1.Text = "取消";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 50);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.背景图片;
            this.ClientSize = new System.Drawing.Size(355, 49);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnCancelRset;
        private System.Windows.Forms.Label lblSecondsRset;
        private System.Windows.Forms.Label lblMinsRset;
        private System.Windows.Forms.Label lblHoursRset;
        private System.Windows.Forms.ComboBox cbbSecondsRset;
        private System.Windows.Forms.ComboBox cbbMinsRset;
        private System.Windows.Forms.ComboBox cbbHoursRset;
        private System.Windows.Forms.Button btnSureRset;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.ComboBox cbbMonths;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMins2;
        private System.Windows.Forms.Label lblHours2;
        private System.Windows.Forms.ComboBox cbbDays;
        private System.Windows.Forms.ComboBox cbbMins2;
        private System.Windows.Forms.ComboBox cbbHours2;
        private System.Windows.Forms.Button btnSure2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Label lblSeconds1;
        private System.Windows.Forms.Label lblMins1;
        private System.Windows.Forms.Label lblHours1;
        private System.Windows.Forms.ComboBox cbbSeconds1;
        private System.Windows.Forms.ComboBox cbbMins1;
        private System.Windows.Forms.ComboBox cbbHours1;
        private System.Windows.Forms.Button btnSure1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

