namespace MK_Games_Catalogue_NET
{
    partial class ScanForGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanForGames));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pathGamesSteam = new System.Windows.Forms.TextBox();
            this.button_Steam_DETECT = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OriginGamePath = new System.Windows.Forms.TextBox();
            this.button_OriginDetect = new System.Windows.Forms.Button();
            this.button_OriginSelect = new System.Windows.Forms.Button();
            this.button_ScanNOW = new System.Windows.Forms.Button();
            this.checkBox_AutoScan = new System.Windows.Forms.CheckBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.defaultDataSet = new MK_Games_Catalogue_NET.defaultDataSet();
            this.graTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter();
            this.graBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gra2MOdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modsTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter();
            this.gra2DodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatkiTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_pathGamesSteam
            // 
            resources.ApplyResources(this.textBox_pathGamesSteam, "textBox_pathGamesSteam");
            this.textBox_pathGamesSteam.Name = "textBox_pathGamesSteam";
            // 
            // button_Steam_DETECT
            // 
            resources.ApplyResources(this.button_Steam_DETECT, "button_Steam_DETECT");
            this.button_Steam_DETECT.Name = "button_Steam_DETECT";
            this.button_Steam_DETECT.UseVisualStyleBackColor = true;
            this.button_Steam_DETECT.Click += new System.EventHandler(this.button_Steam_DETECT_Click);
            // 
            // button_Select
            // 
            resources.ApplyResources(this.button_Select, "button_Select");
            this.button_Select.Name = "button_Select";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_OriginGamePath
            // 
            resources.ApplyResources(this.textBox_OriginGamePath, "textBox_OriginGamePath");
            this.textBox_OriginGamePath.Name = "textBox_OriginGamePath";
            // 
            // button_OriginDetect
            // 
            resources.ApplyResources(this.button_OriginDetect, "button_OriginDetect");
            this.button_OriginDetect.Name = "button_OriginDetect";
            this.button_OriginDetect.UseVisualStyleBackColor = true;
            this.button_OriginDetect.Click += new System.EventHandler(this.button_OriginDetect_Click);
            // 
            // button_OriginSelect
            // 
            resources.ApplyResources(this.button_OriginSelect, "button_OriginSelect");
            this.button_OriginSelect.Name = "button_OriginSelect";
            this.button_OriginSelect.UseVisualStyleBackColor = true;
            this.button_OriginSelect.Click += new System.EventHandler(this.button_OriginSelect_Click);
            // 
            // button_ScanNOW
            // 
            resources.ApplyResources(this.button_ScanNOW, "button_ScanNOW");
            this.button_ScanNOW.Name = "button_ScanNOW";
            this.button_ScanNOW.UseVisualStyleBackColor = true;
            this.button_ScanNOW.Click += new System.EventHandler(this.button_ScanNOW_Click);
            // 
            // checkBox_AutoScan
            // 
            resources.ApplyResources(this.checkBox_AutoScan, "checkBox_AutoScan");
            this.checkBox_AutoScan.Name = "checkBox_AutoScan";
            this.checkBox_AutoScan.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            resources.ApplyResources(this.button_OK, "button_OK");
            this.button_OK.Name = "button_OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
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
            // graBindingSource
            // 
            this.graBindingSource.DataMember = "Gra";
            this.graBindingSource.DataSource = this.defaultDataSet;
            // 
            // gra2MOdsBindingSource
            // 
            this.gra2MOdsBindingSource.DataMember = "Gra2MOds";
            this.gra2MOdsBindingSource.DataSource = this.graBindingSource;
            // 
            // modsTableAdapter
            // 
            this.modsTableAdapter.ClearBeforeFill = true;
            // 
            // gra2DodBindingSource
            // 
            this.gra2DodBindingSource.DataMember = "Gra2Dod";
            this.gra2DodBindingSource.DataSource = this.graBindingSource;
            // 
            // dodatkiTableAdapter
            // 
            this.dodatkiTableAdapter.ClearBeforeFill = true;
            // 
            // ScanForGames
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.checkBox_AutoScan);
            this.Controls.Add(this.button_ScanNOW);
            this.Controls.Add(this.button_OriginSelect);
            this.Controls.Add(this.button_OriginDetect);
            this.Controls.Add(this.textBox_OriginGamePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.button_Steam_DETECT);
            this.Controls.Add(this.textBox_pathGamesSteam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScanForGames";
            this.Load += new System.EventHandler(this.ScanForGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pathGamesSteam;
        private System.Windows.Forms.Button button_Steam_DETECT;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OriginGamePath;
        private System.Windows.Forms.Button button_OriginDetect;
        private System.Windows.Forms.Button button_OriginSelect;
        private System.Windows.Forms.Button button_ScanNOW;
        private System.Windows.Forms.CheckBox checkBox_AutoScan;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private defaultDataSet defaultDataSet;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter graTableAdapter;
        private System.Windows.Forms.BindingSource graBindingSource;
        private System.Windows.Forms.BindingSource gra2MOdsBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter modsTableAdapter;
        private System.Windows.Forms.BindingSource gra2DodBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter dodatkiTableAdapter;
    }
}