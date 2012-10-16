namespace YT_Uploader
{
    partial class LoginForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.loginDone = new System.Windows.Forms.Button();
            this.LoginCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(25, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(28, 75);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.AcceptsReturn = true;
            this.textPassword.Location = new System.Drawing.Point(91, 75);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 2;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            this.textPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter_KeyPress);
            // 
            // textLogin
            // 
            this.textLogin.AcceptsReturn = true;
            this.textLogin.Location = new System.Drawing.Point(91, 30);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 1;
            this.textLogin.TextChanged += new System.EventHandler(this.textLogin_TextChanged);
            this.textLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter_KeyPress);
            // 
            // loginDone
            // 
            this.loginDone.Location = new System.Drawing.Point(57, 166);
            this.loginDone.Name = "loginDone";
            this.loginDone.Size = new System.Drawing.Size(75, 23);
            this.loginDone.TabIndex = 3;
            this.loginDone.Text = "Done";
            this.loginDone.UseVisualStyleBackColor = true;
            this.loginDone.Click += new System.EventHandler(this.loginDone_Click);
            // 
            // LoginCancel
            // 
            this.LoginCancel.Location = new System.Drawing.Point(139, 166);
            this.LoginCancel.Name = "LoginCancel";
            this.LoginCancel.Size = new System.Drawing.Size(75, 23);
            this.LoginCancel.TabIndex = 4;
            this.LoginCancel.Text = "Cancel";
            this.LoginCancel.UseVisualStyleBackColor = true;
            this.LoginCancel.Click += new System.EventHandler(this.LoginCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LoginCancel);
            this.Controls.Add(this.loginDone);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Button loginDone;
        private System.Windows.Forms.Button LoginCancel;
    }
}