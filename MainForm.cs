using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using Google.YouTube;
using Google.GData.YouTube;
using Google.GData.Client;
using Google.GData.Client.ResumableUpload;
using Google.GData.Extensions;
using Google.GData.Extensions.MediaRss;
using System.Configuration;

namespace YT_Uploader
{
    

    public partial class MainForm : Form
    {
        String key = @"AI39si5BLf_EKytNzPVPtepg-yNDLPSxKOP9ZCBaDTErR5nWmFMy36d8jnKOfwU3PN0c61au0l6b68k9lk7GRluBKh7lvlNRzA"; //My personal API key.

        public static bool vidFlag;
        public static bool loginFlag;

        //Login form
        public static string login;
        public static string password;
        public static YouTubeRequestSettings settings;
        public static YouTubeRequest request;
        public static bool retryLogin = true;


        //Link form
        public static string VideoID;

        //Main form
        Video newVideo;

        StringCollection VideoFilename = new StringCollection();
        StringCollection VideoId = new StringCollection();
        StringCollection VideoStatus = new StringCollection();

        DirectoryInfo Di;
        string stored_IncludeFolder = Youtube_Uploader.Properties.Settings.Default.IncludeFolder;

        //string wth; FIXED -- Issue with object scope? Will fix later. This is a workaround.

        public MainForm()
        {
            InitializeComponent();
            buttonUpload.Enabled = false; //Disable buttons by default.
            textComplete.Visible = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            
            comboCategory.SelectedIndex = 7; //No selection is invalid. 
            vidFlag = false;            //User must provide credentials and a video before uploading.
            loginFlag = false;

            //Saved settings
            folderBrowserDialog.SelectedPath = stored_IncludeFolder;
            includeTextBox.Text = stored_IncludeFolder;
            VideoWatcher.Path = stored_IncludeFolder;
            
            VideoFilename = Youtube_Uploader.Properties.Settings.Default.FilesLib;
            VideoId = Youtube_Uploader.Properties.Settings.Default.IdLib;
            VideoStatus = Youtube_Uploader.Properties.Settings.Default.StatusLib;
            
            YouTubeRequestSettings settings = new YouTubeRequestSettings("Deprecated", key, Youtube_Uploader.Properties.Settings.Default.UsernameYT, Youtube_Uploader.Properties.Settings.Default.PasswordYT);
            request = new YouTubeRequest(settings);  
            
            drawVideoList();
        }

       
        
        private void scanVideo_Click(object sender, EventArgs e)
        {
            scanVideoList();
        }

     

        private void videoUpload_Click(object sender, EventArgs e)
        {
            textComplete.Visible = false; //Clear 'complete' text on new upload.
            newVideo = new Video();
            string fullFilename = includeTextBox.Text + "\\" + listVideosView.FocusedItem.Text;
            newVideo.Title = Title.Text;
            newVideo.Tags.Add(new MediaCategory(comboCategory.Text, YouTubeNameTable.CategorySchema));
            newVideo.Description = Description.Text;
            newVideo.YouTubeEntry.MediaSource = new MediaFileSource(fullFilename, "video/x-ms-wmv"); 
            if (checkAuth.Checked) newVideo.YouTubeEntry.Private = true;
            else newVideo.YouTubeEntry.Private = false;

            ((GDataRequestFactory)request.Service.RequestFactory).KeepAlive = true;
            ((GDataRequestFactory)request.Service.RequestFactory).Timeout = 9999999;
            request.Service.AsyncOperationProgress += new AsyncOperationProgressEventHandler(Service_AsyncOperationProgress);
            request.Service.AsyncOperationCompleted += new AsyncOperationCompletedEventHandler(Service_AsyncOperationCompleted);
            request.Service.InsertAsync(new Uri("http://uploads.gdata.youtube.com/feeds/api/users/default/uploads"),
                                                 newVideo.AtomEntry, newVideo);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            loginFlag = true;
            buttonUpload.Enabled = (vidFlag && loginFlag) ? true : false;
        }

        private void buttonLinks_Click(object sender, EventArgs e)
        {
            LinkForm HTMLForm = new LinkForm();
            HTMLForm.ShowDialog();
        }

        /*
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        TryLoginLabel:              //Ask user to re-submit invalid credentials until success or cancel.
            if (retryLogin)
            {
                try
                {   ///*
                    ((GDataRequestFactory)request.Service.RequestFactory).KeepAlive = true;
                    ((GDataRequestFactory)request.Service.RequestFactory).Timeout = 9999999;
                    Task.Factory.StartNew(() => { backgroundWorker1.ReportProgress(1); });
                    newVideo = request.Upload(newVideo);
                    //
                }

                catch (InvalidCredentialsException c)
                {
                    Console.WriteLine(c);
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.ShowDialog();

                    goto TryLoginLabel;
                }
                catch (AccountDisabledException c)
                {
                    Console.WriteLine(c);
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.ShowDialog();

                    goto TryLoginLabel;
                }
            }
            
        } */ //Kept for reference.

