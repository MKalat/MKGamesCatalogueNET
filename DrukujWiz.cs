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
    public partial class DrukujWiz : Form
    {
        public DrukujWiz()
        {
            InitializeComponent();
        }
        String fn_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\print_buff-MKGCNET.txt";
                
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_PRINT_Click(object sender, EventArgs e)
        {
            if (this.checkBox_PrintAll.Checked == true)
            {
                StreamWriter sw = new StreamWriter(fn_path);
                String fn_buff;
                fn_buff = "MK Games Catalogue NET Exported data http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                // Eksportuj cała baz edanych
                if (this.checkBox_PrintMAIN.Checked == true)
                {
                    fn_buff = "Podstawowe dane o grze : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < graBindingSource.Count; i++)
                    {
                        graBindingSource.Position = i;
                        fn_buff = "ID  : " + defaultDataSet.Gra[graBindingSource.Position].ID.ToString();
                        sw.WriteLine(fn_buff);
                        fn_buff = "Tytuł : " + defaultDataSet.Gra[graBindingSource.Position].Tytul;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Wydawca : " + defaultDataSet.Gra[graBindingSource.Position].Wydawca;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Dystrybutor : " + defaultDataSet.Gra[graBindingSource.Position].Dystrybutor;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Producent : " + defaultDataSet.Gra[graBindingSource.Position].Producent;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Gatunek : " + defaultDataSet.Gra[graBindingSource.Position].Gatunek;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Ocena : " + defaultDataSet.Gra[graBindingSource.Position].Ocena;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Cena : " + defaultDataSet.Gra[graBindingSource.Position].Cena;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Nr Kat : " + defaultDataSet.Gra[graBindingSource.Position].NrKat;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Platforma : " + defaultDataSet.Gra[graBindingSource.Position].Platforma;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Nośnik : " + defaultDataSet.Gra[graBindingSource.Position].Nosnik;
                        sw.WriteLine(fn_buff);
                        fn_buff = "WWW : " + defaultDataSet.Gra[graBindingSource.Position].WWW;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Premiera : " + defaultDataSet.Gra[graBindingSource.Position].Premiera;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Single : " + defaultDataSet.Gra[graBindingSource.Position].Single;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Multi : " + defaultDataSet.Gra[graBindingSource.Position].Multi;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Dodatek : " + defaultDataSet.Gra[graBindingSource.Position].Dodatek;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Opis : " + defaultDataSet.Gra[graBindingSource.Position].Opis;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Kody : " + defaultDataSet.Gra[graBindingSource.Position].Kody;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Minimalne wymaga systemowe : " + defaultDataSet.Gra[graBindingSource.Position].MinSpec;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Rekomendowane wymagania systemowe : " + defaultDataSet.Gra[graBindingSource.Position].MaxSpec;
                        sw.WriteLine(fn_buff);
                        fn_buff = "========================================================= \n\r";
                        sw.WriteLine(fn_buff);

                    }
                }
                if (this.checkBox_PrintDod.Checked == true)
                {
                    fn_buff = "Tabela Dodatki : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < graBindingSource.Count; i++)
                    {
                        graBindingSource.Position = i;
                        for (Int32 x = 0; x < gra2DodBindingSource.Count; x++)
                        {
                            gra2DodBindingSource.Position = x;
                            fn_buff = "ID : " + defaultDataSet.Gra[gra2DodBindingSource.Position].ID.ToString();
                            sw.WriteLine(fn_buff);
                            fn_buff = "ID MAIN : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].IDMAIN.ToString();
                            sw.WriteLine(fn_buff);
                            fn_buff = "Nazwa : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Nazwa;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Cena : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Cena;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Multi : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Multi;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Single : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Single;
                            sw.WriteLine(fn_buff);
                            fn_buff = "WWW : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].WWW;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Ocena : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position];
                            sw.WriteLine(fn_buff);
                            fn_buff = "##################### \n\r";
                            sw.WriteLine(fn_buff);

                        }
                    }

                }
                if (this.checkBox_PrintMod.Checked == true)
                {
                    fn_buff = "Tabela Mody : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < graBindingSource.Count; i++)
                    {
                        graBindingSource.Position = i;
                        for (Int32 x = 0; x < gra2MOdsBindingSource.Count; x++)
                        {
                            gra2MOdsBindingSource.Position = x;
                            fn_buff = "ID : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].ID.ToString();
                            sw.WriteLine(fn_buff);
                            fn_buff = "ID MAIN : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].IDMAIN.ToString();
                            sw.WriteLine(fn_buff);
                            fn_buff = "Nazwa : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Nazwa;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Wersja gry : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_gry;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Wersja moda : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_moda;
                            sw.WriteLine(fn_buff);
                            fn_buff = "Ocena : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Ocena;
                            sw.WriteLine(fn_buff);
                            fn_buff = "WWW : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].WWW;
                            sw.WriteLine(fn_buff);
                            fn_buff = "########################## \n\r";
                            sw.WriteLine(fn_buff);

                        }
                    }

                }
                sw.Close();
                System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
                PrintDialog prndial = new PrintDialog();
                prndial.AllowSomePages = false;
                prndial.ShowHelp = true;
                prndial.Document = docToPrint;
                DialogResult res = prndial.ShowDialog();
                if (res == DialogResult.OK)
                {
                    docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage); 
                    docToPrint.Print();

                }


            }
            else
            {
                StreamWriter sw = new StreamWriter(fn_path);
                String fn_buff;
                fn_buff = "MK Games Catalogue NET http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                if (this.checkBox_PrintMAIN.Checked == true)
                {

                    fn_buff = "Podstawowe informacje o grze :";
                    sw.WriteLine(fn_buff);
                    fn_buff = "ID  : " + defaultDataSet.Gra[graBindingSource.Position].ID.ToString();
                    sw.WriteLine(fn_buff);
                    fn_buff = "Tytuł : " + defaultDataSet.Gra[graBindingSource.Position].Tytul;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Wydawca : " + defaultDataSet.Gra[graBindingSource.Position].Wydawca;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Dystrybutor : " + defaultDataSet.Gra[graBindingSource.Position].Dystrybutor;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Producent : " + defaultDataSet.Gra[graBindingSource.Position].Producent;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Gatunek : " + defaultDataSet.Gra[graBindingSource.Position].Gatunek;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Ocena : " + defaultDataSet.Gra[graBindingSource.Position].Ocena;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Cena : " + defaultDataSet.Gra[graBindingSource.Position].Cena;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Nr Kat : " + defaultDataSet.Gra[graBindingSource.Position].NrKat;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Platforma : " + defaultDataSet.Gra[graBindingSource.Position].Platforma;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Nośnik : " + defaultDataSet.Gra[graBindingSource.Position].Nosnik;
                    sw.WriteLine(fn_buff);
                    fn_buff = "WWW : " + defaultDataSet.Gra[graBindingSource.Position].WWW;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Premiera : " + defaultDataSet.Gra[graBindingSource.Position].Premiera;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Single : " + defaultDataSet.Gra[graBindingSource.Position].Single;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Multi : " + defaultDataSet.Gra[graBindingSource.Position].Multi;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Dodatek : " + defaultDataSet.Gra[graBindingSource.Position].Dodatek;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Opis : " + defaultDataSet.Gra[graBindingSource.Position].Opis;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Kody : " + defaultDataSet.Gra[graBindingSource.Position].Kody;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Minimalne wymaga systemowe : " + defaultDataSet.Gra[graBindingSource.Position].MinSpec;
                    sw.WriteLine(fn_buff);
                    fn_buff = "Rekomendowane wymagania systemowe : " + defaultDataSet.Gra[graBindingSource.Position].MaxSpec;
                    sw.WriteLine(fn_buff);
                    fn_buff = "========================================================= \n\r";
                    sw.WriteLine(fn_buff);

                }
                if (this.checkBox_PrintDod.Checked == true)
                {
                    fn_buff = "Tabela Dodatki : ";
                    sw.WriteLine(fn_buff);
                    
                    for (Int32 x = 0; x < gra2DodBindingSource.Count; x++)
                    {
                        gra2DodBindingSource.Position = x;
                        fn_buff = "ID : " + defaultDataSet.Gra[gra2DodBindingSource.Position].ID.ToString();
                        sw.WriteLine(fn_buff);
                        fn_buff = "ID MAIN : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].IDMAIN.ToString();
                        sw.WriteLine(fn_buff);
                        fn_buff = "Nazwa : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Nazwa;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Cena : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Cena;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Multi : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Multi;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Single : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].Single;
                        sw.WriteLine(fn_buff);
                        fn_buff = "WWW : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position].WWW;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Ocena : " + defaultDataSet.Dodatki[gra2DodBindingSource.Position];
                        sw.WriteLine(fn_buff);
                        fn_buff = "##################### \n\r";
                        sw.WriteLine(fn_buff);

                    }
                }

                if (this.checkBox_PrintMod.Checked == true)
                {
                    fn_buff = "Tabela Mody : ";
                    sw.WriteLine(fn_buff);
                    
                    for (Int32 x = 0; x < gra2MOdsBindingSource.Count; x++)
                    {
                        gra2MOdsBindingSource.Position = x;
                        fn_buff = "ID : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].ID.ToString();
                        sw.WriteLine(fn_buff);
                        fn_buff = "ID MAIN : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].IDMAIN.ToString();
                        sw.WriteLine(fn_buff);
                        fn_buff = "Nazwa : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Nazwa;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Wersja gry : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_gry;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Wersja moda : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Wersja_moda;
                        sw.WriteLine(fn_buff);
                        fn_buff = "Ocena : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].Ocena;
                        sw.WriteLine(fn_buff);
                        fn_buff = "WWW : " + defaultDataSet.Mods[gra2MOdsBindingSource.Position].WWW;
                        sw.WriteLine(fn_buff);
                        fn_buff = "########################## \n\r";
                        sw.WriteLine(fn_buff);

                    }
                }
                sw.Close();
                System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
                PrintDialog prndial = new PrintDialog();
                prndial.AllowSomePages = false;
                prndial.ShowHelp = true;
                prndial.Document = docToPrint;
                DialogResult res = prndial.ShowDialog();
                if (res == DialogResult.OK)
                {
                    docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage); 
                    docToPrint.Print();

                }
            }


        }
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
            StreamReader fn_prnread = new StreamReader(fn_path);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 10);
            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height / 
              printFont.GetHeight(e.Graphics);

            // Print each line of the file.
            while(count < linesPerPage && 
              ((line=fn_prnread.ReadLine()) != null)) 
            {
              yPos = topMargin + (count * 
                 printFont.GetHeight(e.Graphics));
              e.Graphics.DrawString(line, printFont, Brushes.Black, 
                 leftMargin, yPos, new StringFormat());
              count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            }

        private void DrukujWiz_Load(object sender, EventArgs e)
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
