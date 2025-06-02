using GUIHelper;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
//import to use
using System.Windows.Forms;

namespace Marshell_Updater
{
    class Form1 : GForm
    {
        // Dec by coder
        GMessage GMessage = new GMessage();

        string path = Application.ExecutablePath;
        string newversion = string.Empty;
        string filename = "update.zip";

        // Generated Dec var
        private GProgressBar gpb;
        private Label label1;
        private GButton btnDownloadUpdate;
        private System.ComponentModel.IContainer components;
        private Label lbUpdatev;

        // Init Dec of vars
        private readonly string versionlink = "https://www.dropbox.com/s/kpppi3x19tls1dn/version.txt?dl=1";
        private GButton gButton1;
        private readonly string updatelink = "https://www.dropbox.com/s/5qfbg7u20he7gv5/update.zip?dl=1"; //https://www.dropbox.com/s/5qfbg7u20he7gv5/update.zip?dl=1

        #region "UI DESIGN"
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpb = new GUIHelper.GProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadUpdate = new GUIHelper.GButton(this.components);
            this.lbUpdatev = new System.Windows.Forms.Label();
            this.gButton1 = new GUIHelper.GButton(this.components);
            this.SuspendLayout();
            // 
            // gpb
            // 
            this.gpb.BackColor = System.Drawing.Color.Transparent;
            this.gpb.Location = new System.Drawing.Point(32, 219);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(823, 35);
            this.gpb.TabIndex = 1;
            this.gpb.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marshell\'s Update Checker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownloadUpdate
            // 
            this.btnDownloadUpdate.Enabled = false;
            this.btnDownloadUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDownloadUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDownloadUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadUpdate.Location = new System.Drawing.Point(359, 129);
            this.btnDownloadUpdate.Name = "btnDownloadUpdate";
            this.btnDownloadUpdate.Size = new System.Drawing.Size(193, 55);
            this.btnDownloadUpdate.TabIndex = 3;
            this.btnDownloadUpdate.Text = "Download Update now";
            this.btnDownloadUpdate.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnDownloadUpdate.UseVisualStyleBackColor = true;
            this.btnDownloadUpdate.Click += new System.EventHandler(this.btnDownloadUpdate_Click);
            // 
            // lbUpdatev
            // 
            this.lbUpdatev.AutoSize = true;
            this.lbUpdatev.Location = new System.Drawing.Point(648, 150);
            this.lbUpdatev.Name = "lbUpdatev";
            this.lbUpdatev.Size = new System.Drawing.Size(0, 13);
            this.lbUpdatev.TabIndex = 4;
            // 
            // gButton1
            // 
            this.gButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gButton1.BackColor = System.Drawing.Color.Red;
            this.gButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.gButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gButton1.Location = new System.Drawing.Point(852, 2);
            this.gButton1.Name = "gButton1";
            this.gButton1.Size = new System.Drawing.Size(35, 35);
            this.gButton1.TabIndex = 5;
            this.gButton1.Text = "X";
            this.gButton1.UIStyle = GUIHelper.GButton.Style.Cicle;
            this.gButton1.UseVisualStyleBackColor = false;
            this.gButton1.Click += new System.EventHandler(this.gButton1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(890, 270);
            this.ControlBox = false;
            this.Controls.Add(this.gButton1);
            this.Controls.Add(this.lbUpdatev);
            this.Controls.Add(this.btnDownloadUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(890, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(890, 270);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marshell\'s Upada Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            GetVersion();
        }
        //
        // Get version from dropbox
        // sheivon.gamboa@gmail.com
        // kilabone15
        //
        // version.txt link https://www.dropbox.com/s/kpppi3x19tls1dn/version.txt?dl=0 change 0 to 1 to download and view
        private void GetVersion()
        {

            newversion = "1.0.0.2";

            //update checking if version update available
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(versionlink);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream());

            //string upver = sr.ReadToEnd();
            string appver = Application.ProductVersion;

            WebClient wc = new WebClient();
            if (wc.DownloadString(new Uri(versionlink)).Contains(newversion))
            {
                btnDownloadUpdate.Enabled = true; lbUpdatev.Text = string.Format("Available Version : {0} {1} Current Version : {2}", newversion, Environment.NewLine, Application.ProductVersion);
            }

        }

        private void btnDownloadUpdate_Click(object sender, EventArgs e)
        {
            gpb.Enabled = true;
            gpb.Visible = true;

            //download
            Thread td = new Thread(new ThreadStart(DownloadUpdate));
            td.Start();
            td.Join();

        }
        private void stopgpb()
        {
            gpb.Enabled = false;
            gpb.Visible = false;
        }
        private void DownloadUpdate()
        {
            try
            {

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new Uri(updatelink), filename);

                    while (!wc.IsBusy)
                        ZipFile.ExtractToDirectory(filename, path + @"\update");
                    foreach (string file in Directory.GetFiles(path + @"\Update\", "*.*"))
                    {
                        File.Move(@file, path);
                    }

                    File.Delete(path + filename);
                }

            }
#if DEUBUG
            catch
            { }
#else
            catch (Exception ex)
            {
                GMessage.Show(ex.Message);
            }
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}