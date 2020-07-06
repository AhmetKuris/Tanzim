namespace Tanzim.WindowsFormsUI
{
    partial class LoginPage
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
            this.programNameLbl = new System.Windows.Forms.Label();
            this.userMailLbl = new System.Windows.Forms.Label();
            this.userPasswordLbl = new System.Windows.Forms.Label();
            this.userMailTxtbx = new System.Windows.Forms.TextBox();
            this.userPasswordTxtbx = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.singUpBtn = new System.Windows.Forms.Button();
            this.showPasswordChcbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // programNameLbl
            // 
            this.programNameLbl.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLbl.Location = new System.Drawing.Point(113, 38);
            this.programNameLbl.Name = "programNameLbl";
            this.programNameLbl.Size = new System.Drawing.Size(150, 52);
            this.programNameLbl.TabIndex = 0;
            this.programNameLbl.Text = "Tanzim ";
            this.programNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userMailLbl
            // 
            this.userMailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMailLbl.Location = new System.Drawing.Point(41, 103);
            this.userMailLbl.Name = "userMailLbl";
            this.userMailLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userMailLbl.Size = new System.Drawing.Size(100, 23);
            this.userMailLbl.TabIndex = 1;
            this.userMailLbl.Text = "Mail: ";
            this.userMailLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userPasswordLbl
            // 
            this.userPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLbl.Location = new System.Drawing.Point(41, 157);
            this.userPasswordLbl.Name = "userPasswordLbl";
            this.userPasswordLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userPasswordLbl.Size = new System.Drawing.Size(100, 23);
            this.userPasswordLbl.TabIndex = 2;
            this.userPasswordLbl.Text = "Password: ";
            this.userPasswordLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userMailTxtbx
            // 
            this.userMailTxtbx.Location = new System.Drawing.Point(152, 106);
            this.userMailTxtbx.Name = "userMailTxtbx";
            this.userMailTxtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userMailTxtbx.Size = new System.Drawing.Size(135, 20);
            this.userMailTxtbx.TabIndex = 3;
            // 
            // userPasswordTxtbx
            // 
            this.userPasswordTxtbx.Location = new System.Drawing.Point(152, 160);
            this.userPasswordTxtbx.Name = "userPasswordTxtbx";
            this.userPasswordTxtbx.PasswordChar = '*';
            this.userPasswordTxtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userPasswordTxtbx.Size = new System.Drawing.Size(135, 20);
            this.userPasswordTxtbx.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(45, 247);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(245, 45);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login ";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // singUpBtn
            // 
            this.singUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.singUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singUpBtn.Location = new System.Drawing.Point(48, 313);
            this.singUpBtn.Name = "singUpBtn";
            this.singUpBtn.Size = new System.Drawing.Size(242, 45);
            this.singUpBtn.TabIndex = 7;
            this.singUpBtn.Text = "Register";
            this.singUpBtn.UseVisualStyleBackColor = false;
            this.singUpBtn.Click += new System.EventHandler(this.singUpBtn_Click);
            // 
            // showPasswordChcbx
            // 
            this.showPasswordChcbx.AutoSize = true;
            this.showPasswordChcbx.Location = new System.Drawing.Point(152, 197);
            this.showPasswordChcbx.Name = "showPasswordChcbx";
            this.showPasswordChcbx.Size = new System.Drawing.Size(101, 17);
            this.showPasswordChcbx.TabIndex = 8;
            this.showPasswordChcbx.Text = "Show password";
            this.showPasswordChcbx.UseVisualStyleBackColor = true;
            this.showPasswordChcbx.CheckedChanged += new System.EventHandler(this.showPasswordChcbx_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(364, 411);
            this.Controls.Add(this.showPasswordChcbx);
            this.Controls.Add(this.singUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPasswordTxtbx);
            this.Controls.Add(this.userMailTxtbx);
            this.Controls.Add(this.userPasswordLbl);
            this.Controls.Add(this.userMailLbl);
            this.Controls.Add(this.programNameLbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 450);
            this.MinimumSize = new System.Drawing.Size(380, 450);
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanzim";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameLbl;
        private System.Windows.Forms.Label userMailLbl;
        private System.Windows.Forms.Label userPasswordLbl;
        private System.Windows.Forms.TextBox userMailTxtbx;
        private System.Windows.Forms.TextBox userPasswordTxtbx;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button singUpBtn;
        private System.Windows.Forms.CheckBox showPasswordChcbx;
    }
}

