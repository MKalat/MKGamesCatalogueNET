using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MK_Games_Catalogue_NET
{
    public partial class Wyszukaj : Form
    {
        public Wyszukaj()
        {
            InitializeComponent();
            graTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            modsTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            dodatkiTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            graTableAdapter.Connection.Open();
            modsTableAdapter.Connection.Open();
            dodatkiTableAdapter.Connection.Open();
        }
        Int32[] pos_arr = new Int32[1]; 
        
        private void button_Szukaj_Click(object sender, EventArgs e)
        {
            this.listView_Wyniki.Items.Clear();

            graTableAdapter.Fill(defaultDataSet.Gra);
            modsTableAdapter.Fill(defaultDataSet.Mods);
            dodatkiTableAdapter.Fill(defaultDataSet.Dodatki);

            Array.Resize(ref pos_arr, 0);
            if (graBindingSource.Count > 0)
            {
                switch (this.comboBox_SzPole.SelectedIndex)
                {
                    case 0: // tytul
                        for (Int32 i = 0; i < graBindingSource.Count ; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Tytul.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;    
                            }
                        }

                        break;
                    case 1: //gatunek
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Gatunek.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 2: // producent
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Producent.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 3: //wydawca
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Wydawca.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 4: //dystrybutor
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Dystrybutor.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 5: //platforma
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Platforma.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 6: //cena
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Cena.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 7: //www
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].WWW.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 8: //nośnik
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Nosnik.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 9: //premiera
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Premiera.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 10: //ocena
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Ocena.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                               
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 11: //opis
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Opis.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 12: //min spec
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].MinSpec.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 13: //max spec
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].MaxSpec.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 14: //kody
                        for (Int32 i = 0; i < graBindingSource.Count; i++)
                        {
                            graBindingSource.Position = i;
                            if (defaultDataSet.Gra[graBindingSource.Position].Kody.Contains(this.textBox_SzFraza.Text))
                            {
                                ListViewItem lv_itm = new ListViewItem(defaultDataSet.Gra[graBindingSource.Position].Tytul);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Premiera);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Producent);
                                lv_itm.SubItems.Add(defaultDataSet.Gra[graBindingSource.Position].Gatunek);
                                
                                this.listView_Wyniki.Items.Add(lv_itm);
                                Array.Resize(ref pos_arr, pos_arr.Length + 1);
                                pos_arr[pos_arr.GetUpperBound(0)] = i;   
                            }
                        }
                        break;
                    case 15: //dod nazwa

                        break;
                    case 16: //dod cena

                        break;
                    case 17: //dod www

                        break;
                    case 18: //dod multi

                        break;
                    case 19: //dod single

                        break;
                    case 20: //mod nazwa

                        break;
                    case 21: // mod wersja moda

                        break;
                    case 22: // mod wersja gry

                        break;
                    case 23: //mod ocena

                        break;
                    case 24: //dod ocena

                        break;
                    default:
                        break;
                }
            }
        }

        private void listView_Wyniki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Wyniki.Items.Count > 0)
            {
                Int32 curNum = 0, curSel =0;
                ListView.SelectedIndexCollection LV_SEL = listView_Wyniki.SelectedIndices;
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
}
