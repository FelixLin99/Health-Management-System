namespace BIManager
{
    partial class FRegister
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
            this.btnOK = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.txtLoginPwd = new Sunny.UI.UITextBox();
            this.txtLoginId = new Sunny.UI.UITextBox();
            this.txtPwdConfirm = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtUserName = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
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
            this.uiLabel1.Text = "新用户注册";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(141, 96);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(121, 32);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "账号:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(141, 224);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(77, 32);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "密码:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOK.Location = new System.Drawing.Point(161, 362);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(369, 362);
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
            this.txtLoginPwd.FillColor = System.Drawing.Color.White;
            this.txtLoginPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginPwd.Location = new System.Drawing.Point(243, 222);
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
            this.txtLoginPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginId.FillColor = System.Drawing.Color.White;
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginId.Location = new System.Drawing.Point(243, 96);
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
            this.txtLoginId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwdConfirm.FillColor = System.Drawing.Color.White;
            this.txtPwdConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPwdConfirm.Location = new System.Drawing.Point(243, 284);
            this.txtPwdConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwdConfirm.Maximum = 2147483647D;
            this.txtPwdConfirm.Minimum = -2147483648D;
            this.txtPwdConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwdConfirm.PasswordChar = '*';
            this.txtPwdConfirm.RectColor = System.Drawing.Color.Black;
            this.txtPwdConfirm.Size = new System.Drawing.Size(285, 34);
            this.txtPwdConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.txtPwdConfirm.TabIndex = 4;
            this.txtPwdConfirm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(88, 286);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(148, 32);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "确认密码:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FillColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtUserName.Location = new System.Drawing.Point(243, 160);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Maximum = 2147483647D;
            this.txtUserName.Minimum = -2147483648D;
            this.txtUserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserName.RectColor = System.Drawing.Color.Black;
            this.txtUserName.Size = new System.Drawing.Size(285, 34);
            this.txtUserName.Style = Sunny.UI.UIStyle.Custom;
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(115, 160);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(104, 32);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "用户名:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 431);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txtPwdConfirm);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton btnOK;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UITextBox txtLoginPwd;
        private Sunny.UI.UITextBox txtLoginId;
        private Sunny.UI.UITextBox txtPwdConfirm;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtUserName;
        private Sunny.UI.UILabel uiLabel5;
    }
}