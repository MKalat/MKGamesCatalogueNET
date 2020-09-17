using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MK_Games_Catalogue_NET
{
    public partial class Export_DB_txt : Form
    {
        public Export_DB_txt()
        {
            InitializeComponent();
        }

        private void button_selectPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.csv";
            sfd.Filter = "Pliki CSV(*.csv)|*.csv";
            sfd.FilterIndex = 1;

            DialogResult res;
            res = sfd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.textBox_pathtotxt.Text = sfd.FileName;
          

            }

        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (this.textBox_pathtotxt.Text.Length > 0)
            {

                if (this.checkBox_EksAllDB.Checked == true)
                {
                    StreamWriter sw = new StreamWriter(this.textBox_pathtotxt.Text);
                    String fn_buff;
                    fn_buff = "MK Games Catalogue NET Exported data http://mkalat.pl \n\r";
                    sw.WriteLine(fn_buff);
                    // Eksportuj cała baz edanych
                    if (this.checkBox_EksMAIN.Checked == true)
                    {


                        fn_buff = "Table MAIN";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"Tytuł\"," + "\"Wydawca\"," + "\"Dystrybutor\"," +
                                "\"Producent\"," + "\"Gatunek\"," + "\"Ocena\"," + "\"Cena\"," + "\"NrKat\"," +
                                "\"Platforma\"," + "\"Nośnik\"," + "\"WWW\"," + "\"Premiera\"," + "\"Single\"," +
                                "\"Multi\"," + "\"Dodatek\"," + "\"Pic_path\"," + "\"Opis\"," + "\"Kody\"," +
                                "\"MinSpec\"," + "\"MaxSpec\"";
                        sw.WriteLine(fn_buff);
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            fn_buff = "\"" + defaultDataSet.Gra[graBindingSource.Position].ID.ToString() + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Tytul + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Wydawca + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Dystrybutor + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Producent + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Gatunek + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Ocena + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Cena + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].NrKat + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Platforma + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Nosnik + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].WWW + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Premiera + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Single + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Multi + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Dodatek + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].PicPath + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Opis + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Kody + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].MinSpec + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].MaxSpec + "\"";
                            sw.WriteLine(fn_buff);

                        }
                    }
                    if (this.checkBox_EksDOD.Checked == true)
                    {
                        fn_buff = "Table Dodatki";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"IDMAIN\"," + "\"Nazwa\"," + "\"Cena\"," + "\"Multi\"," +
                            "\"Single\"," + "\"WWW\"," + "\"Ocena\"";
                        sw.WriteLine(fn_buff);
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            for (Int32 x = 0; x < gra2DodBindingSource.Count; x++)
                            {
                                gra2DodBindingSource.Position = x;
                                fn_buff = "\"" + defaultDataSet.Gra[gra2DodBindingSource.Position].ID.ToString() + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].IDMAIN.ToString() + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Nazwa + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Cena + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Multi + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Single + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].WWW + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Ocena + "\"";
                                sw.WriteLine(fn_buff);

                            }
                        }

                    }
                    if (this.checkBox_EksMODS.Checked == true)
                    {
                        fn_buff = "Table Mody";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"IDMAIN\"," + "\"Nazwa\"," + "\"Wersja gry\"," + "\"Wersja moda\"," +
                            "\"Ocena\"," + "\"WWW\"";
                        sw.WriteLine(fn_buff);
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            for (Int32 x = 0; x < gra2MOdsBindingSource.Count; x++)
                            {
                                gra2MOdsBindingSource.Position = x;
                                fn_buff = "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].ID.ToString() + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].IDMAIN.ToString() + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Nazwa + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_gry + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_moda + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Ocena + "\",";
                                fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].WWW + "\"";
                                sw.WriteLine(fn_buff);

                            }
                        }

                    }
                    sw.Close();
                    MessageBox.Show(this, "Operacja eksportu ukończona", "MK Games Catalogue NET", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    StreamWriter sw = new StreamWriter(this.textBox_pathtotxt.Text);
                    String fn_buff;
                    fn_buff = "MK Games Catalogue NET Exported data http://mkalat.pl \n\r";
                    sw.WriteLine(fn_buff);
                    if (this.checkBox_EksMAIN.Checked == true)
                    {

                        fn_buff = "Table MAIN";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"Tytuł\"," + "\"Wydawca\"," + "\"Dystrybutor\"," +
                            "\"Producent\"," + "\"Gatunek\"," + "\"Ocena\"," + "\"Cena\"," + "\"NrKat\"," +
                            "\"Platforma\"," + "\"Nośnik\"," + "\"WWW\"," + "\"Premiera\"," + "\"Single\"," +
                            "\"Multi\"," + "\"Dodatek\"," + "\"Pic_path\"," + "\"Opis\"," + "\"Kody\"," +
                            "\"MinSpec\"," + "\"MaxSpec\"";
                        sw.WriteLine(fn_buff);

                        fn_buff = "\"" + defaultDataSet.Gra[graBindingSource.Position].ID.ToString() + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Tytul + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Wydawca + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Dystrybutor + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Producent + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Gatunek + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Ocena + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Cena + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].NrKat + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Platforma + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Nosnik + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].WWW + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Premiera + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Single + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Multi + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Dodatek + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].PicPath + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Opis + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].Kody + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].MinSpec + "\",";
                        fn_buff = fn_buff + "\"" + defaultDataSet.Gra[graBindingSource.Position].MaxSpec + "\"";
                        sw.WriteLine(fn_buff);

                    }
                    if (this.checkBox_EksDOD.Checked == true)
                    {
                        fn_buff = "Table Dodatki";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"IDMAIN\"," + "\"Nazwa\"," + "\"Cena\"," + "\"Multi\"," +
                            "\"Single\"," + "\"WWW\"," + "\"Ocena\"";
                        sw.WriteLine(fn_buff);
                        for (Int32 x = 0; x < gra2DodBindingSource.Count; x++)
                        {
                            gra2DodBindingSource.Position = x;
                            fn_buff = "\"" + defaultDataSet.Gra[gra2DodBindingSource.Position].ID.ToString() + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].IDMAIN.ToString() + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Nazwa + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Cena + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Multi + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Single + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].WWW + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Ocena + "\"";
                            sw.WriteLine(fn_buff);

                        }
                    }

                    if (this.checkBox_EksMODS.Checked == true)
                    {
                        fn_buff = "Table Mody";
                        sw.WriteLine(fn_buff);
                        fn_buff = "\"ID\"," + "\"IDMAIN\"," + "\"Nazwa\"," + "\"Wersja gry\"," + "\"Wersja moda\"," +
                            "\"Ocena\"," + "\"WWW\"";
                        sw.WriteLine(fn_buff);
                        for (Int32 x = 0; x < gra2MOdsBindingSource.Count; x++)
                        {
                            gra2MOdsBindingSource.Position = x;
                            fn_buff = "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].ID.ToString() + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].IDMAIN.ToString() + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Nazwa + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_gry + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_moda + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Ocena + "\",";
                            fn_buff = fn_buff + "\"" + defaultDataSet.Mods[gra2MOdsBindingSource.Position].WWW + "\"";
                            sw.WriteLine(fn_buff);

                        }
                    }
                    sw.Close();
                    MessageBox.Show(this, "Operacja eksportu ukończona", "MK Games Catalogue NET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Export_DB_txt_Load(object sender, EventArgs e)
        {
            graTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            modsTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            dodatkiTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            graTableAdapter.Connection.Open();
            modsTableAdapter.Connection.Open();
            dodatkiTableAdapter.Connection.Open();

            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
        }
    }
}
