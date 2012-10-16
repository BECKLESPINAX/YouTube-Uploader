using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YT_Uploader
{
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
            videoLinks.Text = "https://www.youtube.com/watch?v=" + Link.VideoID + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            videoLinks.AppendText(@"http://www.polsy.org.uk/play/yt/?vurl=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3D" + Link.VideoID);
        }
        
    }

    public static class Link
    {
        public static string VideoID { get; set; }
    }
}
