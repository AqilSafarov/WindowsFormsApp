
namespace Winforms_Hotel_Project
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.LContinue = new System.Windows.Forms.Label();
            this.CloseLog = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseLog);
            this.panel1.Controls.Add(this.LContinue);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UserPasswordTxt);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 418);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winforms_Hotel_Project.Properties.Resources.hotel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(326, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(270, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(288, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 66;
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.BackColor = System.Drawing.Color.White;
            this.UserPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UserPasswordTxt.Location = new System.Drawing.Point(288, 225);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '*';
            this.UserPasswordTxt.Size = new System.Drawing.Size(250, 37);
            this.UserPasswordTxt.TabIndex = 65;
            // 
            // Loginbtn
            // 
            this.Loginbtn.ActiveBorderThickness = 1;
            this.Loginbtn.ActiveCornerRadius = 20;
            this.Loginbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Loginbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Loginbtn.BackColor = System.Drawing.Color.White;
            this.Loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbtn.BackgroundImage")));
            this.Loginbtn.ButtonText = "Login";
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Loginbtn.IdleBorderThickness = 1;
            this.Loginbtn.IdleCornerRadius = 20;
            this.Loginbtn.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loginbtn.IdleForecolor = System.Drawing.Color.White;
            this.Loginbtn.IdleLineColor = System.Drawing.Color.Snow;
            this.Loginbtn.Location = new System.Drawing.Point(588, 209);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(139, 65);
            this.Loginbtn.TabIndex = 64;
            this.Loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "*";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "Password";
            // 
            // LContinue
            // 
            this.LContinue.AutoSize = true;
            this.LContinue.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContinue.ForeColor = System.Drawing.Color.Black;
            this.LContinue.Location = new System.Drawing.Point(336, 368);
            this.LContinue.Name = "LContinue";
            this.LContinue.Size = new System.Drawing.Size(72, 24);
            this.LContinue.TabIndex = 67;
            this.LContinue.Text = "Cancel";
            this.LContinue.Click += new System.EventHandler(this.LContinue_Click);
            // 
            // CloseLog
            // 
            this.CloseLog.Image = global::Winforms_Hotel_Project.Properties.Resources.delete_icon;
            this.CloseLog.Location = new System.Drawing.Point(723, 19);
            this.CloseLog.Name = "CloseLog";
            this.CloseLog.Size = new System.Drawing.Size(31, 32);
            this.CloseLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseLog.TabIndex = 68;
            this.CloseLog.TabStop = false;
            this.CloseLog.Click += new System.EventHandler(this.CloseLog_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserPasswordTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LContinue;
        private System.Windows.Forms.PictureBox CloseLog;
    }
}