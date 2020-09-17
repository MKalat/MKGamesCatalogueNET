using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MK_Games_Catalogue_NET
{
    public partial class HelpWiz : Form
    {
        public HelpWiz()
        {
            InitializeComponent();
        }

        private void HelpWiz_Load(object sender, EventArgs e)
        {
            this.webBrowser_Help.Navigate("http://mkalat.pl/free/articles.php?article_id=18");
        }
    }
}
