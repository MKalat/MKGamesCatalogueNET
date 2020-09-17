namespace MK_Games_Catalogue_NET
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.checkBox_AUset = new System.Windows.Forms.CheckBox();
            this.label_AUFreq = new System.Windows.Forms.Label();
            this.comboBox_AUFreq = new System.Windows.Forms.ComboBox();
            this.checkBox_SaveBExit = new System.Windows.Forms.CheckBox();
            this.checkBox_AskOnClose = new System.Windows.Forms.CheckBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_AUset
            // 
            this.checkBox_AUset.AccessibleDescription = null;
            this.checkBox_AUset.AccessibleName = null;
            resources.ApplyResources(this.checkBox_AUset, "checkBox_AUset");
            this.checkBox_AUset.BackgroundImage = null;
            this.checkBox_AUset.Font = null;
            this.checkBox_AUset.Name = "checkBox_AUset";
            this.checkBox_AUset.UseVisualStyleBackColor = true;
            // 
            // label_AUFreq
            // 
            this.label_AUFreq.AccessibleDescription = null;
            this.label_AUFreq.AccessibleName = null;
            resources.ApplyResources(this.label_AUFreq, "label_AUFreq");
            this.label_AUFreq.Font = null;
            this.label_AUFreq.Name = "label_AUFreq";
            // 
            // comboBox_AUFreq
            // 
            this.comboBox_AUFreq.AccessibleDescription = null;
            this.comboBox_AUFreq.AccessibleName = null;
            resources.ApplyResources(this.comboBox_AUFreq, "comboBox_AUFreq");
            this.comboBox_AUFreq.BackgroundImage = null;
            this.comboBox_AUFreq.Font = null;
            this.comboBox_AUFreq.FormattingEnabled = true;
            this.comboBox_AUFreq.Items.AddRange(new object[] {
            resources.GetString("comboBox_AUFreq.Items"),
            resources.GetString("comboBox_AUFreq.Items1"),
            resources.GetString("comboBox_AUFreq.Items2"),
            resources.GetString("comboBox_AUFreq.Items3")});
            this.comboBox_AUFreq.Name = "comboBox_AUFreq";
            // 
            // checkBox_SaveBExit
            // 
            this.checkBox_SaveBExit.AccessibleDescription = null;
            this.checkBox_SaveBExit.AccessibleName = null;
            resources.ApplyResources(this.checkBox_SaveBExit, "checkBox_SaveBExit");
            this.checkBox_SaveBExit.BackgroundImage = null;
            this.checkBox_SaveBExit.Font = null;
            this.checkBox_SaveBExit.Name = "checkBox_SaveBExit";
            this.checkBox_SaveBExit.UseVisualStyleBackColor = true;
            // 
            // checkBox_AskOnClose
            // 
            this.checkBox_AskOnClose.AccessibleDescription = null;
            this.checkBox_AskOnClose.AccessibleName = null;
            resources.ApplyResources(this.checkBox_AskOnClose, "checkBox_AskOnClose");
            this.checkBox_AskOnClose.BackgroundImage = null;
            this.checkBox_AskOnClose.Font = null;
            this.checkBox_AskOnClose.Name = "checkBox_AskOnClose";
            this.checkBox_AskOnClose.UseVisualStyleBackColor = true;
            // 
            // label_Language
            // 
            this.label_Language.AccessibleDescription = null;
            this.label_Language.AccessibleName = null;
            resources.ApplyResources(this.label_Language, "label_Language");
            this.label_Language.Font = null;
            this.label_Language.Name = "label_Language";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.AccessibleDescription = null;
            this.comboBox_Language.AccessibleName = null;
            resources.ApplyResources(this.comboBox_Language, "comboBox_Language");
            this.comboBox_Language.BackgroundImage = null;
            this.comboBox_Language.Font = null;
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            resources.GetString("comboBox_Language.Items"),
            resources.GetString("comboBox_Language.Items1")});
            this.comboBox_Language.Name = "comboBox_Language";
            // 
            // button_Save
            // 
            this.button_Save.AccessibleDescription = null;
            this.button_Save.AccessibleName = null;
            resources.ApplyResources(this.button_Save, "button_Save");
            this.button_Save.BackgroundImage = null;
            this.button_Save.Font = null;
            this.button_Save.Name = "button_Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AccessibleDescription = null;
            this.button_Cancel.AccessibleName = null;
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.BackgroundImage = null;
            this.button_Cancel.Font = null;
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Settings
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.label_Language);
            this.Controls.Add(this.checkBox_AskOnClose);
            this.Controls.Add(this.checkBox_SaveBExit);
            this.Controls.Add(this.comboBox_AUFreq);
            this.Controls.Add(this.label_AUFreq);
            this.Controls.Add(this.checkBox_AUset);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_AUset;
        private System.Windows.Forms.Label label_AUFreq;
        private System.Windows.Forms.ComboBox comboBox_AUFreq;
        private System.Windows.Forms.CheckBox checkBox_SaveBExit;
        private System.Windows.Forms.CheckBox checkBox_AskOnClose;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}