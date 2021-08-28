namespace BIManager
{
    partial class FLogin
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
            this.txtLoginPwd = new Sunny.UI.UITextBox();
            this.txtLoginId = new Sunny.UI.UITextBox();
            this.uiSymbolButton25 = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(213, 51);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "用户登录";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(128, 131);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(80, 32);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "账号:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(128, 205);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(80, 34);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "密码:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(151, 310);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(361, 310);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Size = new System.Drawing.Size(139, 35);
            this.btnCancel.Style = Sunny.UI.UIStyle.Red;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPwd.DoubleValue = 123456D;
            this.txtLoginPwd.FillColor = System.Drawing.Color.White;
            this.txtLoginPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginPwd.IntValue = 123456;
            this.txtLoginPwd.Location = new System.Drawing.Point(215, 205);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginPwd.Maximum = 2147483647D;
            this.txtLoginPwd.Minimum = -2147483648D;
            this.txtLoginPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.RectColor = System.Drawing.Color.Black;
            this.txtLoginPwd.Size = new System.Drawing.Size(285, 34);
            this.txtLoginPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.Text = "123456";
            this.txtLoginPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginId.DoubleValue = 100001D;
            this.txtLoginId.FillColor = System.Drawing.Color.White;
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginId.IntValue = 100001;
            this.txtLoginId.Location = new System.Drawing.Point(215, 131);
            this.txtLoginId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginId.Maximum = 2147483647D;
            this.txtLoginId.Minimum = -2147483648D;
            this.txtLoginId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Padding = new System.Windows.Forms.Padding(5);
            this.txtLoginId.RectColor = System.Drawing.Color.Black;
            this.txtLoginId.Size = new System.Drawing.Size(285, 34);
            this.txtLoginId.Style = Sunny.UI.UIStyle.Custom;
            this.txtLoginId.TabIndex = 1;
            this.txtLoginId.Text = "100001";
            this.txtLoginId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton25
            // 
            this.uiSymbolButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiSymbolButton25.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiSymbolButton25.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiSymbolButton25.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolButton25.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton25.ForeColor = System.Drawing.Color.Purple;
            this.uiSymbolButton25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton25.Location = new System.Drawing.Point(534, 25);
            this.uiSymbolButton25.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton25.Name = "uiSymbolButton25";
            this.uiSymbolButton25.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.uiSymbolButton25.RectColor = System.Drawing.Color.Black;
            this.uiSymbolButton25.RectHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton25.Size = new System.Drawing.Size(96, 35);
            this.uiSymbolButton25.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton25.StyleCustomMode = true;
            this.uiSymbolButton25.Symbol = 62004;
            this.uiSymbolButton25.SymbolSize = 28;
            this.uiSymbolButton25.TabIndex = 56;
            this.uiSymbolButton25.Text = "注册";
            this.uiSymbolButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton25.Click += new System.EventHandler(this.uiSymbolButton25_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BIManager.Properties.Resources.sport1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(674, 402);
            this.Controls.Add(this.uiSymbolButton25);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
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
        private Sunny.UI.UITextBox txtLoginPwd;
        private Sunny.UI.UITextBox txtLoginId;
        private Sunny.UI.UISymbolButton uiSymbolButton25;
    }
}