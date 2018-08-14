namespace WebbrowerDemo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aicheck = new System.Windows.Forms.Button();
            this.rtBox_aishow = new System.Windows.Forms.RichTextBox();
            this.panel_ai = new System.Windows.Forms.Panel();
            this.pane_vteMain = new System.Windows.Forms.Panel();
            this.webBrowser_vteshow = new System.Windows.Forms.WebBrowser();
            this.panel_ai.SuspendLayout();
            this.pane_vteMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aicheck
            // 
            this.btn_aicheck.Location = new System.Drawing.Point(97, 21);
            this.btn_aicheck.Name = "btn_aicheck";
            this.btn_aicheck.Size = new System.Drawing.Size(115, 44);
            this.btn_aicheck.TabIndex = 0;
            this.btn_aicheck.Text = "AI检测";
            this.btn_aicheck.UseVisualStyleBackColor = true;
            this.btn_aicheck.Click += new System.EventHandler(this.AiCheckClick);
            // 
            // rtBox_aishow
            // 
            this.rtBox_aishow.Location = new System.Drawing.Point(0, 84);
            this.rtBox_aishow.Name = "rtBox_aishow";
            this.rtBox_aishow.Size = new System.Drawing.Size(314, 354);
            this.rtBox_aishow.TabIndex = 1;
            this.rtBox_aishow.Text = "";
            // 
            // panel_ai
            // 
            this.panel_ai.Controls.Add(this.btn_aicheck);
            this.panel_ai.Controls.Add(this.rtBox_aishow);
            this.panel_ai.Location = new System.Drawing.Point(22, 36);
            this.panel_ai.Name = "panel_ai";
            this.panel_ai.Size = new System.Drawing.Size(317, 441);
            this.panel_ai.TabIndex = 2;
            // 
            // pane_vteMain
            // 
            this.pane_vteMain.Controls.Add(this.webBrowser_vteshow);
            this.pane_vteMain.Location = new System.Drawing.Point(355, 36);
            this.pane_vteMain.Name = "pane_vteMain";
            this.pane_vteMain.Size = new System.Drawing.Size(420, 441);
            this.pane_vteMain.TabIndex = 3;
            // 
            // webBrowser_vteshow
            // 
            this.webBrowser_vteshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_vteshow.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_vteshow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_vteshow.Name = "webBrowser_vteshow";
            this.webBrowser_vteshow.Size = new System.Drawing.Size(420, 441);
            this.webBrowser_vteshow.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 489);
            this.Controls.Add(this.pane_vteMain);
            this.Controls.Add(this.panel_ai);
            this.Name = "Main";
            this.Text = "主页面";
            this.Load += new System.EventHandler(this.MainLoad);
            this.panel_ai.ResumeLayout(false);
            this.pane_vteMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aicheck;
        private System.Windows.Forms.RichTextBox rtBox_aishow;
        private System.Windows.Forms.Panel panel_ai;
        private System.Windows.Forms.Panel pane_vteMain;
        private System.Windows.Forms.WebBrowser webBrowser_vteshow;
    }
}

