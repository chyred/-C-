namespace WindowsFormsApplication2
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.将目标图片设置为桌面壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旋转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左旋90度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右旋90度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.马赛克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部分区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锐化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.柔化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雾化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰度化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.边缘检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像去噪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.光照效果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暗角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.百叶窗效果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直百叶窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平百叶窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button12 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(29, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "原图片";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(538, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "目标图片";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(542, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(323, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "亮度变化";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.文件ToolStripMenuItem,
            this.图像操作ToolStripMenuItem,
            this.图片处理ToolStripMenuItem,
            this.个性化ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripTextBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem});
            this.toolStripTextBox1.Image = global::WindowsFormsApplication2.Properties.Resources.timg;
            this.toolStripTextBox1.ImageTransparentColor = System.Drawing.Color.Silver;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(28, 21);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.保存图片ToolStripMenuItem,
            this.将目标图片设置为桌面壁纸ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.文件ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.打开文件ToolStripMenuItem.Text = "打开图片";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 保存图片ToolStripMenuItem
            // 
            this.保存图片ToolStripMenuItem.Name = "保存图片ToolStripMenuItem";
            this.保存图片ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.保存图片ToolStripMenuItem.Text = "保存图片";
            this.保存图片ToolStripMenuItem.Click += new System.EventHandler(this.保存图片ToolStripMenuItem_Click);
            // 
            // 将目标图片设置为桌面壁纸ToolStripMenuItem
            // 
            this.将目标图片设置为桌面壁纸ToolStripMenuItem.Name = "将目标图片设置为桌面壁纸ToolStripMenuItem";
            this.将目标图片设置为桌面壁纸ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.将目标图片设置为桌面壁纸ToolStripMenuItem.Text = "将目标图片设置为桌面壁纸";
            this.将目标图片设置为桌面壁纸ToolStripMenuItem.Click += new System.EventHandler(this.将目标图片设置为桌面壁纸ToolStripMenuItem_Click);
            // 
            // 图像操作ToolStripMenuItem
            // 
            this.图像操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.旋转ToolStripMenuItem,
            this.马赛克ToolStripMenuItem,
            this.锐化ToolStripMenuItem,
            this.柔化ToolStripMenuItem,
            this.雾化ToolStripMenuItem});
            this.图像操作ToolStripMenuItem.Name = "图像操作ToolStripMenuItem";
            this.图像操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图像操作ToolStripMenuItem.Text = "图像操作";
            // 
            // 旋转ToolStripMenuItem
            // 
            this.旋转ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左旋90度ToolStripMenuItem,
            this.右旋90度ToolStripMenuItem,
            this.自定义ToolStripMenuItem1});
            this.旋转ToolStripMenuItem.Name = "旋转ToolStripMenuItem";
            this.旋转ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.旋转ToolStripMenuItem.Text = "旋转";
            // 
            // 左旋90度ToolStripMenuItem
            // 
            this.左旋90度ToolStripMenuItem.Name = "左旋90度ToolStripMenuItem";
            this.左旋90度ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.左旋90度ToolStripMenuItem.Text = "左旋90度";
            this.左旋90度ToolStripMenuItem.Click += new System.EventHandler(this.左旋90度ToolStripMenuItem_Click);
            // 
            // 右旋90度ToolStripMenuItem
            // 
            this.右旋90度ToolStripMenuItem.Name = "右旋90度ToolStripMenuItem";
            this.右旋90度ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.右旋90度ToolStripMenuItem.Text = "右旋90度";
            this.右旋90度ToolStripMenuItem.Click += new System.EventHandler(this.右旋90度ToolStripMenuItem_Click);
            // 
            // 自定义ToolStripMenuItem1
            // 
            this.自定义ToolStripMenuItem1.Name = "自定义ToolStripMenuItem1";
            this.自定义ToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.自定义ToolStripMenuItem1.Text = "自定义";
            this.自定义ToolStripMenuItem1.Click += new System.EventHandler(this.自定义ToolStripMenuItem1_Click);
            // 
            // 马赛克ToolStripMenuItem
            // 
            this.马赛克ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem,
            this.部分区域ToolStripMenuItem});
            this.马赛克ToolStripMenuItem.Name = "马赛克ToolStripMenuItem";
            this.马赛克ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.马赛克ToolStripMenuItem.Text = "马赛克";
            this.马赛克ToolStripMenuItem.Click += new System.EventHandler(this.马赛克ToolStripMenuItem_Click);
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // 部分区域ToolStripMenuItem
            // 
            this.部分区域ToolStripMenuItem.Name = "部分区域ToolStripMenuItem";
            this.部分区域ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.部分区域ToolStripMenuItem.Text = "部分区域";
            this.部分区域ToolStripMenuItem.Click += new System.EventHandler(this.部分区域ToolStripMenuItem_Click);
            // 
            // 锐化ToolStripMenuItem
            // 
            this.锐化ToolStripMenuItem.Name = "锐化ToolStripMenuItem";
            this.锐化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.锐化ToolStripMenuItem.Text = "锐化";
            this.锐化ToolStripMenuItem.Click += new System.EventHandler(this.锐化ToolStripMenuItem_Click);
            // 
            // 柔化ToolStripMenuItem
            // 
            this.柔化ToolStripMenuItem.Name = "柔化ToolStripMenuItem";
            this.柔化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.柔化ToolStripMenuItem.Text = "柔化";
            this.柔化ToolStripMenuItem.Click += new System.EventHandler(this.柔化ToolStripMenuItem_Click);
            // 
            // 雾化ToolStripMenuItem
            // 
            this.雾化ToolStripMenuItem.Name = "雾化ToolStripMenuItem";
            this.雾化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.雾化ToolStripMenuItem.Text = "雾化";
            this.雾化ToolStripMenuItem.Click += new System.EventHandler(this.雾化ToolStripMenuItem_Click);
            // 
            // 图片处理ToolStripMenuItem
            // 
            this.图片处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰度化ToolStripMenuItem,
            this.边缘检测ToolStripMenuItem,
            this.图像去噪ToolStripMenuItem});
            this.图片处理ToolStripMenuItem.Name = "图片处理ToolStripMenuItem";
            this.图片处理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图片处理ToolStripMenuItem.Text = "图片处理";
            // 
            // 灰度化ToolStripMenuItem
            // 
            this.灰度化ToolStripMenuItem.Name = "灰度化ToolStripMenuItem";
            this.灰度化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.灰度化ToolStripMenuItem.Text = "灰度化";
            this.灰度化ToolStripMenuItem.Click += new System.EventHandler(this.灰度化ToolStripMenuItem_Click);
            // 
            // 边缘检测ToolStripMenuItem
            // 
            this.边缘检测ToolStripMenuItem.Name = "边缘检测ToolStripMenuItem";
            this.边缘检测ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.边缘检测ToolStripMenuItem.Text = "边缘检测";
            this.边缘检测ToolStripMenuItem.Click += new System.EventHandler(this.边缘检测ToolStripMenuItem_Click);
            // 
            // 图像去噪ToolStripMenuItem
            // 
            this.图像去噪ToolStripMenuItem.Name = "图像去噪ToolStripMenuItem";
            this.图像去噪ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图像去噪ToolStripMenuItem.Text = "图像去噪";
            this.图像去噪ToolStripMenuItem.Click += new System.EventHandler(this.图像增强ToolStripMenuItem_Click);
            // 
            // 个性化ToolStripMenuItem
            // 
            this.个性化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.光照效果ToolStripMenuItem,
            this.暗角ToolStripMenuItem,
            this.浮雕ToolStripMenuItem,
            this.百叶窗效果ToolStripMenuItem});
            this.个性化ToolStripMenuItem.Name = "个性化ToolStripMenuItem";
            this.个性化ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.个性化ToolStripMenuItem.Text = "个性化";
            // 
            // 光照效果ToolStripMenuItem
            // 
            this.光照效果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.亮度ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.光照效果ToolStripMenuItem.Name = "光照效果ToolStripMenuItem";
            this.光照效果ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.光照效果ToolStripMenuItem.Text = "光照效果";
            this.光照效果ToolStripMenuItem.Click += new System.EventHandler(this.光照效果ToolStripMenuItem_Click);
            // 
            // 亮度ToolStripMenuItem
            // 
            this.亮度ToolStripMenuItem.Name = "亮度ToolStripMenuItem";
            this.亮度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.亮度ToolStripMenuItem.Text = "220亮度";
            this.亮度ToolStripMenuItem.Click += new System.EventHandler(this.亮度ToolStripMenuItem_Click);
            // 
            // 自定义ToolStripMenuItem
            // 
            this.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem";
            this.自定义ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.自定义ToolStripMenuItem.Text = "自定义";
            this.自定义ToolStripMenuItem.Click += new System.EventHandler(this.自定义ToolStripMenuItem_Click);
            // 
            // 暗角ToolStripMenuItem
            // 
            this.暗角ToolStripMenuItem.Name = "暗角ToolStripMenuItem";
            this.暗角ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.暗角ToolStripMenuItem.Text = "暗角";
            this.暗角ToolStripMenuItem.Click += new System.EventHandler(this.暗角ToolStripMenuItem_Click);
            // 
            // 浮雕ToolStripMenuItem
            // 
            this.浮雕ToolStripMenuItem.Name = "浮雕ToolStripMenuItem";
            this.浮雕ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.浮雕ToolStripMenuItem.Text = "浮雕";
            this.浮雕ToolStripMenuItem.Click += new System.EventHandler(this.浮雕ToolStripMenuItem_Click);
            // 
            // 百叶窗效果ToolStripMenuItem
            // 
            this.百叶窗效果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.垂直百叶窗ToolStripMenuItem,
            this.水平百叶窗ToolStripMenuItem});
            this.百叶窗效果ToolStripMenuItem.Name = "百叶窗效果ToolStripMenuItem";
            this.百叶窗效果ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.百叶窗效果ToolStripMenuItem.Text = "百叶窗效果";
            this.百叶窗效果ToolStripMenuItem.Click += new System.EventHandler(this.百叶窗效果ToolStripMenuItem_Click);
            // 
            // 垂直百叶窗ToolStripMenuItem
            // 
            this.垂直百叶窗ToolStripMenuItem.Name = "垂直百叶窗ToolStripMenuItem";
            this.垂直百叶窗ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.垂直百叶窗ToolStripMenuItem.Text = "垂直百叶窗";
            this.垂直百叶窗ToolStripMenuItem.Click += new System.EventHandler(this.垂直百叶窗ToolStripMenuItem_Click);
            // 
            // 水平百叶窗ToolStripMenuItem
            // 
            this.水平百叶窗ToolStripMenuItem.Name = "水平百叶窗ToolStripMenuItem";
            this.水平百叶窗ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.水平百叶窗ToolStripMenuItem.Text = "水平百叶窗";
            this.水平百叶窗ToolStripMenuItem.Click += new System.EventHandler(this.水平百叶窗ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(897, 491);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 30);
            this.button12.TabIndex = 18;
            this.button12.Text = "还原";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(29, 478);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(288, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 21);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.Location = new System.Drawing.Point(611, 493);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 22);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(540, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "文件路径：";
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
            // skinEngine2
            // 
            this.skinEngine2.@__DrawButtonFocusRectangle = true;
            this.skinEngine2.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine2.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine2.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine2.SerialNumber = "";
            this.skinEngine2.SkinFile = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "静态壁纸组件";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化ToolStripMenuItem;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左旋90度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右旋90度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 马赛克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锐化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 柔化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雾化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰度化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 边缘检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像去噪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 光照效果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暗角ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浮雕ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 百叶窗效果ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 垂直百叶窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平百叶窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部分区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 将目标图片设置为桌面壁纸ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine2;
    }
}

