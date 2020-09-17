using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Threading;

namespace MK_Games_Catalogue_NET
{
    public partial class ScanForGames : Form
    {
        Form1 frm;
        
        public ScanForGames(Form1 frm1inst)
        {
            InitializeComponent();
            frm = frm1inst;
        }

        private void button_Steam_DETECT_Click(object sender, EventArgs e)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Valve\\Steam";
            const string keyName = userRoot + "\\" + subkey;
            String steam_path = (String)Registry.GetValue(keyName, "SteamPath", " ");
            String buff_path = PathReplacer(steam_path);
            steam_path = buff_path;

            steam_path = steam_path + "\\steamapps\\common";
            this.textBox_pathGamesSteam.Text = steam_path;
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Podaj katalog, gdzie zainstalowane sa gry z Steam";
            DialogResult result = fbd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.textBox_pathGamesSteam.Text = fbd.SelectedPath;
            }
        }

        private void button_OriginDetect_Click(object sender, EventArgs e)
        {

        }

        private void button_OriginSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Podaj katalog, gdzie zainstalowane sa gry z Origin";
            DialogResult result = fbd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.textBox_OriginGamePath.Text = fbd.SelectedPath;
            }
        }

        private void button_ScanNOW_Click(object sender, EventArgs e)
        {
            
            // STEAM
            ArrayList toMainForm = new ArrayList();
            toMainForm = GetGamefromIntSteam();
            

            // ORIGIN

            MessageBox.Show("Gry z Biblioteki Steam i/lub Origin zostały pobrane, to okno zostanie zamknięte, a po powrocie do Formularza Gra, gry zostana dodane", "MK Games Catalogue NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.fromScanGames = toMainForm;
            button_OK_Click(this, null);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("paths.txt", false);
            sw.WriteLine(this.textBox_pathGamesSteam.Text);
            sw.WriteLine(this.textBox_OriginGamePath.Text);
            sw.Close();
            this.Close();
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScanForGames_Load(object sender, EventArgs e)
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

            if (File.Exists("paths.txt")) {
            StreamReader sw = new StreamReader("paths.txt");
            this.textBox_pathGamesSteam.Text = sw.ReadLine();
            this.textBox_OriginGamePath.Text = sw.ReadLine();
            sw.Close();
            }
        }

        private ArrayList GetGamefromIntSteam()
        {
            ArrayList ret_games = new ArrayList();
            String steam_path = this.textBox_pathGamesSteam.Text;
            String steam_buff = steam_path.TrimEnd("\\common".ToCharArray());
            steam_path = steam_buff;

            //DirectoryInfo dir_info = new DirectoryInfo(steam_path);

            foreach (String finfo in Directory.GetFiles(steam_path, "*.acf"))
            {
                String name_buff = "";
                StreamReader sr = new StreamReader(finfo);
                while (!sr.EndOfStream)
                {
                    name_buff = sr.ReadLine();
                    if (name_buff.Contains("name"))
                    {
                        break;
                    }
                }
                sr.Close();
                if (name_buff != "")
                {
                    String game_n = name_buff.TrimStart("\"name\"\t".ToCharArray());
                    game_n = game_n.TrimEnd('"');

                    if (IsGameCat(game_n) == false || game_n != ".." || game_n != ".")
                    {
                        
                        ret_games.Add(game_n);
          

                    }
                }


            }
            return ret_games;



        }
        private String PathReplacer(String path)
        {
            String ret_path = path.Replace('/', '\\');
            return ret_path;

        }
        private bool IsGameCat(String game_tit)
        {
            for (Int32 i = 0; i < graBindingSource.Count; i++)
            {
                graBindingSource.Position = i;
                if (game_tit == defaultDataSet.Gra[graBindingSource.Position].Tytul)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
