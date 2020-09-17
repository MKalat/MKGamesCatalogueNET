namespace MK_Games_Catalogue_NET
{
    partial class Export_DB_txt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_DB_txt));
            this.label_Pathtotxt = new System.Windows.Forms.Label();
            this.textBox_pathtotxt = new System.Windows.Forms.TextBox();
            this.button_selectPath = new System.Windows.Forms.Button();
            this.progressBar_export = new System.Windows.Forms.ProgressBar();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_EksMODS = new System.Windows.Forms.CheckBox();
            this.checkBox_EksDOD = new System.Windows.Forms.CheckBox();
            this.checkBox_EksMAIN = new System.Windows.Forms.CheckBox();
            this.checkBox_EksAllDB = new System.Windows.Forms.CheckBox();
            this.graBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultDataSet = new MK_Games_Catalogue_NET.defaultDataSet();
            this.graTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter();
            this.modsTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter();
            this.dodatkiTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter();
            this.gra2MOdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gra2DodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Pathtotxt
            // 
            this.label_Pathtotxt.AccessibleDescription = null;
            this.label_Pathtotxt.AccessibleName = null;
            resources.ApplyResources(this.label_Pathtotxt, "label_Pathtotxt");
            this.label_Pathtotxt.Font = null;
            this.label_Pathtotxt.Name = "label_Pathtotxt";
            // 
            // textBox_pathtotxt
            // 
            this.textBox_pathtotxt.AccessibleDescription = null;
            this.textBox_pathtotxt.AccessibleName = null;
            resources.ApplyResources(this.textBox_pathtotxt, "textBox_pathtotxt");
            this.textBox_pathtotxt.BackgroundImage = null;
            this.textBox_pathtotxt.Font = null;
            this.textBox_pathtotxt.Name = "textBox_pathtotxt";
            // 
            // button_selectPath
            // 
            this.button_selectPath.AccessibleDescription = null;
            this.button_selectPath.AccessibleName = null;
            resources.ApplyResources(this.button_selectPath, "button_selectPath");
            this.button_selectPath.BackgroundImage = null;
            this.button_selectPath.Font = null;
            this.button_selectPath.Name = "button_selectPath";
            this.button_selectPath.UseVisualStyleBackColor = true;
            this.button_selectPath.Click += new System.EventHandler(this.button_selectPath_Click);
            // 
            // progressBar_export
            // 
            this.progressBar_export.AccessibleDescription = null;
            this.progressBar_export.AccessibleName = null;
            resources.ApplyResources(this.progressBar_export, "progressBar_export");
            this.progressBar_export.BackgroundImage = null;
            this.progressBar_export.Font = null;
            this.progressBar_export.Name = "progressBar_export";
            // 
            // button_Export
            // 
            this.button_Export.AccessibleDescription = null;
            this.button_Export.AccessibleName = null;
            resources.ApplyResources(this.button_Export, "button_Export");
            this.button_Export.BackgroundImage = null;
            this.button_Export.Name = "button_Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
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
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.checkBox_EksMODS);
            this.groupBox1.Controls.Add(this.checkBox_EksDOD);
            this.groupBox1.Controls.Add(this.checkBox_EksMAIN);
            this.groupBox1.Controls.Add(this.checkBox_EksAllDB);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_EksMODS
            // 
            this.checkBox_EksMODS.AccessibleDescription = null;
            this.checkBox_EksMODS.AccessibleName = null;
            resources.ApplyResources(this.checkBox_EksMODS, "checkBox_EksMODS");
            this.checkBox_EksMODS.BackgroundImage = null;
            this.checkBox_EksMODS.Font = null;
            this.checkBox_EksMODS.Name = "checkBox_EksMODS";
            this.checkBox_EksMODS.UseVisualStyleBackColor = true;
            // 
            // checkBox_EksDOD
            // 
            this.checkBox_EksDOD.AccessibleDescription = null;
            this.checkBox_EksDOD.AccessibleName = null;
            resources.ApplyResources(this.checkBox_EksDOD, "checkBox_EksDOD");
            this.checkBox_EksDOD.BackgroundImage = null;
            this.checkBox_EksDOD.Font = null;
            this.checkBox_EksDOD.Name = "checkBox_EksDOD";
            this.checkBox_EksDOD.UseVisualStyleBackColor = true;
            // 
            // checkBox_EksMAIN
            // 
            this.checkBox_EksMAIN.AccessibleDescription = null;
            this.checkBox_EksMAIN.AccessibleName = null;
            resources.ApplyResources(this.checkBox_EksMAIN, "checkBox_EksMAIN");
            this.checkBox_EksMAIN.BackgroundImage = null;
            this.checkBox_EksMAIN.Font = null;
            this.checkBox_EksMAIN.Name = "checkBox_EksMAIN";
            this.checkBox_EksMAIN.UseVisualStyleBackColor = true;
            // 
            // checkBox_EksAllDB
            // 
            this.checkBox_EksAllDB.AccessibleDescription = null;
            this.checkBox_EksAllDB.AccessibleName = null;
            resources.ApplyResources(this.checkBox_EksAllDB, "checkBox_EksAllDB");
            this.checkBox_EksAllDB.BackgroundImage = null;
            this.checkBox_EksAllDB.Font = null;
            this.checkBox_EksAllDB.Name = "checkBox_EksAllDB";
            this.checkBox_EksAllDB.UseVisualStyleBackColor = true;
            // 
            // graBindingSource
            // 
            this.graBindingSource.DataMember = "Gra";
            this.graBindingSource.DataSource = this.defaultDataSet;
            // 
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graTableAdapter
            // 
            this.graTableAdapter.ClearBeforeFill = true;
            // 
            // modsTableAdapter
            // 
            this.modsTableAdapter.ClearBeforeFill = true;
            // 
            // dodatkiTableAdapter
            // 
            this.dodatkiTableAdapter.ClearBeforeFill = true;
            // 
            // gra2MOdsBindingSource
            // 
            this.gra2MOdsBindingSource.DataMember = "Gra2MOds";
            this.gra2MOdsBindingSource.DataSource = this.graBindingSource;
            // 
            // gra2DodBindingSource
            // 
            this.gra2DodBindingSource.DataMember = "Gra2Dod";
            this.gra2DodBindingSource.DataSource = this.graBindingSource;
            // 
            // Export_DB_txt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.progressBar_export);
            this.Controls.Add(this.button_selectPath);
            this.Controls.Add(this.textBox_pathtotxt);
            this.Controls.Add(this.label_Pathtotxt);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export_DB_txt";
            this.Load += new System.EventHandler(this.Export_DB_txt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Pathtotxt;
        private System.Windows.Forms.TextBox textBox_pathtotxt;
        private System.Windows.Forms.Button button_selectPath;
        private System.Windows.Forms.ProgressBar progressBar_export;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_EksMODS;
        private System.Windows.Forms.CheckBox checkBox_EksDOD;
        private System.Windows.Forms.CheckBox checkBox_EksMAIN;
        private System.Windows.Forms.CheckBox checkBox_EksAllDB;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource graBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter graTableAdapter;
        private System.Windows.Forms.BindingSource gra2MOdsBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter modsTableAdapter;
        private System.Windows.Forms.BindingSource gra2DodBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter dodatkiTableAdapter;
    }
}