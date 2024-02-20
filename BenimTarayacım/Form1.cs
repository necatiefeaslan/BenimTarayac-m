using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimTarayacım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAdres.Text);
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelgecmış.Visible) panelgecmış.Visible = false;
            else panelgecmış.Visible=true;
            
 
             

        }
    }
}
