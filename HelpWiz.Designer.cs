namespace MK_Games_Catalogue_NET
{
    partial class HelpWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWiz));
            this.webBrowser_Help = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_Help
            // 
            this.webBrowser_Help.AccessibleDescription = null;
            this.webBrowser_Help.AccessibleName = null;
            this.webBrowser_Help.AllowWebBrowserDrop = false;
            resources.ApplyResources(this.webBrowser_Help, "webBrowser_Help");
            this.webBrowser_Help.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Help.Name = "webBrowser_Help";
            this.webBrowser_Help.ScriptErrorsSuppressed = true;
            // 
            // HelpWiz
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.webBrowser_Help);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HelpWiz";
            this.Load += new System.EventHandler(this.HelpWiz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Help;
    }
}