namespace WebbrowerDemo
{
    partial class VteDetailsForm
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
            this.panel_details = new System.Windows.Forms.Panel();
            this.webBrowser_detials = new System.Windows.Forms.WebBrowser();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.webBrowser_detials);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(800, 450);
            this.panel_details.TabIndex = 0;
            // 
            // webBrowser_detials
            // 
            this.webBrowser_detials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_detials.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_detials.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_detials.Name = "webBrowser_detials";
            this.webBrowser_detials.Size = new System.Drawing.Size(800, 450);
            this.webBrowser_detials.TabIndex = 0;
            // 
            // VteDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_details);
            this.Name = "VteDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VteDetails";
            this.Load += new System.EventHandler(this.VteDetailsLoad);
            this.panel_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.WebBrowser webBrowser_detials;
    }
}