namespace BIManager
{
    partial class FDiteEdit
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btnLogin = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.intakeAmountBox = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.sugarRateBox = new Sunny.UI.UIComboboxEx();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(14, 11);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(310, 61);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(126, 115);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(136, 38);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "摄入量:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(126, 199);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(136, 38);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "含糖量:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(132, 306);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "确认";
            this.btnLogin.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(370, 306);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Size = new System.Drawing.Size(156, 42);
            this.btnCancel.Style = Sunny.UI.UIStyle.Red;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // intakeAmountBox
            // 
            this.intakeAmountBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.intakeAmountBox.Location = new System.Drawing.Point(270, 115);
            this.intakeAmountBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.intakeAmountBox.Minimum = 0;
            this.intakeAmountBox.HasMinimum = true;
            this.intakeAmountBox.Maximum = 3000;
            this.intakeAmountBox.HasMaximum = true;
            this.intakeAmountBox.MinimumSize = new System.Drawing.Size(112, 0);
            this.intakeAmountBox.Name = "intakeAmountBox";
            this.intakeAmountBox.Size = new System.Drawing.Size(178, 43);
            this.intakeAmountBox.Step = 10;
            this.intakeAmountBox.Style = Sunny.UI.UIStyle.Custom;
            this.intakeAmountBox.TabIndex = 23;
            this.intakeAmountBox.Text = "_uiIntegerUpDown1";
            this.intakeAmountBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(456, 119);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(47, 38);
            this.uiLabel4.TabIndex = 24;
            this.uiLabel4.Text = "克";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sugarRateBox
            // 
            this.sugarRateBox.BackColor = System.Drawing.Color.White;
            this.sugarRateBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sugarRateBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sugarRateBox.FormattingEnabled = true;
            this.sugarRateBox.Items.AddRange(new object[] {
            "不含糖",
            "少量糖",
            "中等糖",
            "大量糖"});
            this.sugarRateBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sugarRateBox.Location = new System.Drawing.Point(269, 199);
            this.sugarRateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sugarRateBox.Name = "sugarRateBox";
            this.sugarRateBox.Size = new System.Drawing.Size(178, 40);
            this.sugarRateBox.Style = Sunny.UI.UIStyle.Custom;
            this.sugarRateBox.TabIndex = 51;
            // 
            // FDiteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 430);
            this.Controls.Add(this.sugarRateBox);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.intakeAmountBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FDiteEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UIIntegerUpDown intakeAmountBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboboxEx sugarRateBox;
    }
}