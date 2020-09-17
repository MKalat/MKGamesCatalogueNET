namespace MK_Games_Catalogue_NET
{
    partial class Import_DB_txt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_DB_txt));
            this.label_pathtotxt = new System.Windows.Forms.Label();
            this.textBox_pathtotxt = new System.Windows.Forms.TextBox();
            this.button_SelectPath = new System.Windows.Forms.Button();
            this.progressBar_Import = new System.Windows.Forms.ProgressBar();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_pathtotxt
            // 
            resources.ApplyResources(this.label_pathtotxt, "label_pathtotxt");
            this.label_pathtotxt.Name = "label_pathtotxt";
            // 
            // textBox_pathtotxt
            // 
            resources.ApplyResources(this.textBox_pathtotxt, "textBox_pathtotxt");
            this.textBox_pathtotxt.Name = "textBox_pathtotxt";
            // 
            // button_SelectPath
            // 
            resources.ApplyResources(this.button_SelectPath, "button_SelectPath");
            this.button_SelectPath.Name = "button_SelectPath";
            this.button_SelectPath.UseVisualStyleBackColor = true;
            // 
            // progressBar_Import
            // 
            resources.ApplyResources(this.progressBar_Import, "progressBar_Import");
            this.progressBar_Import.Name = "progressBar_Import";
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Import
            // 
            resources.ApplyResources(this.button_Import, "button_Import");
            this.button_Import.Name = "button_Import";
            this.button_Import.UseVisualStyleBackColor = true;
            // 
            // Import_DB_txt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.progressBar_Import);
            this.Controls.Add(this.button_SelectPath);
            this.Controls.Add(this.textBox_pathtotxt);
            this.Controls.Add(this.label_pathtotxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import_DB_txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pathtotxt;
        private System.Windows.Forms.TextBox textBox_pathtotxt;
        private System.Windows.Forms.Button button_SelectPath;
        private System.Windows.Forms.ProgressBar progressBar_Import;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Import;
    }
}