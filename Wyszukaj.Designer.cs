namespace MK_Games_Catalogue_NET
{
    partial class Wyszukaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyszukaj));
            this.label_Szfraza = new System.Windows.Forms.Label();
            this.textBox_SzFraza = new System.Windows.Forms.TextBox();
            this.label_SzPole = new System.Windows.Forms.Label();
            this.comboBox_SzPole = new System.Windows.Forms.ComboBox();
            this.button_Szukaj = new System.Windows.Forms.Button();
            this.label_Wyniki = new System.Windows.Forms.Label();
            this.listView_Wyniki = new System.Windows.Forms.ListView();
            this.Tytul = new System.Windows.Forms.ColumnHeader();
            this.Premiera = new System.Windows.Forms.ColumnHeader();
            this.Producent = new System.Windows.Forms.ColumnHeader();
            this.Gatunek = new System.Windows.Forms.ColumnHeader();
            this.defaultDataSet = new MK_Games_Catalogue_NET.defaultDataSet();
            this.graBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter();
            this.modsTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter();
            this.dodatkiTableAdapter = new MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter();
            this.gra2MOdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gra2DodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Szfraza
            // 
            this.label_Szfraza.AccessibleDescription = null;
            this.label_Szfraza.AccessibleName = null;
            resources.ApplyResources(this.label_Szfraza, "label_Szfraza");
            this.label_Szfraza.Font = null;
            this.label_Szfraza.Name = "label_Szfraza";
            // 
            // textBox_SzFraza
            // 
            this.textBox_SzFraza.AccessibleDescription = null;
            this.textBox_SzFraza.AccessibleName = null;
            resources.ApplyResources(this.textBox_SzFraza, "textBox_SzFraza");
            this.textBox_SzFraza.BackgroundImage = null;
            this.textBox_SzFraza.Font = null;
            this.textBox_SzFraza.Name = "textBox_SzFraza";
            // 
            // label_SzPole
            // 
            this.label_SzPole.AccessibleDescription = null;
            this.label_SzPole.AccessibleName = null;
            resources.ApplyResources(this.label_SzPole, "label_SzPole");
            this.label_SzPole.Font = null;
            this.label_SzPole.Name = "label_SzPole";
            // 
            // comboBox_SzPole
            // 
            this.comboBox_SzPole.AccessibleDescription = null;
            this.comboBox_SzPole.AccessibleName = null;
            resources.ApplyResources(this.comboBox_SzPole, "comboBox_SzPole");
            this.comboBox_SzPole.BackgroundImage = null;
            this.comboBox_SzPole.Font = null;
            this.comboBox_SzPole.FormattingEnabled = true;
            this.comboBox_SzPole.Items.AddRange(new object[] {
            resources.GetString("comboBox_SzPole.Items"),
            resources.GetString("comboBox_SzPole.Items1"),
            resources.GetString("comboBox_SzPole.Items2"),
            resources.GetString("comboBox_SzPole.Items3"),
            resources.GetString("comboBox_SzPole.Items4"),
            resources.GetString("comboBox_SzPole.Items5"),
            resources.GetString("comboBox_SzPole.Items6"),
            resources.GetString("comboBox_SzPole.Items7"),
            resources.GetString("comboBox_SzPole.Items8"),
            resources.GetString("comboBox_SzPole.Items9"),
            resources.GetString("comboBox_SzPole.Items10"),
            resources.GetString("comboBox_SzPole.Items11"),
            resources.GetString("comboBox_SzPole.Items12"),
            resources.GetString("comboBox_SzPole.Items13"),
            resources.GetString("comboBox_SzPole.Items14"),
            resources.GetString("comboBox_SzPole.Items15"),
            resources.GetString("comboBox_SzPole.Items16"),
            resources.GetString("comboBox_SzPole.Items17"),
            resources.GetString("comboBox_SzPole.Items18"),
            resources.GetString("comboBox_SzPole.Items19"),
            resources.GetString("comboBox_SzPole.Items20"),
            resources.GetString("comboBox_SzPole.Items21"),
            resources.GetString("comboBox_SzPole.Items22"),
            resources.GetString("comboBox_SzPole.Items23"),
            resources.GetString("comboBox_SzPole.Items24"),
            resources.GetString("comboBox_SzPole.Items25")});
            this.comboBox_SzPole.Name = "comboBox_SzPole";
            // 
            // button_Szukaj
            // 
            this.button_Szukaj.AccessibleDescription = null;
            this.button_Szukaj.AccessibleName = null;
            resources.ApplyResources(this.button_Szukaj, "button_Szukaj");
            this.button_Szukaj.BackgroundImage = null;
            this.button_Szukaj.Name = "button_Szukaj";
            this.button_Szukaj.UseVisualStyleBackColor = true;
            this.button_Szukaj.Click += new System.EventHandler(this.button_Szukaj_Click);
            // 
            // label_Wyniki
            // 
            this.label_Wyniki.AccessibleDescription = null;
            this.label_Wyniki.AccessibleName = null;
            resources.ApplyResources(this.label_Wyniki, "label_Wyniki");
            this.label_Wyniki.Font = null;
            this.label_Wyniki.Name = "label_Wyniki";
            // 
            // listView_Wyniki
            // 
            this.listView_Wyniki.AccessibleDescription = null;
            this.listView_Wyniki.AccessibleName = null;
            resources.ApplyResources(this.listView_Wyniki, "listView_Wyniki");
            this.listView_Wyniki.BackgroundImage = null;
            this.listView_Wyniki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tytul,
            this.Premiera,
            this.Producent,
            this.Gatunek});
            this.listView_Wyniki.Font = null;
            this.listView_Wyniki.FullRowSelect = true;
            this.listView_Wyniki.GridLines = true;
            this.listView_Wyniki.MultiSelect = false;
            this.listView_Wyniki.Name = "listView_Wyniki";
            this.listView_Wyniki.UseCompatibleStateImageBehavior = false;
            this.listView_Wyniki.View = System.Windows.Forms.View.Details;
            this.listView_Wyniki.SelectedIndexChanged += new System.EventHandler(this.listView_Wyniki_SelectedIndexChanged);
            // 
            // Tytul
            // 
            resources.ApplyResources(this.Tytul, "Tytul");
            // 
            // Premiera
            // 
            resources.ApplyResources(this.Premiera, "Premiera");
            // 
            // Producent
            // 
            resources.ApplyResources(this.Producent, "Producent");
            // 
            // Gatunek
            // 
            resources.ApplyResources(this.Gatunek, "Gatunek");
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
            // Wyszukaj
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.listView_Wyniki);
            this.Controls.Add(this.label_Wyniki);
            this.Controls.Add(this.button_Szukaj);
            this.Controls.Add(this.comboBox_SzPole);
            this.Controls.Add(this.label_SzPole);
            this.Controls.Add(this.textBox_SzFraza);
            this.Controls.Add(this.label_Szfraza);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Wyszukaj";
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2MOdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gra2DodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Szfraza;
        private System.Windows.Forms.TextBox textBox_SzFraza;
        private System.Windows.Forms.Label label_SzPole;
        private System.Windows.Forms.ComboBox comboBox_SzPole;
        private System.Windows.Forms.Button button_Szukaj;
        private System.Windows.Forms.Label label_Wyniki;
        private System.Windows.Forms.ListView listView_Wyniki;
        private System.Windows.Forms.ColumnHeader Tytul;
        private System.Windows.Forms.ColumnHeader Premiera;
        private System.Windows.Forms.ColumnHeader Producent;
        private System.Windows.Forms.ColumnHeader Gatunek;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource graBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.GraTableAdapter graTableAdapter;
        private System.Windows.Forms.BindingSource gra2MOdsBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.ModsTableAdapter modsTableAdapter;
        private System.Windows.Forms.BindingSource gra2DodBindingSource;
        private MK_Games_Catalogue_NET.defaultDataSetTableAdapters.DodatkiTableAdapter dodatkiTableAdapter;
    }
}