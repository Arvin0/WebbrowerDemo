namespace IntegratedPlugin.UI
{
    partial class VteMain
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
            this.webBrowser_vteshow = new System.Windows.Forms.WebBrowser();
            this.panel_vteMain = new System.Windows.Forms.Panel();
            this.panel_vteMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser_vteshow
            // 
            this.webBrowser_vteshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_vteshow.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_vteshow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_vteshow.Name = "webBrowser_vteshow";
            this.webBrowser_vteshow.Size = new System.Drawing.Size(338, 485);
            this.webBrowser_vteshow.TabIndex = 1;
            this.webBrowser_vteshow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserDocumentCompleted);
            // 
            // panel_vteMain
            // 
            this.panel_vteMain.Controls.Add(this.webBrowser_vteshow);
            this.panel_vteMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vteMain.Location = new System.Drawing.Point(0, 0);
            this.panel_vteMain.Name = "panel_vteMain";
            this.panel_vteMain.Size = new System.Drawing.Size(338, 485);
            this.panel_vteMain.TabIndex = 2;
            // 
            // VteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 485);
            this.Controls.Add(this.panel_vteMain);
            this.Name = "VteMain";
            this.Text = "VteMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VteMainFormClosing);
            this.Load += new System.EventHandler(this.MainLoad);
            this.panel_vteMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_vteshow;
        private System.Windows.Forms.Panel panel_vteMain;
    }
}