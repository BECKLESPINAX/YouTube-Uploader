namespace YT_Uploader
{
    partial class MainForm
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
            this.openVideo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBox_UploadFile = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textComplete = new System.Windows.Forms.TextBox();
            this.buttonLinks = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.debugBox = new System.Windows.Forms.TextBox();
            this.includeTextBox = new System.Windows.Forms.TextBox();
            this.includeFolder_btn = new System.Windows.Forms.Button();
            this.VideoWatcher = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listVideosView = new System.Windows.Forms.ListView();
            this.Video = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.DoIt = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // openVideo
            // 
            this.openVideo.Location = new System.Drawing.Point(831, 479);
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(75, 23);
            this.openVideo.TabIndex = 0;
            this.openVideo.Text = "Scan";
            this.openVideo.UseVisualStyleBackColor = true;
            this.openVideo.Click += new System.EventHandler(this.scanVideo_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(253, 372);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(170, 43);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.videoUpload_Click);
            // 
            // textBox_UploadFile
            // 
            this.textBox_UploadFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_UploadFile.Location = new System.Drawing.Point(171, 75);
            this.textBox_UploadFile.Name = "textBox_UploadFile";
            this.textBox_UploadFile.ReadOnly = true;
            this.textBox_UploadFile.Size = new System.Drawing.Size(450, 20);
            this.textBox_UploadFile.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(101, 159);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(101, 185);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Category:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(100, 211);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description:";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(100, 268);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(43, 13);
            this.labelAuth.TabIndex = 6;
            this.labelAuth.Text = "Private:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(171, 159);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 7;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(171, 211);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(327, 51);
            this.Description.TabIndex = 9;
            // 
            // checkAuth
            // 
            this.checkAuth.AutoSize = true;
            this.checkAuth.Location = new System.Drawing.Point(171, 268);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(15, 14);
            this.checkAuth.TabIndex = 10;
            this.checkAuth.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(546, 391);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textComplete
            // 
            this.textComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplete.Location = new System.Drawing.Point(171, 316);
            this.textComplete.Name = "textComplete";
            this.textComplete.ReadOnly = true;
            this.textComplete.Size = new System.Drawing.Size(327, 42);
            this.textComplete.TabIndex = 12;
            this.textComplete.Text = "Upload Complete";
            this.textComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLinks
            // 
            this.buttonLinks.Location = new System.Drawing.Point(546, 420);
            this.buttonLinks.Name = "buttonLinks";
            this.buttonLinks.Size = new System.Drawing.Size(75, 23);
            this.buttonLinks.TabIndex = 13;
            this.buttonLinks.Text = "Links";
            this.buttonLinks.UseVisualStyleBackColor = true;
            this.buttonLinks.Click += new System.EventHandler(this.buttonLinks_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Autos",
            "Comedy",
            "Education",
            "Entertainment",
            "Film",
            "Gaming",
            "Howto",
            "Music",
            "News",
            "Nonprofits",
            "People",
            "Pets",
            "Science",
            "Sports",
            "Travel & Events"});
            this.comboCategory.Location = new System.Drawing.Point(171, 185);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 21);
            this.comboCategory.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 287);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(505, 287);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(40, 20);
            this.debugBox.TabIndex = 17;
            // 
            // includeTextBox
            // 
            this.includeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.includeTextBox.Location = new System.Drawing.Point(715, 75);
            this.includeTextBox.Name = "includeTextBox";
            this.includeTextBox.ReadOnly = true;
            this.includeTextBox.Size = new System.Drawing.Size(191, 20);
            this.includeTextBox.TabIndex = 19;
            this.includeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.includeTextBox_KeyPress);
            // 
            // includeFolder_btn
            // 
            this.includeFolder_btn.Location = new System.Drawing.Point(822, 101);
            this.includeFolder_btn.Name = "includeFolder_btn";
            this.includeFolder_btn.Size = new System.Drawing.Size(84, 23);
            this.includeFolder_btn.TabIndex = 18;
            this.includeFolder_btn.Text = "Include";
            this.includeFolder_btn.UseVisualStyleBackColor = true;
            this.includeFolder_btn.Click += new System.EventHandler(this.includeFolder_btnClick);
            // 
            // VideoWatcher
            // 
            this.VideoWatcher.EnableRaisingEvents = true;
            this.VideoWatcher.IncludeSubdirectories = true;
            this.VideoWatcher.SynchronizingObject = this;
            this.VideoWatcher.Changed += new System.IO.FileSystemEventHandler(this.VideoWatcher_Changed);
            this.VideoWatcher.Created += new System.IO.FileSystemEventHandler(this.VideoWatcher_Created);
            this.VideoWatcher.Deleted += new System.IO.FileSystemEventHandler(this.VideoWatcher_Deleted);
            this.VideoWatcher.Renamed += new System.IO.RenamedEventHandler(this.VideoWatcher_Renamed);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = global::Youtube_Uploader.Properties.Settings.Default.IncludeFolder;
            // 
            // listVideosView
            // 
            this.listVideosView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listVideosView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Video,
            this.Status,
            this.ID});
            this.listVideosView.FullRowSelect = true;
            this.listVideosView.GridLines = true;
            this.listVideosView.HideSelection = false;
            this.listVideosView.Location = new System.Drawing.Point(645, 130);
            this.listVideosView.Name = "listVideosView";
            this.listVideosView.Size = new System.Drawing.Size(261, 343);
            this.listVideosView.TabIndex = 21;
            this.listVideosView.UseCompatibleStateImageBehavior = false;
            this.listVideosView.View = System.Windows.Forms.View.Details;
            this.listVideosView.SelectedIndexChanged += new System.EventHandler(this.listVideosView_SelectedIndexChanged);
            // 
            // Video
            // 
            this.Video.Text = "Video";
            this.Video.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 71;
            // 
            // ID
            // 
            this.ID.Text = "";
            this.ID.Width = 96;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(831, 533);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // DoIt
            // 
            this.DoIt.Location = new System.Drawing.Point(645, 478);
            this.DoIt.Name = "DoIt";
            this.DoIt.Size = new System.Drawing.Size(75, 23);
            this.DoIt.TabIndex = 23;
            this.DoIt.Text = "DoItAll";
            this.DoIt.UseVisualStyleBackColor = true;
            this.DoIt.Click += new System.EventHandler(this.DoIt_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Current Selection:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoIt);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.listVideosView);
            this.Controls.Add(this.includeTextBox);
            this.Controls.Add(this.includeFolder_btn);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.buttonLinks);
            this.Controls.Add(this.textComplete);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkAuth);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBox_UploadFile);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.openVideo);
            this.Name = "MainForm";
            this.Text = "YouTube Uploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.VideoWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openVideo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBox_UploadFile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.CheckBox checkAuth;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textComplete;
        private System.Windows.Forms.Button buttonLinks;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox debugBox;
        private System.Windows.Forms.TextBox includeTextBox;
        private System.Windows.Forms.Button includeFolder_btn;
        private System.IO.FileSystemWatcher VideoWatcher;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ColumnHeader Video;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button DoIt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listVideosView;
        private System.Windows.Forms.Label label1;


    }
}

