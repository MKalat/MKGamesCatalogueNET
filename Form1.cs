using System;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;


namespace MK_Games_Catalogue_NET
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }


        public static String cur_db_path;
        public static String db_path;
        public static Int32 s_pos;
        public static Int32 http_stage;
        public static String ctrl_uri, ctrl2_uri;
        public static bool proceed_add_games = false;

        public static ArrayList fromScanGames;
        public static bool game_dld = false;
        public static bool http_st_proc = false;
        Int32[] pos_arr = new Int32[1]; 
        
        public SETT_REC sett = new SETT_REC();

        // definicje naz plików profili i baz danych
        String FN_PROF_REC = "settings.dat";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'defaultDataSet.Dodatki' table. You can move, or remove it, as needed.
            //this.dodatkiTableAdapter.Fill(this.defaultDataSet.Dodatki);
            // TODO: This line of code loads data into the 'defaultDataSet.Mods' table. You can move, or remove it, as needed.
            //this.modsTableAdapter.Fill(this.defaultDataSet.Mods);
            // TODO: This line of code loads data into the 'defaultDataSet.Gra' table. You can move, or remove it, as needed.
            //this.graTableAdapter.Fill(this.defaultDataSet.Gra);

            

            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            db_path = path;
            db_path = db_path + "\\MKGamesCatalogue\\";
            cur_db_path = db_path + "MKGC.sdf";

            Start_AU();
            if (CheckDBExist(cur_db_path) == 0)
            {
                Utworz_DB(db_path);

            }
            graTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            modsTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            dodatkiTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            graTableAdapter.Connection.Open();
            modsTableAdapter.Connection.Open();
            dodatkiTableAdapter.Connection.Open();

            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
            graBindingSource.MoveFirst();
            LiczRec();
        }
        
        private Int32 CheckDBExist(String path)
        {
            if (!File.Exists(path))
            {
                return 0;
            }
            else
                return -1;
        }
        private void Utworz_DB(String path)
        {
            
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path + "\\covers");
            File.Copy("default.sdf", cur_db_path, true);
  
        }

        private void button_First_Click(object sender, EventArgs e)
        {
           
            graBindingSource.MoveFirst();
            LiczRec();
           
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            
            graBindingSource.MovePrevious();
            LiczRec();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            
            graBindingSource.MoveNext();
            LiczRec();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            
            graBindingSource.MoveLast();
            LiczRec();
        }

        public void button_New_Click(object sender, EventArgs e)
        {
            this.checkBox_Exp.Checked = false;
            this.checkBox_Multi.Checked = false;
            this.checkBox_Single.Checked = false;
            graBindingSource.AddNew();
            graBindingSource.EndEdit();
            //graTableAdapter.Update(defaultDataSet.Gra);
            //modsTableAdapter.Update(defaultDataSet.Mods);
            //dodatkiTableAdapter.Update(defaultDataSet.Dodatki);
            //graTableAdapter.Fill(defaultDataSet.Gra);
            //modsTableAdapter.Fill(defaultDataSet.Mods);
            //dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
            LiczRec();
        }

        public void button_Save_Click(object sender, EventArgs e)
        {
            defaultDataSet.GraRow gra_row;
            gra_row = (defaultDataSet.GraRow)this.defaultDataSet.Gra.Rows[this.graBindingSource.Position];
            int saved_id = gra_row.ID;

            graBindingSource.EndEdit();
            
                        
            graTableAdapter.Update(defaultDataSet.Gra);
            modsTableAdapter.Update(defaultDataSet.Mods);
            dodatkiTableAdapter.Update(defaultDataSet.Dodatki);

            
            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
            
            //graBindingSource.MoveFirst();
            this.graBindingSource.Position = this.graBindingSource.Find("ID", saved_id);

            LiczRec();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < gra2MOdsBindingSource.List.Count; i++)
            {
                gra2MOdsBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < gra2DodBindingSource.List.Count; i++)
            {
                gra2DodBindingSource.RemoveAt(i);
            }
            graBindingSource.RemoveCurrent();
           
            
            graTableAdapter.Update(defaultDataSet.Gra);
            modsTableAdapter.Update(defaultDataSet.Mods);
            dodatkiTableAdapter.Update(defaultDataSet.Dodatki);


            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
            graBindingSource.MoveFirst();
            LiczRec();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog(this);
        }

        private void sprawdźAktualizacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_AU();
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpWiz frm_help = new HelpWiz();
            frm_help.Show();
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SETT_REC.ask_on_exit == true)
            {
                DialogResult dlg_res = new DialogResult();
                if (SETT_REC.lang_path == 0)
                {
                    dlg_res = MessageBox.Show("Czy napewno zamknąć program MK Games Catalogue NET ?", "MK Games Gatalogue NET", MessageBoxButtons.YesNo);
                }
                else if (SETT_REC.lang_path == 1)
                {
                    dlg_res = MessageBox.Show("Do You really want to close MK Games Catalogue NET ?", "MK Games Gatalogue NET", MessageBoxButtons.YesNo);
               
                }
                if (dlg_res == DialogResult.Yes)
                {
                    if (SETT_REC.save_on_exit == true)
                    {
                        graBindingSource.EndEdit();


                        graTableAdapter.Update(defaultDataSet.Gra);
                        modsTableAdapter.Update(defaultDataSet.Mods);
                        dodatkiTableAdapter.Update(defaultDataSet.Dodatki);


                        graTableAdapter.Fill(defaultDataSet.Gra);
                        modsTableAdapter.Fill(defaultDataSet.Mods);
                        dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);

                        graBindingSource.MoveFirst();
                        LiczRec();
                    }
                    this.Close();
                }
            }
            else
            {
                if (SETT_REC.save_on_exit == true)
                {
                    graBindingSource.EndEdit();


                    graTableAdapter.Update(defaultDataSet.Gra);
                    modsTableAdapter.Update(defaultDataSet.Mods);
                    dodatkiTableAdapter.Update(defaultDataSet.Dodatki);


                    graTableAdapter.Fill(defaultDataSet.Gra);
                    modsTableAdapter.Fill(defaultDataSet.Mods);
                    dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);

                    graBindingSource.MoveFirst();
                    LiczRec();
                }
                this.Close();
            }
            
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings sett = new Settings();
            sett.ShowDialog(this);
            
        }

        public static void SaveSettings()
        {
            FileStream fs;
            fs = File.Open("settings.dat", FileMode.Create,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(SETT_REC.enabled_au);
            bw.Write(SETT_REC.days_to_au);
            bw.Write(SETT_REC.lang_path);
            bw.Write(SETT_REC.ask_on_exit);
            bw.Write(SETT_REC.save_on_exit);
            bw.Close();
        }

        private void wybierzBazęDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Podaj katalog, gdzie MKGC ma przechowywac baze danych";
            fbd.ShowNewFolderButton = true;
            DialogResult res = fbd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                cur_db_path = fbd.SelectedPath + "\\MKGC.sdf";
                if (CheckDBExist(cur_db_path) == 0)
                {   
                    Utworz_DB(fbd.SelectedPath);
                    
                }
                
                graTableAdapter.Connection.Close();
                modsTableAdapter.Connection.Close();
                dodatkiTableAdapter.Connection.Close();
                graTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                modsTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                dodatkiTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                graTableAdapter.Connection.Open();
                modsTableAdapter.Connection.Open();
                dodatkiTableAdapter.Connection.Open();
                
                graTableAdapter.Fill(defaultDataSet.Gra);
                modsTableAdapter.Fill(defaultDataSet.Mods);
                dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);

                graBindingSource.MoveFirst();
                LiczRec();


            }
        }
        private void LiczRec()
        {
            int pos = graBindingSource.Position + 1;
            this.textBox_recno.Text = pos.ToString();
            this.textBox_reccnt.Text = graBindingSource.Count.ToString();
            Update_GamesList();

        }

        private void Start_AU()
        {
            if (SETT_REC.enabled_au == true)
            {
                String myPath = Environment.CurrentDirectory;
                Process ps = new Process();
                const int ERROR_FILE_NOT_FOUND = 2;
                const int ERROR_ACCESS_DENIED = 5;
                try
                {
                    ps.StartInfo.FileName = myPath + "\\" + "MK_AUTOUPDATE.exe";
                    ps.Start();
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == ERROR_FILE_NOT_FOUND)
                    {
                        if (SETT_REC.lang_path == 0)
                        {
                            MessageBox.Show(ex.Message + ". Sprawdź ścieżkę.", "MK Games Catalogue NET", MessageBoxButtons.OK);
                        }
                        else if (SETT_REC.lang_path == 1)
                        {
                            MessageBox.Show(ex.Message + ". Check path.", "MK Games Catalogue NET", MessageBoxButtons.OK);
                        }
                    }

                    else if (ex.NativeErrorCode == ERROR_ACCESS_DENIED)
                    {
                        if (SETT_REC.lang_path == 0)
                        {
                            MessageBox.Show(ex.Message + ". Nie masz uprawnień aby uruchomić updatera.", "MK Games Catalogue NET", MessageBoxButtons.OK);
                        }
                        else if (SETT_REC.lang_path == 1)
                        {
                            MessageBox.Show(ex.Message + ". You have not required permissions to run autoupdater.", "MK Games Catalogue NET", MessageBoxButtons.OK);
                       
                        }
                    }
                }
            }


        }

        private void bazeDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_DB_txt eks_frm = new Export_DB_txt();
            eks_frm.ShowDialog(this);
        }

        private void bazeDanychToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO Napisać import z pliku CSV
        }

        private void button_LoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG)|*.BMP;*.JPG;*.JPEG";
            ofd.FilterIndex = 1;
            DialogResult res = ofd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                defaultDataSet.Gra[graBindingSource.Position].PicPath = ofd.FileName;
                graTableAdapter.Update(defaultDataSet.Gra);
                modsTableAdapter.Update(defaultDataSet.Mods);
                dodatkiTableAdapter.Update(defaultDataSet.Dodatki);
                
                graTableAdapter.Fill(defaultDataSet.Gra);
                modsTableAdapter.Fill(defaultDataSet.Mods);
                dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
                
            }
        }

        private void button_DelImg_Click(object sender, EventArgs e)
        {
            defaultDataSet.Gra[graBindingSource.Position].PicPath = "";
            graTableAdapter.Update(defaultDataSet.Gra);
            modsTableAdapter.Update(defaultDataSet.Mods);
            dodatkiTableAdapter.Update(defaultDataSet.Dodatki);

            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
        }

        private void wyszukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wyszukaj wysz = new Wyszukaj();
            wysz.Show(this);
        }
        public void GetWyszIDX()
        {
            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
            graBindingSource.Position = s_pos;
            LiczRec();
            

        }

        private void button_K_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_Kody.Clear();
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrukujWiz prnfrm = new DrukujWiz();
            prnfrm.Show(this);
        }

        public void pobierzDaneZInternetuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO : Napisac pobieranie info o grze z internetu
            // ze stron wydawców gier komputerowych w polsce : gram.pl, cenega, gry-online.pl
            if (this.textBox_Title.Text.Length > 0)
            {
                http_stage = 1;
                this.webBrowser_GetIntData.Navigate("http://gry-online.pl");
                
                // gry- on line.pl
                //HttpWebRequest golreq = (HttpWebRequest)WebRequest.Create("http://gry-online.pl/szukaj.asp");
                //golreq.Method = "POST";
                //String postData = "value=\"" + this.textBox_Title.Text + "\"";
                //UTF8Encoding encoding = new UTF8Encoding();
                //Byte[] postByte = encoding.GetBytes(postData);
                //golreq.ContentType = "application/x-www-form-urlencoded";
                //golreq.ContentLength = postByte.Length;
                //Stream postStream = golreq.GetRequestStream();
                //postStream.Write(postByte, 0, postByte.Length);
                //HttpWebResponse golres = (HttpWebResponse)golreq.GetResponse();
                //Stream recvStream = golres.GetResponseStream();
                //StreamReader golstrread = new StreamReader(recvStream, Encoding.UTF8);
                //String golHTML = golstrread.ReadToEnd();
                //String szukane;
                //Int32 beg_ind, end_ind;

                //if (golHTML.Contains(this.textBox_Title.Text))
                //{
                //    Int32 gameind = golHTML.IndexOf(this.textBox_Title.Text);
                //    Int32 urlInd = golHTML.IndexOf("<ul class=\"ul7\"><li><a href=\"");
                //    szukane = golHTML.Substring(urlInd + 29, (gameind - 2) - (urlInd + 29));
                //    HttpWebRequest golgame = (HttpWebRequest)WebRequest.Create("http://gry-online.pl/" + szukane);
                //    HttpWebResponse gameres = (HttpWebResponse)golgame.GetResponse();
                //    recvStream = gameres.GetResponseStream();
                //    StreamReader gameread = new StreamReader(recvStream, Encoding.UTF8);
                //    golHTML = gameread.ReadToEnd();
                //    gameread.Close();
                //    end_ind = golHTML.IndexOf("\" alt=\"" + this.textBox_Title.Text + " okładka");
                //    beg_ind = golHTML.IndexOf("<div class=\"d1\"><img src=\"");
                //    szukane = golHTML.Substring(beg_ind, end_ind - beg_ind);
                //    beg_ind = szukane.LastIndexOfAny("/".ToCharArray());
                //    String file_name_okl = szukane.Substring(beg_ind, szukane.Length - beg_ind);
                //    WebClient WC = new WebClient();
                //    WC.DownloadFile("http://gry-online.pl/" + szukane, db_path + "\\covers\\" + file_name_okl);
                //    defaultDataSet.Gra[graBindingSource.Position].PicPath = db_path + "\\covers\\" + file_name_okl;
                    
                //    String SrchPhrs = "<div class=\"d2\"><div class=\"tit\"><h1>" + this.textBox_Title.Text + "</h1><p><b>";
                //    beg_ind = golHTML.IndexOf(SrchPhrs);
                //    end_ind = golHTML.IndexOf("</b>", beg_ind);
                //    szukane = golHTML.Substring(beg_ind + SrchPhrs.Length, end_ind - (beg_ind + SrchPhrs.Length));
                //    defaultDataSet.Gra[graBindingSource.Position].Wydawca = szukane;
                    
                //    beg_ind = end_ind + 10;
                //    end_ind = golHTML.IndexOf("</b> )", beg_ind);
                //    szukane = golHTML.Substring(beg_ind, end_ind - beg_ind);
                //    defaultDataSet.Gra[graBindingSource.Position].Gatunek = szukane;

                //    beg_ind = end_ind + 7;
                //    end_ind = golHTML.IndexOf("<a href=", beg_ind);
                //    szukane = golHTML.Substring(beg_ind, end_ind - beg_ind);
                //    defaultDataSet.Gra[graBindingSource.Position].Opis = szukane;

                //    beg_ind = golHTML.IndexOf("<div class=\"dt1\">");
                //    end_ind = golHTML.IndexOf("</div>", beg_ind);
                //    szukane = golHTML.Substring(beg_ind + 17, end_ind - (beg_ind + 17));

                //    beg_ind = golHTML.IndexOf("<div class=\"dt2\">") + 17;
                //    end_ind = golHTML.IndexOf("</div>", beg_ind);
                //    szukane = szukane + " " + golHTML.Substring(beg_ind, end_ind - beg_ind);

                //    beg_ind = golHTML.IndexOf("<div class=\"dt3\">") + 17;
                //    end_ind = golHTML.IndexOf("</div>", beg_ind);
                //    szukane = szukane + " " + golHTML.Substring(beg_ind, end_ind - beg_ind);
                //    defaultDataSet.Gra[graBindingSource.Position].Premiera = szukane;

                //    graTableAdapter.Update(defaultDataSet.Gra);
                //    modsTableAdapter.Update(defaultDataSet.Mods);
                //    dodatkiTableAdapter.Update(defaultDataSet.Dodatki);

                //    graTableAdapter.Fill(defaultDataSet.Gra);
                //    modsTableAdapter.Fill(defaultDataSet.Mods);
                //    dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);
                //}


            }
        }
        

        public void webBrowser_GetIntData_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement element;
            HtmlDocument doc = this.webBrowser_GetIntData.Document.Window.Document;
            Int32 beg_ind, end_ind;
            String szukane = "", Year = "", Month = "", Day = "";
            http_st_proc = false;
            String test_powt = "";
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return; 
            if (doc.Title.Contains("GRY-OnLine.pl - Gry Online dla wszystkich") && http_stage == 1)
            {
                
                element = doc.GetElementById("search");
                element.SetAttribute("value", this.textBox_Title.Text);
                foreach (HtmlElement ele in doc.GetElementsByTagName("input"))
                {
                    if (ele.OuterHtml.Contains("type=submit>"))
                    {
                        ele.InvokeMember("Click");
                        http_stage = 2;
                        http_st_proc = true;
                        break;

                    }

                }




            }
            else if (doc.Url.ToString().Contains("szukaj.asp"))
            {
                
                foreach (HtmlElement ele in doc.GetElementsByTagName("a"))
                {
                    if (ele.OuterHtml.Contains(this.textBox_Title.Text))
                    {
                        if (!ele.OuterHtml.Contains("Zgłoś nam brak gry o tytule"))
                        {
                            String buff;
                            buff = ele.GetAttribute("href");
                            ctrl_uri = buff;
                            ele.InvokeMember("Click");
                            http_stage = 3;
                            http_st_proc = true;
                            break;
                        }

                    }
                    else
                    {
                        


                    }


                }
                if (http_st_proc == false)
                {
                    
                    if (test_powt != doc.Url.ToString())
                    {
                        if (this.webBrowser_GetIntData.IsBusy == false)
                        {
                            this.button_Save_Click(this, null);
                            if (game_dld)
                            {
                                this.AddGamesThread();
                                test_powt = doc.Url.ToString();

                            }

                        }
                    }

                }


            }
            else if (doc.Url.ToString().Contains(ctrl_uri))
            {
                
                

           
                foreach (HtmlElement ele in doc.GetElementsByTagName("DIV"))
                {
                    szukane = ele.OuterHtml;
                    if (ele.OuterHtml.Contains("class=d1"))
                    {
                        beg_ind = ele.OuterHtml.IndexOf("src") + 6;
                        end_ind = ele.OuterHtml.IndexOf("jpg") + 3;
                        szukane = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);
                        beg_ind = szukane.LastIndexOfAny("/".ToCharArray()) + 1;
                        String file_name_okl = szukane.Substring(beg_ind, szukane.Length - beg_ind);
                        WebClient WC = new WebClient();
                        WC.DownloadFile("http://gry-online.pl/" + szukane, db_path + "\\covers\\" + file_name_okl);
                        this.pictureBox_Image.ImageLocation = db_path + "\\covers\\" + file_name_okl;


                    }
                    if (ele.OuterHtml.Contains("class=tit"))
                    {
                        beg_ind = ele.OuterHtml.IndexOf("<B>") + 3;
                        end_ind = ele.OuterHtml.IndexOf("</B>", beg_ind);
                        szukane = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);
                        if (szukane.Contains(this.textBox_Title.Text))
                        {
                            beg_ind = ele.OuterHtml.IndexOf("<B>", end_ind) + 3;
                            end_ind = ele.OuterHtml.IndexOf("</B>", beg_ind);
                            szukane = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);

                        }
                        this.textBox_Publisher.Text = szukane;

                        beg_ind = ele.OuterHtml.IndexOf("<B>", end_ind) + 3;
                        end_ind = ele.OuterHtml.IndexOf("</B>", beg_ind);
                        szukane = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);
                        this.comboBox_Genre.Text = szukane;

                       
                        if (ele.OuterHtml.Contains("class=dt1"))
                        {
                            beg_ind = ele.OuterHtml.IndexOf("class=dt1") + 10;
                            end_ind = ele.OuterHtml.IndexOf("DIV", beg_ind) - 2;
                            Year = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);

                        }
                        if (ele.OuterHtml.Contains("class=dt2"))
                        {
                            beg_ind = ele.OuterHtml.IndexOf("class=dt2") + 10;
                            end_ind = ele.OuterHtml.IndexOf("DIV", beg_ind) - 2;
                            Day =  ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);

                        }
                        if (ele.OuterHtml.Contains("class=dt3"))
                        {
                            beg_ind = ele.OuterHtml.IndexOf("class=dt3") + 10;
                            end_ind = ele.OuterHtml.IndexOf("DIV", beg_ind) - 2;
                            Month = ele.OuterHtml.Substring(beg_ind, end_ind - beg_ind);
                        }
                        this.textBox_Premiere.Text = Day + " " + Month + " " + Year;

                        
                    }
                   
                    
                    
                }
                foreach (HtmlElement ele in doc.GetElementsByTagName("P"))
                {
                    if (ele.OuterHtml.Contains("class=gra-info-txt"))
                    {
                        this.richTextBox_Desc.Text = ele.OuterText;
                    }
                }
                foreach (HtmlElement ele in doc.GetElementsByTagName("A"))
                {
                    if (ele.GetAttribute("href").Contains("S016.asp"))
                    {
                        ctrl2_uri = ele.GetAttribute("href");
                        ele.InvokeMember("Click");
                        http_stage = 4;
                        http_st_proc = true;
                        break;
                    }
                }
                if (http_st_proc == false)
                {
                    if (test_powt != doc.Url.ToString())
                    {
                        if (this.webBrowser_GetIntData.IsBusy == false)
                        {
                            this.button_Save_Click(this, null);
                            if (game_dld)
                            {
                                this.AddGamesThread();
                                test_powt = doc.Url.ToString();

                            }

                        }
                    }
                }
                
            }
            else if (doc.Url.ToString().Contains(ctrl2_uri))
            {
                foreach (HtmlElement ele in doc.GetElementsByTagName("A"))
                {
                    if (ele.OuterHtml.Contains("producent.asp"))
                    {
                        this.textBox_Producer.Text = ele.InnerText;

                    }
                    if (ele.OuterHtml.Contains("Strona oficjalna"))
                    {
                        this.textBox_WWW.Text = ele.GetAttribute("href");

                    }
                    
                }
                foreach (HtmlElement ele in doc.GetElementsByTagName("P"))
                {
                    if (ele.OuterHtml.Contains("MB RAM") && ele.OuterHtml.Contains("HDD"))
                    {
                        this.textBox_MinReq.Text = ele.OuterHtml.Substring(5,ele.OuterHtml.Length - 9);
                        
                       
                    }

                }
                if (http_st_proc == false)
                {
                    if (this.webBrowser_GetIntData.IsBusy == false)
                    {
                        this.button_Save_Click(this, null);
                        if (game_dld)
                        {
                            this.AddGamesThread();

                        }

                    }
                }
                
            }
            else
            {
                if (http_st_proc == false)
                {

                    if (test_powt != doc.Url.ToString())
                    {
                        if (this.webBrowser_GetIntData.IsBusy == false)
                        {
                            this.button_Save_Click(this, null);
                            if (game_dld)
                            {
                                this.AddGamesThread();
                                test_powt = doc.Url.ToString();

                            }

                        }
                    }

                }
            }
            
        }

        private void skanujWPoszukiwaniuGierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanForGames sfg = new ScanForGames(this);
            sfg.ShowDialog(this);
            if (fromScanGames != null)
            {
                AddGamesThread();
            }
                

            
        }
        private void AddGamesThread()
        {
            if (fromScanGames.Count > 0)
            {
                game_dld = true;
                this.button_New_Click(this, null);
                this.textBox_Title.Text = (String)fromScanGames[0];
                this.pobierzDaneZInternetuToolStripMenuItem_Click(this, null);
                fromScanGames.Remove(fromScanGames[0]);

            }
            else
            {
                game_dld = false;
                MessageBox.Show("Gry zostały zaimportowane z zewnetrznych źródeł.", "MK Games Catalogue NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Update_GamesList()
        {
            this.listView_GamesList.Items.Clear();
            Array.Resize(ref pos_arr, 0);
            for (Int32 i = 0; i < graBindingSource.Count; i++)
            {
                
                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[i].Tytul);
                lv_itm.SubItems.Add(defaultDataSet.Gra[i].Gatunek);
                lv_itm.SubItems.Add(defaultDataSet.Gra[i].Premiera);
                

                this.listView_GamesList.Items.Add(lv_itm);
                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                pos_arr[pos_arr.GetUpperBound(0)] = i;    
            }

        }

        private void listView_GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_GamesList.Items.Count > 0)
            {
                Int32 curNum = 0, curSel = 0;
                ListView.SelectedIndexCollection LV_SEL = listView_GamesList.SelectedIndices;
                foreach (Int32 ITM in LV_SEL)
                {

                    curSel = ITM;
                }


                curNum = curSel;


                MK_Games_Catalogue_NET.Form1.s_pos = pos_arr[curNum];
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                frm1.GetWyszIDX();

            }
        }

       
           

        
    }
    public class SETT_REC // ustawienia profilu - w lokalizacji profili - po jednym na profil
    {
        public static bool enabled_au;
        public static int days_to_au;
        public static int lang_path; // 500 znaków
        public static bool ask_on_exit;
        public static bool save_on_exit;
       
    }
    
}
