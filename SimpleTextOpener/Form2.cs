using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using SimpleTextOpener;

namespace SimpleText
{
    public partial class Form2 : Form
    {
        public string addr { get; set; }
        public bool Read { get; set; }
        public string Word { get; set; } 

        public Form2()
        {
            InitializeComponent();
        }  
        public class Do
        {
            public string addr;
        }

        private void btnWebOpen_Click(object sender, EventArgs e)
        {
            addr = txtDirW.Text;
            Read = false;
            Word = "";
            WebClient webClient = new WebClient();
            Stream Webstream = webClient.OpenRead(addr);
            StreamReader reader = new StreamReader(Webstream);
            Word = reader.ReadToEnd();
            Webstream.Close();
            this.Close();

        }

    }
}