        void Service_AsyncOperationCompleted(object sender, AsyncOperationCompletedEventArgs e)
        {
            request.Service.AsyncOperationCompleted -= new AsyncOperationCompletedEventHandler(Service_AsyncOperationCompleted); //Event is firing twice. Fix later.
            debugBox.Text = "100";
            newVideo.VideoId = ((Google.GData.YouTube.YouTubeEntry)(e.Entry)).VideoId;
            if (!String.IsNullOrEmpty(newVideo.VideoId)  ) //Got a valid URL back.
            {
                VideoID = newVideo.VideoId;
                
                textComplete.Visible = true;
                buttonUpload.Enabled = false;
                
                Youtube_Uploader.Properties.Settings.Default.IdLib.Add(VideoID);
                Youtube_Uploader.Properties.Settings.Default.StatusLib.Add("Complete");
                Youtube_Uploader.Properties.Settings.Default.FilesLib.Add(listVideosView.FocusedItem.Text);
                Youtube_Uploader.Properties.Settings.Default.Save();

                drawVideoList();
            }
        }

        void Service_AsyncOperationProgress(object sender, AsyncOperationProgressEventArgs e)
        {
            //Console.WriteLine(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
            debugBox.Text = e.ProgressPercentage.ToString();
        }

       
        private void includeFolder_btnClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            includeTextBox.Text = folderBrowserDialog.SelectedPath; //Provide feedback to the user on their selection.
            VideoWatcher.Path = folderBrowserDialog.SelectedPath; 
            Youtube_Uploader.Properties.Settings.Default.IncludeFolder = includeTextBox.Text;
            Youtube_Uploader.Properties.Settings.Default.Save();
            drawVideoList();
        }

