namespace BIManager
{
    partial class FMetal
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
            this.uiBreadcrumb1 = new Sunny.UI.UIBreadcrumb();
            this.uiProcessBar1 = new Sunny.UI.UIProcessBar();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLedLabel3 = new Sunny.UI.UILedLabel();
            this.uiLedLabel2 = new Sunny.UI.UILedLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.BackColor = System.Drawing.Color.Transparent;
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiBreadcrumb1);
            this.PagePanel.Controls.Add(this.uiProcessBar1);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLedLabel3);
            this.PagePanel.Controls.Add(this.uiLedLabel2);
            this.PagePanel.Controls.Add(this.uiLedLabel1);
            this.PagePanel.Controls.Add(this.pictureBox3);
            this.PagePanel.Controls.Add(this.pictureBox2);
            this.PagePanel.Controls.Add(this.pictureBox1);
            this.PagePanel.FillColor = System.Drawing.Color.Transparent;
            this.PagePanel.FillDisableColor = System.Drawing.Color.Transparent;
            this.PagePanel.Size = new System.Drawing.Size(959, 547);
            this.PagePanel.Style = Sunny.UI.UIStyle.Custom;
            // 
            // uiBreadcrumb1
            // 
            this.uiBreadcrumb1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiBreadcrumb1.ItemIndex = 0;
            this.uiBreadcrumb1.Items.AddRange(new object[] {
            "入门",
            "新手",
            "玩家",
            "专家",
            "元老"});
            this.uiBreadcrumb1.Location = new System.Drawing.Point(111, 295);
            this.uiBreadcrumb1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBreadcrumb1.Name = "uiBreadcrumb1";
            this.uiBreadcrumb1.Size = new System.Drawing.Size(561, 25);
            this.uiBreadcrumb1.Style = Sunny.UI.UIStyle.Custom;
            this.uiBreadcrumb1.TabIndex = 75;
            this.uiBreadcrumb1.Text = "uiBreadcrumb1";
            // 
            // uiProcessBar1
            // 
            this.uiProcessBar1.DecimalCount = 1;
            this.uiProcessBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProcessBar1.Location = new System.Drawing.Point(111, 356);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(70, 1);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.Size = new System.Drawing.Size(543, 15);
            this.uiProcessBar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiProcessBar1.TabIndex = 74;
            this.uiProcessBar1.Text = "50.0%";
            this.uiProcessBar1.Value = 50;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(12, 295);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(92, 21);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 76;
            this.uiLabel4.Text = "当前等级:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(12, 351);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(92, 21);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 77;
            this.uiLabel5.Text = "升级进度:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLedLabel3
            // 
            this.uiLedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLedLabel3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiLedLabel3.IntervalOn = 3;
            this.uiLedLabel3.Location = new System.Drawing.Point(394, 184);
            this.uiLedLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel3.Name = "uiLedLabel3";
            this.uiLedLabel3.Size = new System.Drawing.Size(150, 35);
            this.uiLedLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel3.TabIndex = 35;
            this.uiLedLabel3.Text = "4";
            this.uiLedLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLedLabel2
            // 
            this.uiLedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLedLabel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiLedLabel2.IntervalOn = 3;
            this.uiLedLabel2.Location = new System.Drawing.Point(211, 184);
            this.uiLedLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel2.Name = "uiLedLabel2";
            this.uiLedLabel2.Size = new System.Drawing.Size(150, 35);
            this.uiLedLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel2.TabIndex = 34;
            this.uiLedLabel2.Text = "2";
            this.uiLedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(26, 193);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(73, 17);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 36;
            this.uiLabel1.Text = "累计获得:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiLedLabel1.IntervalOn = 3;
            this.uiLedLabel1.Location = new System.Drawing.Point(29, 184);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(150, 35);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.TabIndex = 33;
            this.uiLedLabel1.Text = "3";
            this.uiLedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(208, 193);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(73, 17);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 37;
            this.uiLabel2.Text = "累计获得:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BIManager.Properties.Resources.metal_calories1;
            this.pictureBox3.Location = new System.Drawing.Point(394, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(391, 193);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(73, 17);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 38;
            this.uiLabel3.Text = "累计获得:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BIManager.Properties.Resources.metal_free1;
            this.pictureBox2.Location = new System.Drawing.Point(211, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BIManager.Properties.Resources.metal_run;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FMetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 582);
            this.Name = "FMetal";
            this.Symbol = 61445;
            this.Text = "我的勋章";
            this.PagePanel.ResumeLayout(false);
            this.PagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.Style = Sunny.UI.UIStyle.Red;

        }

        #endregion
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIBreadcrumb uiBreadcrumb1;
        private Sunny.UI.UIProcessBar uiProcessBar1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILedLabel uiLedLabel3;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}