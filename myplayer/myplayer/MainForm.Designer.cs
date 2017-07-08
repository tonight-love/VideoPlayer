namespace myplayer
{
    partial class PlayerForm
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
            this.components = new System.ComponentModel.Container();
            DMPlay.Item item2 = new DMPlay.Item();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.list_play = new DMPlay.DMControl();
            this.metroContextMenu1 = new DMSkin.Metro.Controls.MetroContextMenu(this.components);
            this.打开视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除当前视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空视频列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_play = new DMSkin.Controls.DMLabel();
            this.lb_list = new DMSkin.Controls.DMLabel();
            this.lb_openFile = new DMSkin.Controls.DMLabel();
            this.lb_stop = new DMSkin.Controls.DMLabel();
            this.lb_vol = new DMSkin.Controls.DMLabel();
            this.pgb_vol = new DMSkin.Controls.DMProgressBar();
            this.lb_max = new DMSkin.Controls.DMLabel();
            this.pgb_time = new DMSkin.Controls.DMProgressBar();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.lb_admin = new DMSkin.Controls.DMLabel();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_set = new DMSkin.Controls.DMLabel();
            this.lb_jietu = new DMSkin.Controls.DMLabel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btn_min = new DMSkin.Controls.DMButtonMinLight();
            this.btn_close = new DMSkin.Controls.DMButtonCloseLight();
            this.midpanel = new System.Windows.Forms.Panel();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.masterPanel = new System.Windows.Forms.Panel();
            this.player = new AxAPlayer3Lib.AxPlayer();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.list_title = new System.Windows.Forms.Label();
            this.metroContextMenu1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.midpanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_play
            // 
            this.list_play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.list_play.ArrowColor = System.Drawing.Color.Empty;
            this.list_play.BackColor = System.Drawing.SystemColors.HighlightText;
            this.list_play.ForeColor = System.Drawing.SystemColors.Control;
            this.list_play.ItemColor = System.Drawing.Color.CornflowerBlue;
            this.list_play.ItemMouseOnColor = System.Drawing.Color.Empty;
            item2.Bounds = new System.Drawing.Rectangle(0, 0, 20, 20);
            item2.Font = new System.Drawing.Font("微软雅黑", 9F);
            item2.ForeColor = System.Drawing.Color.Black;
            item2.Height = 20;
            item2.Image = null;
            item2.Index = null;
            item2.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            item2.OnLine = false;
            item2.OwnerChatListBox = this.list_play;
            item2.Text = "C#程序设计";
            item2.Url = null;
            item2.Width = 20;
            this.list_play.Items.AddRange(new DMSkin.Controls.DMControlItem[] {
            item2});
            this.list_play.Location = new System.Drawing.Point(1, 32);
            this.list_play.Name = "list_play";
            this.list_play.ScrollArrowBackColor = System.Drawing.Color.Transparent;
            this.list_play.ScrollArrowColor = System.Drawing.Color.Silver;
            this.list_play.ScrollBackColor = System.Drawing.Color.DarkSlateGray;
            this.list_play.ScrollSliderDefaultColor = System.Drawing.Color.DimGray;
            this.list_play.ScrollSliderDownColor = System.Drawing.SystemColors.WindowFrame;
            this.list_play.SelectItem = null;
            this.list_play.Size = new System.Drawing.Size(197, 446);
            this.list_play.SubItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.list_play.SubItemMouseOnColor = System.Drawing.Color.Maroon;
            this.list_play.SubItemSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.list_play.TabIndex = 0;
            this.list_play.Text = "dmControl1";
            this.list_play.ItemClick += new System.EventHandler(this.list_play_ItemClick);
            this.list_play.rightItemClick += new System.EventHandler(this.list_play_rightItemClick);
            this.list_play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_play_MouseClick);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开视频ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem,
            this.删除当前视频ToolStripMenuItem,
            this.清空视频列表ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu2";
            this.metroContextMenu1.Size = new System.Drawing.Size(169, 100);
            // 
            // 打开视频ToolStripMenuItem
            // 
            this.打开视频ToolStripMenuItem.Name = "打开视频ToolStripMenuItem";
            this.打开视频ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.打开视频ToolStripMenuItem.Text = "打开视频";
            this.打开视频ToolStripMenuItem.Click += new System.EventHandler(this.打开视频ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 删除当前视频ToolStripMenuItem
            // 
            this.删除当前视频ToolStripMenuItem.Name = "删除当前视频ToolStripMenuItem";
            this.删除当前视频ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除当前视频ToolStripMenuItem.Text = "删除当前视频";
            this.删除当前视频ToolStripMenuItem.Click += new System.EventHandler(this.删除当前视频ToolStripMenuItem_Click);
            // 
            // 清空视频列表ToolStripMenuItem
            // 
            this.清空视频列表ToolStripMenuItem.Name = "清空视频列表ToolStripMenuItem";
            this.清空视频列表ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.清空视频列表ToolStripMenuItem.Text = "清空视频列表";
            this.清空视频列表ToolStripMenuItem.Click += new System.EventHandler(this.清空视频列表ToolStripMenuItem_Click);
            // 
            // lb_play
            // 
            this.lb_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_play.BackColor = System.Drawing.Color.Transparent;
            this.lb_play.DM_Color = System.Drawing.Color.White;
            this.lb_play.DM_Font_Size = 15F;
            this.lb_play.DM_Key = DMSkin.Controls.DMLabelKey.播放;
            this.lb_play.DM_Text = "";
            this.lb_play.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_play.Location = new System.Drawing.Point(112, 31);
            this.lb_play.Name = "lb_play";
            this.lb_play.Size = new System.Drawing.Size(25, 25);
            this.lb_play.TabIndex = 29;
            this.lb_play.Text = "dmLabel1";
            this.lb_play.Click += new System.EventHandler(this.lb_play_Click);
            this.lb_play.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_play.MouseHover += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_list
            // 
            this.lb_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_list.BackColor = System.Drawing.Color.Transparent;
            this.lb_list.DM_Color = System.Drawing.Color.White;
            this.lb_list.DM_Font_Size = 13F;
            this.lb_list.DM_Key = DMSkin.Controls.DMLabelKey.菜单;
            this.lb_list.DM_Text = "";
            this.lb_list.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_list.Location = new System.Drawing.Point(729, 32);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(22, 22);
            this.lb_list.TabIndex = 29;
            this.lb_list.Text = "dmLabel1";
            this.lb_list.Click += new System.EventHandler(this.lb_list_Click);
            this.lb_list.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_list.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_openFile
            // 
            this.lb_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_openFile.BackColor = System.Drawing.Color.Transparent;
            this.lb_openFile.DM_Color = System.Drawing.Color.White;
            this.lb_openFile.DM_Font_Size = 16F;
            this.lb_openFile.DM_Key = DMSkin.Controls.DMLabelKey.打开;
            this.lb_openFile.DM_Text = "";
            this.lb_openFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_openFile.ForeColor = System.Drawing.Color.White;
            this.lb_openFile.Location = new System.Drawing.Point(23, 31);
            this.lb_openFile.Name = "lb_openFile";
            this.lb_openFile.Size = new System.Drawing.Size(25, 25);
            this.lb_openFile.TabIndex = 29;
            this.lb_openFile.Text = "dmLabel1";
            this.lb_openFile.Click += new System.EventHandler(this.lb_openFile_Click);
            this.lb_openFile.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_openFile.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_stop
            // 
            this.lb_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_stop.BackColor = System.Drawing.Color.Transparent;
            this.lb_stop.DM_Color = System.Drawing.Color.White;
            this.lb_stop.DM_Font_Size = 15F;
            this.lb_stop.DM_Key = DMSkin.Controls.DMLabelKey.停止;
            this.lb_stop.DM_Text = "";
            this.lb_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_stop.Location = new System.Drawing.Point(67, 31);
            this.lb_stop.Name = "lb_stop";
            this.lb_stop.Size = new System.Drawing.Size(25, 25);
            this.lb_stop.TabIndex = 29;
            this.lb_stop.Text = "dmLabel1";
            this.lb_stop.Click += new System.EventHandler(this.lb_stop_Click);
            this.lb_stop.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_stop.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_vol
            // 
            this.lb_vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_vol.BackColor = System.Drawing.Color.Transparent;
            this.lb_vol.DM_Color = System.Drawing.Color.White;
            this.lb_vol.DM_Font_Size = 15F;
            this.lb_vol.DM_Key = DMSkin.Controls.DMLabelKey.音量_小;
            this.lb_vol.DM_Text = "";
            this.lb_vol.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_vol.Location = new System.Drawing.Point(511, 32);
            this.lb_vol.Name = "lb_vol";
            this.lb_vol.Size = new System.Drawing.Size(27, 23);
            this.lb_vol.TabIndex = 29;
            this.lb_vol.Text = "dmLabel1";
            // 
            // pgb_vol
            // 
            this.pgb_vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_vol.BackColor = System.Drawing.Color.LightCoral;
            this.pgb_vol.DM_BackColor = System.Drawing.Color.Silver;
            this.pgb_vol.DM_BlockColor = System.Drawing.Color.White;
            this.pgb_vol.DM_BufferColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pgb_vol.DM_BufferValue = 0D;
            this.pgb_vol.DM_DrawRound = true;
            this.pgb_vol.Dm_OperationModel = DMSkin.Controls.DMProgressBar.OperationModel.Slide;
            this.pgb_vol.DM_RoundColor = System.Drawing.Color.White;
            this.pgb_vol.DM_RoundSize = 10;
            this.pgb_vol.DM_RoundX = 2;
            this.pgb_vol.DM_RoundY = 6;
            this.pgb_vol.DM_Value = 0D;
            this.pgb_vol.Location = new System.Drawing.Point(544, 32);
            this.pgb_vol.Name = "pgb_vol";
            this.pgb_vol.Size = new System.Drawing.Size(80, 23);
            this.pgb_vol.TabIndex = 30;
            this.pgb_vol.Text = "dmProgressBar1";
            this.pgb_vol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pgb_vol_MouseDown);
            this.pgb_vol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pgb_vol_MouseMove);
            this.pgb_vol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pgb_vol_MouseUp);
            // 
            // lb_max
            // 
            this.lb_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_max.BackColor = System.Drawing.Color.Transparent;
            this.lb_max.DM_Color = System.Drawing.Color.White;
            this.lb_max.DM_Font_Size = 13F;
            this.lb_max.DM_Key = DMSkin.Controls.DMLabelKey.拉伸_放大;
            this.lb_max.DM_Text = "";
            this.lb_max.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_max.Location = new System.Drawing.Point(687, 32);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(22, 22);
            this.lb_max.TabIndex = 29;
            this.lb_max.Text = "fullBtn";
            this.lb_max.Click += new System.EventHandler(this.lb_max_Click);
            this.lb_max.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_max.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // pgb_time
            // 
            this.pgb_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_time.BackColor = System.Drawing.Color.LightCoral;
            this.pgb_time.DM_BackColor = System.Drawing.Color.Gainsboro;
            this.pgb_time.DM_BlockColor = System.Drawing.Color.LightPink;
            this.pgb_time.DM_BufferColor = System.Drawing.Color.Empty;
            this.pgb_time.DM_BufferValue = 0D;
            this.pgb_time.DM_DrawRound = true;
            this.pgb_time.Dm_OperationModel = DMSkin.Controls.DMProgressBar.OperationModel.Slide;
            this.pgb_time.DM_RoundColor = System.Drawing.Color.WhiteSmoke;
            this.pgb_time.DM_RoundSize = 10;
            this.pgb_time.DM_RoundX = 6;
            this.pgb_time.DM_RoundY = 8;
            this.pgb_time.DM_Value = 0D;
            this.pgb_time.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgb_time.Location = new System.Drawing.Point(8, -3);
            this.pgb_time.Margin = new System.Windows.Forms.Padding(0);
            this.pgb_time.Name = "pgb_time";
            this.pgb_time.Size = new System.Drawing.Size(835, 26);
            this.pgb_time.TabIndex = 28;
            this.pgb_time.Text = "dmProgressBar1";
            this.pgb_time.Click += new System.EventHandler(this.pgb_time_Click);
            this.pgb_time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pgb_time_MouseDown);
            this.pgb_time.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pgb_time_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.LightCoral;
            this.menuPanel.Controls.Add(this.lb_admin);
            this.menuPanel.Controls.Add(this.lb_time);
            this.menuPanel.Controls.Add(this.lb_set);
            this.menuPanel.Controls.Add(this.pgb_time);
            this.menuPanel.Controls.Add(this.lb_list);
            this.menuPanel.Controls.Add(this.lb_play);
            this.menuPanel.Controls.Add(this.lb_vol);
            this.menuPanel.Controls.Add(this.lb_jietu);
            this.menuPanel.Controls.Add(this.lb_max);
            this.menuPanel.Controls.Add(this.pgb_vol);
            this.menuPanel.Controls.Add(this.lb_stop);
            this.menuPanel.Controls.Add(this.lb_openFile);
            this.menuPanel.Location = new System.Drawing.Point(7, 520);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(100);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(857, 69);
            this.menuPanel.TabIndex = 35;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canMove_Panel_MouseDown);
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canMove_Panel_MouseMove);
            // 
            // lb_admin
            // 
            this.lb_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_admin.BackColor = System.Drawing.Color.Transparent;
            this.lb_admin.DM_Color = System.Drawing.Color.White;
            this.lb_admin.DM_Font_Size = 13F;
            this.lb_admin.DM_Key = DMSkin.Controls.DMLabelKey.用户;
            this.lb_admin.DM_Text = "";
            this.lb_admin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_admin.Location = new System.Drawing.Point(800, 32);
            this.lb_admin.Name = "lb_admin";
            this.lb_admin.Size = new System.Drawing.Size(22, 22);
            this.lb_admin.TabIndex = 33;
            this.lb_admin.Text = "dmLabel1";
            this.lb_admin.Click += new System.EventHandler(this.lb_admin_Click);
            this.lb_admin.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_admin.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(162, 32);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(139, 19);
            this.lb_time.TabIndex = 32;
            this.lb_time.Text = "00:00 / 00:00";
            // 
            // lb_set
            // 
            this.lb_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_set.BackColor = System.Drawing.Color.Transparent;
            this.lb_set.DM_Color = System.Drawing.Color.White;
            this.lb_set.DM_Font_Size = 13F;
            this.lb_set.DM_Key = DMSkin.Controls.DMLabelKey.设置;
            this.lb_set.DM_Text = "";
            this.lb_set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_set.Location = new System.Drawing.Point(763, 32);
            this.lb_set.Name = "lb_set";
            this.lb_set.Size = new System.Drawing.Size(22, 22);
            this.lb_set.TabIndex = 32;
            this.lb_set.Text = "settingBtn";
            this.lb_set.Click += new System.EventHandler(this.lb_set_Click);
            this.lb_set.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_set.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // lb_jietu
            // 
            this.lb_jietu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_jietu.BackColor = System.Drawing.Color.Transparent;
            this.lb_jietu.DM_Color = System.Drawing.Color.White;
            this.lb_jietu.DM_Font_Size = 13F;
            this.lb_jietu.DM_Key = DMSkin.Controls.DMLabelKey.截图;
            this.lb_jietu.DM_Text = "";
            this.lb_jietu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_jietu.Location = new System.Drawing.Point(641, 32);
            this.lb_jietu.Name = "lb_jietu";
            this.lb_jietu.Size = new System.Drawing.Size(22, 22);
            this.lb_jietu.TabIndex = 29;
            this.lb_jietu.Text = "fullBtn";
            this.lb_jietu.Click += new System.EventHandler(this.lb_jietu_Click);
            this.lb_jietu.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_jietu.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.LightCoral;
            this.topPanel.Controls.Add(this.titleLbl);
            this.topPanel.Controls.Add(this.btn_min);
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(866, 44);
            this.topPanel.TabIndex = 36;
            this.topPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDoubleClick);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canMove_Panel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canMove_Panel_MouseMove);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(10, 6);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(369, 27);
            this.titleLbl.TabIndex = 33;
            this.titleLbl.Text = "基于APlayer引擎的视频播放器（郭峰）";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.Location = new System.Drawing.Point(779, 1);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(30, 32);
            this.btn_min.TabIndex = 31;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(817, 6);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.MaximumSize = new System.Drawing.Size(30, 27);
            this.btn_close.MinimumSize = new System.Drawing.Size(30, 27);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 27);
            this.btn_close.TabIndex = 30;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // midpanel
            // 
            this.midpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.midpanel.Controls.Add(this.playerPanel);
            this.midpanel.Controls.Add(this.rightPanel);
            this.midpanel.Location = new System.Drawing.Point(3, 41);
            this.midpanel.Name = "midpanel";
            this.midpanel.Size = new System.Drawing.Size(866, 478);
            this.midpanel.TabIndex = 37;
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.masterPanel);
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel.Location = new System.Drawing.Point(0, 0);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(666, 478);
            this.playerPanel.TabIndex = 1;
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.player);
            this.masterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterPanel.Location = new System.Drawing.Point(0, 0);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.Size = new System.Drawing.Size(666, 478);
            this.masterPanel.TabIndex = 1;
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(666, 478);
            this.player.TabIndex = 0;
            this.player.OnMessage += new AxAPlayer3Lib._IPlayerEvents_OnMessageEventHandler(this.player_OnMessage);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.rightPanel.Controls.Add(this.list_title);
            this.rightPanel.Controls.Add(this.list_play);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightPanel.Location = new System.Drawing.Point(666, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 478);
            this.rightPanel.TabIndex = 0;
            // 
            // list_title
            // 
            this.list_title.AutoSize = true;
            this.list_title.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_title.Location = new System.Drawing.Point(52, 9);
            this.list_title.Name = "list_title";
            this.list_title.Size = new System.Drawing.Size(116, 18);
            this.list_title.TabIndex = 1;
            this.list_title.Text = "我的视频列表";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(871, 600);
            this.Controls.Add(this.midpanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.DM_CanResize = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "PlayerForm";
            this.Opacity = 0.2D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的播放器（郭峰）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.Load += new System.EventHandler(this.mainFrom_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.midpanel.ResumeLayout(false);
            this.playerPanel.ResumeLayout(false);
            this.masterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DMSkin.Controls.DMLabel lb_play;
        private DMSkin.Controls.DMLabel lb_list;
        private DMSkin.Controls.DMLabel lb_openFile;
        private DMSkin.Controls.DMLabel lb_stop;
        private DMSkin.Controls.DMLabel lb_vol;
        private DMSkin.Controls.DMProgressBar pgb_vol;
        private DMSkin.Controls.DMLabel lb_max;
        private DMSkin.Controls.DMProgressBar pgb_time;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topPanel;
        private DMSkin.Controls.DMLabel lb_set;
        private DMSkin.Controls.DMButtonCloseLight btn_close;
        private System.Windows.Forms.Panel midpanel;
        private System.Windows.Forms.Panel rightPanel;
        private DMPlay.DMControl list_play;
        private System.Windows.Forms.Label list_title;
        private DMSkin.Metro.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 打开视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空视频列表ToolStripMenuItem;
        private DMSkin.Controls.DMLabel lb_jietu;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel masterPanel;
        private AxAPlayer3Lib.AxPlayer player;
        private DMSkin.Controls.DMLabel lb_admin;
        private DMSkin.Controls.DMButtonMinLight btn_min;
    }
}

