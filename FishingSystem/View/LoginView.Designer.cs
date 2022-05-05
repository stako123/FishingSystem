namespace FishingSystem.View
{
    partial class LoginView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginNametxt = new System.Windows.Forms.TextBox();
            this.LoginPasswordtxt = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LogInbtn
            // 
            this.LogInbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogInbtn.Location = new System.Drawing.Point(123, 285);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(146, 48);
            this.LogInbtn.TabIndex = 4;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = false;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(8, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 7;
            // 
            // LoginNametxt
            // 
            this.LoginNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginNametxt.Location = new System.Drawing.Point(92, 18);
            this.LoginNametxt.Multiline = true;
            this.LoginNametxt.Name = "LoginNametxt";
            this.LoginNametxt.Size = new System.Drawing.Size(156, 20);
            this.LoginNametxt.TabIndex = 8;
            // 
            // LoginPasswordtxt
            // 
            this.LoginPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPasswordtxt.Location = new System.Drawing.Point(93, 70);
            this.LoginPasswordtxt.Multiline = true;
            this.LoginPasswordtxt.Name = "LoginPasswordtxt";
            this.LoginPasswordtxt.Size = new System.Drawing.Size(156, 20);
            this.LoginPasswordtxt.TabIndex = 9;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(189, 95);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(126, 19);
            this.checkBoxShowPass.TabIndex = 11;
            this.checkBoxShowPass.Text = "Show password";
            this.checkBoxShowPass.UseVisualStyleBackColor = false;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.Location = new System.Drawing.Point(365, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LoginNametxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBoxShowPass);
            this.panel3.Controls.Add(this.LoginPasswordtxt);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(29, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 120);
            this.panel3.TabIndex = 13;
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.Location = new System.Drawing.Point(83, 54);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(228, 33);
            this.lblWelcomeBack.TabIndex = 14;
            this.lblWelcomeBack.Text = "Welcome back!";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(299, 322);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(386, 353);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblWelcomeBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LogInbtn);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LoginNametxt;
        private System.Windows.Forms.TextBox LoginPasswordtxt;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Button btnGoBack;
    }
}