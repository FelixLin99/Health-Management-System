namespace BIManager
{
    partial class FBodyEdit
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
            this.btnLogin = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.txtHeightBox = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtWeightBox = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtFatBox = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(14, 11);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(317, 61);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "更新身体数据";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(178, 104);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(92, 38);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "身高:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(127, 371);
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
            this.btnCancel.Location = new System.Drawing.Point(448, 371);
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
            // txtHeightBox
            // 
            this.txtHeightBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHeightBox.Location = new System.Drawing.Point(278, 108);
            this.txtHeightBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHeightBox.Maximum = 300;
            this.txtHeightBox.Minimum = 0;
            this.txtHeightBox.HasMaximum = true;
            this.txtHeightBox.HasMinimum = true;
            this.txtHeightBox.MinimumSize = new System.Drawing.Size(112, 0);
            this.txtHeightBox.Name = "txtHeightBox";
            this.txtHeightBox.Size = new System.Drawing.Size(178, 38);
            this.txtHeightBox.Style = Sunny.UI.UIStyle.Custom;
            this.txtHeightBox.TabIndex = 23;
            this.txtHeightBox.Text = "_uiIntegerUpDown1";
            this.txtHeightBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(464, 108);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(78, 38);
            this.uiLabel4.TabIndex = 24;
            this.uiLabel4.Text = "cm";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(464, 190);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(78, 38);
            this.uiLabel5.TabIndex = 55;
            this.uiLabel5.Text = "kg";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeightBox
            // 
            this.txtWeightBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtWeightBox.Location = new System.Drawing.Point(278, 190);
            this.txtWeightBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWeightBox.Maximum = 300;
            this.txtWeightBox.Minimum = 0;
            this.txtWeightBox.HasMaximum = true;
            this.txtWeightBox.HasMinimum = true;
            this.txtWeightBox.MinimumSize = new System.Drawing.Size(112, 0);
            this.txtWeightBox.Name = "txtWeightBox";
            this.txtWeightBox.Size = new System.Drawing.Size(178, 38);
            this.txtWeightBox.Style = Sunny.UI.UIStyle.Custom;
            this.txtWeightBox.TabIndex = 54;
            this.txtWeightBox.Text = "_uiIntegerUpDown1";
            this.txtWeightBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(178, 186);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(92, 38);
            this.uiLabel6.TabIndex = 53;
            this.uiLabel6.Text = "体重:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(464, 272);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(78, 38);
            this.uiLabel7.TabIndex = 58;
            this.uiLabel7.Text = "%";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFatBox
            // 
            this.txtFatBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtFatBox.Location = new System.Drawing.Point(278, 272);
            this.txtFatBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFatBox.Maximum = 50;
            this.txtFatBox.Minimum = 0;
            this.txtFatBox.HasMinimum = true;
            this.txtFatBox.HasMaximum = true;
            this.txtFatBox.MinimumSize = new System.Drawing.Size(112, 0);
            this.txtFatBox.Name = "txtFatBox";
            this.txtFatBox.Size = new System.Drawing.Size(178, 38);
            this.txtFatBox.Style = Sunny.UI.UIStyle.Custom;
            this.txtFatBox.TabIndex = 57;
            this.txtFatBox.Text = "_uiIntegerUpDown1";
            this.txtFatBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("华文宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(178, 269);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(92, 38);
            this.uiLabel8.TabIndex = 56;
            this.uiLabel8.Text = "体脂:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FBodyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 479);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.txtFatBox);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txtWeightBox);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtHeightBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FBodyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UIIntegerUpDown txtHeightBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIIntegerUpDown txtWeightBox;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown txtFatBox;
        private Sunny.UI.UILabel uiLabel8;
    }
}