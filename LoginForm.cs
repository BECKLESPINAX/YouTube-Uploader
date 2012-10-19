using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.YouTube;
using Google.GData.YouTube;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Extensions.MediaRss;

namespace YT_Uploader
{
    public partial class LoginForm : Form
    {
        bool loginFlag = false;
        bool passwordFlag = false;

        public LoginForm()
        {
            InitializeComponent();
            textLogin.Text = Youtube_Uploader.Properties.Settings.Default.UsernameYT;
            textPassword.Text = Youtube_Uploader.Properties.Settings.Default.PasswordYT;
        }

        private void CheckEnter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                loginDone_Click(sender, e); 
                e.Handled = true; //Suppress beeping.
            }
            
        }

        private void loginDone_Click(object sender, EventArgs e)
        {
            
            String key = @"AI39si5BLf_EKytNzPVPtepg-yNDLPSxKOP9ZCBaDTErR5nWmFMy36d8jnKOfwU3PN0c61au0l6b68k9lk7GRluBKh7lvlNRzA"; //My personal API key.

            YouTubeService service = new YouTubeService("YouTube Synchronizer");
            service.setUserCredentials(textLogin.Text, textPassword.Text);
            //textbox1 contains username and maskedTextBox1 contains password
            try
            {
                service.QueryClientLoginToken();
                this.Hide();
            }
            catch (InvalidCredentialsException j) { loginTxt_lbl.Visible = true; }

            YouTubeRequestSettings settings = new YouTubeRequestSettings("Deprecated", key, textLogin.Text, textPassword.Text);
            Youtube_Uploader.Properties.Settings.Default.UsernameYT = textLogin.Text;
            Youtube_Uploader.Properties.Settings.Default.PasswordYT = textPassword.Text;
            Youtube_Uploader.Properties.Settings.Default.Save();
            MainForm.request = new YouTubeRequest(settings);
            
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {
            MainForm.login = textLogin.Text;
            loginFlag = (string.IsNullOrEmpty(textLogin.Text)) ? false : true;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            MainForm.password = textPassword.Text;
            passwordFlag = (string.IsNullOrEmpty(textPassword.Text)) ? false : true;
        }

        private void LoginCancel_Click(object sender, EventArgs e)
        {
            MainForm.retryLogin = false;
            this.Hide();
        }
    }
}
