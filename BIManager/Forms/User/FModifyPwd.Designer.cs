namespace BIManager
{
    partial class FModifyPwd
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
            this.txtNewPwd = new Sunny.UI.UITextBox();
            this.txtOldPwd = new Sunny.UI.UITextBox();
            this.txtNewPwdConfirm = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(276, 51);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "修改登录密码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(115, 96);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(121, 32);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "原密码:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(115, 166);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(121, 32);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "新密码:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(161, 310);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 35);
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
            this.btnCancel.Location = new System.Drawing.Point(369, 310);
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
            // txtNewPwd
            // 
            this.txtNewPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPwd.FillColor = System.Drawing.Color.White;
            this.txtNewPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtNewPwd.Location = new System.Drawing.Point(243, 164);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPwd.Maximum = 2147483647D;
            this.txtNewPwd.Minimum = -2147483648D;
            this.txtNewPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.RectColor = System.Drawing.Color.Black;
            this.txtNewPwd.Size = new System.Drawing.Size(285, 39);
            this.txtNewPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtNewPwd.TabIndex = 2;
            this.txtNewPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPwd.FillColor = System.Drawing.Color.White;
            this.txtOldPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtOldPwd.Location = new System.Drawing.Point(243, 96);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPwd.Maximum = 2147483647D;
            this.txtOldPwd.Minimum = -2147483648D;
            this.txtOldPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.RectColor = System.Drawing.Color.Black;
            this.txtOldPwd.Size = new System.Drawing.Size(285, 39);
            this.txtOldPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtOldPwd.TabIndex = 1;
            this.txtOldPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPwdConfirm
            // 
            this.txtNewPwdConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPwdConfirm.FillColor = System.Drawing.Color.White;
            this.txtNewPwdConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtNewPwdConfirm.Location = new System.Drawing.Point(243, 232);
            this.txtNewPwdConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPwdConfirm.Maximum = 2147483647D;
            this.txtNewPwdConfirm.Minimum = -2147483648D;
            this.txtNewPwdConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPwdConfirm.Name = "txtNewPwdConfirm";
            this.txtNewPwdConfirm.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNewPwdConfirm.PasswordChar = '*';
            this.txtNewPwdConfirm.RectColor = System.Drawing.Color.Black;
            this.txtNewPwdConfirm.Size = new System.Drawing.Size(285, 39);
            this.txtNewPwdConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.txtNewPwdConfirm.TabIndex = 4;
            this.txtNewPwdConfirm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(88, 234);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(148, 32);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "确认密码:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 402);
            this.Controls.Add(this.txtNewPwdConfirm);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FModifyPwd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UITextBox txtNewPwd;
        private Sunny.UI.UITextBox txtOldPwd;
        private Sunny.UI.UITextBox txtNewPwdConfirm;
        private Sunny.UI.UILabel uiLabel4;
    }
}