namespace myplayer
{
    partial class SettingForm
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
            this.closeBtn = new DMSkin.Controls.DMButtonCloseLight();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_choose = new DMSkin.Controls.DMLabel();
            this.dmTextBox1 = new DMSkin.Controls.DMTextBox();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Location = new System.Drawing.Point(406, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.MaximumSize = new System.Drawing.Size(30, 27);
            this.closeBtn.MinimumSize = new System.Drawing.Size(30, 27);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 27);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片存储位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(236, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 6;
            // 
            // lb_choose
            // 
            this.lb_choose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_choose.BackColor = System.Drawing.Color.Transparent;
            this.lb_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_choose.DM_Color = System.Drawing.Color.White;
            this.lb_choose.DM_Font_Size = 13F;
            this.lb_choose.DM_Key = DMSkin.Controls.DMLabelKey.文件夹_打开;
            this.lb_choose.DM_Text = "";
            this.lb_choose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_choose.Location = new System.Drawing.Point(360, 85);
            this.lb_choose.Name = "lb_choose";
            this.lb_choose.Size = new System.Drawing.Size(30, 23);
            this.lb_choose.TabIndex = 34;
            this.lb_choose.Text = "dmLabel1";
            this.lb_choose.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
            this.lb_choose.MouseLeave += new System.EventHandler(this.btns_MouseLeave);
            this.lb_choose.Click += new System.EventHandler(this.lb_choose_Click);
            // 
            // dmTextBox1
            // 
            this.dmTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dmTextBox1.Location = new System.Drawing.Point(50, 85);
            this.dmTextBox1.Name = "dmTextBox1";
            this.dmTextBox1.Size = new System.Drawing.Size(295, 23);
            this.dmTextBox1.TabIndex = 35;
            this.dmTextBox1.WaterText = "";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(443, 182);
            this.Controls.Add(this.dmTextBox1);
            this.Controls.Add(this.lb_choose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.DM_BackToColor = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Controls.DMButtonCloseLight closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DMSkin.Controls.DMLabel lb_choose;
        private DMSkin.Controls.DMTextBox dmTextBox1;
    }
}