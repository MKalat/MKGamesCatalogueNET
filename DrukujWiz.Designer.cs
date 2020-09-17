namespace MK_Games_Catalogue_NET
{
    partial class DrukujWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrukujWiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_PrintMod = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintDod = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintMAIN = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintAll = new System.Windows.Forms.CheckBox();
            this.button_PRINT = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.defaultDataSet = new MK_Games_Catalogue_NET.defaultDataSet();
            this.graBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter();
            this.modsTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter();
            this.dodatkiTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter();
            this.gra2MOdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gra2DodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.checkBox_PrintMod);
            this.groupBox1.Controls.Add(this.checkBox_PrintDod);
            this.groupBox1.Controls.Add(this.checkBox_PrintMAIN);
            this.groupBox1.Controls.Add(this.checkBox_PrintAll);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_PrintMod
            // 
            this.checkBox_PrintMod.AccessibleDescription = null;
            this.checkBox_PrintMod.AccessibleName = null;
            resources.ApplyResources(this.checkBox_PrintMod, "checkBox_PrintMod");
            this.checkBox_PrintMod.BackgroundImage = null;
            this.checkBox_PrintMod.Font = null;
            this.checkBox_PrintMod.Name = "checkBox_PrintMod";
            this.checkBox_PrintMod.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintDod
            // 
            this.checkBox_PrintDod.AccessibleDescription = null;
            this.checkBox_PrintDod.AccessibleName = null;
            resources.ApplyResources(this.checkBox_PrintDod, "checkBox_PrintDod");
            this.checkBox_PrintDod.BackgroundImage = null;
            this.checkBox_PrintDod.Font = null;
            this.checkBox_PrintDod.Name = "checkBox_PrintDod";
            this.checkBox_PrintDod.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintMAIN
            // 
            this.checkBox_PrintMAIN.AccessibleDescription = null;
            this.checkBox_PrintMAIN.AccessibleName = null;
            resources.ApplyResources(this.checkBox_PrintMAIN, "checkBox_PrintMAIN");
            this.checkBox_PrintMAIN.BackgroundImage = null;
            this.checkBox_PrintMAIN.Font = null;
            this.checkBox_PrintMAIN.Name = "checkBox_PrintMAIN";
            this.checkBox_PrintMAIN.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintAll
            // 
            this.checkBox_PrintAll.AccessibleDescription = null;
            this.checkBox_PrintAll.AccessibleName = null;
            resources.ApplyResources(this.checkBox_PrintAll, "checkBox_PrintAll");
            this.checkBox_PrintAll.BackgroundImage = null;
            this.checkBox_PrintAll.Font = null;
            this.checkBox_PrintAll.Name = "checkBox_PrintAll";
            this.checkBox_PrintAll.UseVisualStyleBackColor = true;
            // 
            // button_PRINT
            // 
            this.button_PRINT.AccessibleDescription = null;
            this.button_PRINT.AccessibleName = null;
            resources.ApplyResources(this.button_PRINT, "button_PRINT");
            this.button_PRINT.BackgroundImage = null;
            this.button_PRINT.Name = "button_PRINT";
            this.button_PRINT.UseVisualStyleBackColor = true;
            this.button_PRINT.Click += new System.EventHandler(this.button_PRINT_Click);
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
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graBindingSource
            // 
            this.graBindingSource.DataMember = "Gra";
            this.graBindingSource.DataSource = this.defaultDataSet;
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
            // DrukujWiz
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_PRINT);
            this.Controls.Add(this.groupBox1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DrukujWiz";
            this.Load += new System.EventHandler(this.DrukujWiz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_PrintAll;
        private System.Windows.Forms.CheckBox checkBox_PrintMAIN;
        private System.Windows.Forms.CheckBox checkBox_PrintDod;
        private System.Windows.Forms.CheckBox checkBox_PrintMod;
        private System.Windows.Forms.Button button_PRINT;
        private System.Windows.Forms.Button button_Cancel;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource graBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter graTableAdapter;
        private System.Windows.Forms.BindingSource gra2MOdsBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter modsTableAdapter;
        private System.Windows.Forms.BindingSource gra2DodBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter dodatkiTableAdapter;
    }
}