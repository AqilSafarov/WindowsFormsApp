
namespace Winforms_Hotel_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.CloseLog = new System.Windows.Forms.PictureBox();
            this.LContinue = new System.Windows.Forms.Label();
            this.Loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UserPasswordTxt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.UserNameTxt);
            this.panel1.Controls.Add(this.CloseLog);
            this.panel1.Controls.Add(this.LContinue);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 517);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(430, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 62;
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.BackColor = System.Drawing.Color.White;
            this.UserPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UserPasswordTxt.Location = new System.Drawing.Point(430, 383);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '*';
            this.UserPasswordTxt.Size = new System.Drawing.Size(250, 37);
            this.UserPasswordTxt.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(430, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 60;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.White;
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UserNameTxt.Location = new System.Drawing.Point(430, 284);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(250, 37);
            this.UserNameTxt.TabIndex = 59;
            this.UserNameTxt.TextChanged += new System.EventHandler(this.UserNameTxt_TextChanged);
            // 
            // CloseLog
            // 
            this.CloseLog.Image = global::Winforms_Hotel_Project.Properties.Resources.delete_icon;
            this.CloseLog.Location = new System.Drawing.Point(913, 17);
            this.CloseLog.Name = "CloseLog";
            this.CloseLog.Size = new System.Drawing.Size(42, 45);
            this.CloseLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseLog.TabIndex = 58;
            this.CloseLog.TabStop = false;
            this.CloseLog.Click += new System.EventHandler(this.CloseLog_Click);
            // 
            // LContinue
            // 
            this.LContinue.AutoSize = true;
            this.LContinue.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContinue.ForeColor = System.Drawing.Color.Black;
            this.LContinue.Location = new System.Drawing.Point(426, 475);
            this.LContinue.Name = "LContinue";
            this.LContinue.Size = new System.Drawing.Size(183, 24);
            this.LContinue.TabIndex = 57;
            this.LContinue.Text = "Continue as Admin";
            this.LContinue.Click += new System.EventHandler(this.LContinue_Click);
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
            this.Loginbtn.Location = new System.Drawing.Point(730, 367);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(139, 65);
            this.Loginbtn.TabIndex = 56;
            this.Loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "*";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "User Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(231, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 50;
            this.label11.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winforms_Hotel_Project.Properties.Resources.hotel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(395, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(329, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1001, 541);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox CloseLog;
        private System.Windows.Forms.Label LContinue;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserPasswordTxt;
    }
}