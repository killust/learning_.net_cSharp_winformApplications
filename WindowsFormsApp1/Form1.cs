using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate(tbURL.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (asyncResult.IsCompleted)
            {
                tbResults.Text = Encoding.UTF8.GetString(fileContents); fs.Close();
            }
        }
        FileStream fs;
        byte[] fileContents; 
        AsyncCallback callback;
        private void btnReadAsync_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            callback = new AsyncCallback(fs_StateChanged);
            fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
            fileContents = new Byte[fs.Length];
            fs.BeginRead(fileContents, 0, (int)fs.Length, callback, null);
        }
    }
}