        private void VideoWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            
            drawVideoList();

        }
        private void VideoWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            drawVideoList();
            
        }
        private void VideoWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            drawVideoList(); 
            
        }
        private void VideoWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            drawVideoList();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                ListViewItem Video = (ListViewItem)e.Argument;
                for (int i = 0; i < Youtube_Uploader.Properties.Settings.Default.IdLib.Count; i++)
                {
                    if (ConfirmID(VideoId[i]))
                    {
                        Video.SubItems.Add("Completed");
                        Video.SubItems.Add(VideoId[i]);
                    }
                }
            }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void scanVideoList()
        {
            int count = Youtube_Uploader.Properties.Settings.Default.IdLib.Count;
            Di = new DirectoryInfo(includeTextBox.Text);
            listVideosView.Items.Clear();
            foreach (FileInfo name in Di.GetFiles())
            {
                ListViewItem Video = new ListViewItem(name.Name); //Add an entry for each file in the sync directory
                listVideosView.Items.Add(Video);
                for (int i = 0; i < count; i++) //Look to see if videos in the sync directory have an uploaded entry.
                {                               //FIXME: See about improving this later. Looks messy.
                    if (VideoFilename[i] == name.Name)
                    {
                        if (ConfirmID(VideoId[i]))
                        {
                            //Name = "processing"
                            if (newVideo.Status == null) { Video.SubItems.Add("Completed"); }
                            else if (newVideo.Status.Name == "processing") { Video.SubItems.Add("Procesing"); }
                            else Video.SubItems.Add(newVideo.Status.Value);
                            Video.SubItems.Add(VideoId[i]);
                            Youtube_Uploader.Properties.Settings.Default.FilesLib[i] = VideoFilename[i];
                            Youtube_Uploader.Properties.Settings.Default.StatusLib[i] = Video.SubItems[1].Text;
                            Youtube_Uploader.Properties.Settings.Default.IdLib[i] = VideoId[i];

                        }
                    }
                }

            }


            Youtube_Uploader.Properties.Settings.Default.Save();
        }

        private void drawVideoList()
        {
            int count = Youtube_Uploader.Properties.Settings.Default.IdLib.Count;
            Di = new DirectoryInfo(includeTextBox.Text);
            listVideosView.Items.Clear();

            foreach (FileInfo name in Di.GetFiles())
            {
                ListViewItem Video = new ListViewItem(name.Name); //Add an entry for each file in the sync directory
                listVideosView.Items.Add(Video); 
                if (VideoFilename.Contains(name.Name))
                {
                    Video.SubItems.Add(VideoStatus[VideoFilename.IndexOf(name.Name)]); //Naievely assume existing videos are complete for now.
                    Video.SubItems.Add(VideoId[VideoFilename.IndexOf(name.Name)]);
                }
            }
        }


        private void includeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                includeTextBox.Text = ((System.Windows.Forms.TextBox)(sender)).Text; //Provide feedback to the user on their selection.
                VideoWatcher.Path = ((System.Windows.Forms.TextBox)(sender)).Text;
                Youtube_Uploader.Properties.Settings.Default.IncludeFolder = includeTextBox.Text;
                Youtube_Uploader.Properties.Settings.Default.Save();
                drawVideoList();
                e.Handled = true; //Suppress beeping.
            }
        }

        private void listVideosView_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_UploadFile.Text = ((ListView)(sender)).FocusedItem.Text;
            if (((ListView)(sender)).FocusedItem.SubItems.Count > 1) //Don't let user look at links for videos with no ID.
            {
                Link.VideoID = ((ListView)(sender)).FocusedItem.SubItems[2].Text;
                buttonLinks.Enabled = true;
                buttonUpload.Enabled = false;
            }
            else
            {
                buttonLinks.Enabled = false;
                buttonUpload.Enabled = true;
            }
            textComplete.Visible = false; //Clear 'complete' text when user changes a selection.
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("WARNING: This will clear ALL entries!", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            Youtube_Uploader.Properties.Settings.Default.FilesLib.Clear();
            Youtube_Uploader.Properties.Settings.Default.StatusLib.Clear();
            Youtube_Uploader.Properties.Settings.Default.IdLib.Clear();
            Youtube_Uploader.Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Stub
        }

        private bool ConfirmID(string vidID)
        {
            YouTubeRequestSettings settings = new YouTubeRequestSettings("Deprecated", key, Youtube_Uploader.Properties.Settings.Default.UsernameYT, Youtube_Uploader.Properties.Settings.Default.PasswordYT);
            YouTubeRequest request = new YouTubeRequest(settings);
            //Uri videoEntryUrl = new Uri(String.Format("http://gdata.youtube.com/feeds/api/users/{0}/uploads/{1}", "user00015", vidID));
            string VideoEntryUrl = @"http://gdata.youtube.com/feeds/api/videos/";
            Uri videoEntryUrl = new Uri(VideoEntryUrl + vidID);
            try
            {
                newVideo = request.Retrieve<Video>(videoEntryUrl); //Make this Async eventually if possible.
                return true;
            }
            catch { return false; }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           //Add later
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("WARNING: Deleting this file will delete it locally!", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes && listVideosView.FocusedItem.SubItems.Count > 1)
            {
                YouTubeRequestSettings settings = new YouTubeRequestSettings("Deprecated", key, Youtube_Uploader.Properties.Settings.Default.UsernameYT, Youtube_Uploader.Properties.Settings.Default.PasswordYT);
                YouTubeRequest request = new YouTubeRequest(settings);
                Uri videoEntryUrl = new Uri(String.Format("http://gdata.youtube.com/feeds/api/users/{0}/uploads/{1}", TrimEmail(Youtube_Uploader.Properties.Settings.Default.UsernameYT), listVideosView.FocusedItem.SubItems[2].Text));
                Video video = request.Retrieve<Video>(videoEntryUrl);
                request.Delete(video);
                
                Youtube_Uploader.Properties.Settings.Default.StatusLib.RemoveAt(VideoId.IndexOf(video.VideoId));
                Youtube_Uploader.Properties.Settings.Default.FilesLib.RemoveAt(VideoId.IndexOf(video.VideoId));
                Youtube_Uploader.Properties.Settings.Default.IdLib.RemoveAt(VideoId.IndexOf(video.VideoId));
                Youtube_Uploader.Properties.Settings.Default.Save();

                File.Delete(includeTextBox.Text + "\\" + textBox_UploadFile.Text);

                drawVideoList();
            }

            
        }

        private string TrimEmail(string s)
        {
            bool tf = s.Contains("@");
            if (tf) return s.Substring(0, s.IndexOf("@"));
            else return s;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          Form form = new Form();
          Label label = new Label();
          TextBox textBox = new TextBox();
          Button buttonOk = new Button();
          Button buttonCancel = new Button();

          form.Text = "Enter video ID";
          label.Text = "Video ID";
            
          buttonOk.Text = "OK";
          buttonCancel.Text = "Cancel";
          buttonOk.DialogResult = DialogResult.OK;
          buttonCancel.DialogResult = DialogResult.Cancel;

          label.SetBounds(9, 20, 372, 13);
          textBox.SetBounds(12, 36, 372, 20);
          buttonOk.SetBounds(228, 72, 75, 23);
          buttonCancel.SetBounds(309, 72, 75, 23);
          label.AutoSize = true;
          textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
          buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
          buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

          form.ClientSize = new Size(396, 107);
          form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
          form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
          form.FormBorderStyle = FormBorderStyle.FixedDialog;
          form.StartPosition = FormStartPosition.CenterScreen;
          form.MinimizeBox = false;
          form.MaximizeBox = false;
          form.AcceptButton = buttonOk;
          form.CancelButton = buttonCancel;

          DialogResult dialogResult = form.ShowDialog();
          string value = textBox.Text;

          if (form.DialogResult == DialogResult.OK ) 
          {
              int i = listVideosView.FocusedItem.Index;
              
              //if (value.Contains("?v=")) listVideosView.FocusedItem.SubItems.Add(value.Substring(value.LastIndexOf("?v=") + 3));
              //else listVideosView.FocusedItem.SubItems.Add(value);

              if (value.Contains("?v="))
              {
                  VideoFilename.Add(listVideosView.FocusedItem.Text);
                  VideoStatus.Add("Completed");
                  VideoId.Add(value.Substring(value.LastIndexOf("?v=") + 3));
              }
              else
              {
                  VideoFilename.Add(listVideosView.FocusedItem.Text);
                  VideoStatus.Add("Completed");
                  VideoId.Add(value);
              }
          }

          drawVideoList();
        }
       
    }
}
