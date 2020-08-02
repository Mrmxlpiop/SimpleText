using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using SimpleText;
using Microsoft.VisualBasic;
using System.Net;

namespace SimpleTextOpener
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        SaveFileDialog SaveFileDialog2 = new SaveFileDialog();
        FontDialog fontDialog1 = new FontDialog();
        ColorDialog colorDialog1 = new ColorDialog();
        string FS;
        bool Dark = false;
        bool SaveBut = false;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FS = File.ReadAllText(openFileDialog1.FileName);
            rtxtFile.Text = FS;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (SaveBut)
            {
                rtxtFile.Clear();
                FS = "";
                SaveBut = false;

            }
            else
            {
                if (rtxtFile.Text != "" )
                {
                    string Mesa = "Do You Want To Save ?";
                    string Tit = "Save";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(Mesa, Tit, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        saveFileDialog1.ShowDialog();
                        if (saveFileDialog1.FileName != "")
                        {
                            File.WriteAllText(saveFileDialog1.FileName, rtxtFile.Text);
                        }
                         rtxtFile.Clear();
                         FS = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        rtxtFile.Clear();
                        FS = "";
                    }
                else if (result == DialogResult.Cancel) ;
            }
 
   
        }
              
    }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveBut)
            {
                string message = "You Can't Save An Web File";
                MessageBox.Show(message);
            }
            else
            {
                bool Er1 = false;
                string Loca = openFileDialog1.FileName;
                if (Loca == "")
                {
                    SaveFileDialog2.ShowDialog();
                    if (SaveFileDialog2.FileName != "")
                    {
                        File.WriteAllText(SaveFileDialog2.FileName, rtxtFile.Text);
                    }
                    else
                        Er1 = true;

                }
                if (Er1 == false)
                {
                    File.WriteAllText(Loca, rtxtFile.Text);
                }
            }

           
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            if (Dark == false)
            {
                 this.BackColor = SystemColors.ActiveCaptionText;
                rtxtFile.BackColor = SystemColors.ActiveCaptionText;
                rtxtFile.ForeColor = SystemColors.ControlLightLight;
                menuStrip1.BackColor = SystemColors.ActiveCaptionText;
                menuStrip1.ForeColor = SystemColors.Control;
                fileToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                fileToolStripMenuItem.ForeColor = SystemColors.Control;
                viewToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                viewToolStripMenuItem.ForeColor = SystemColors.Control;
                New.BackColor = SystemColors.ActiveCaptionText;
                New.ForeColor = SystemColors.Control;
                Open.BackColor = SystemColors.ActiveCaptionText;
                Open.ForeColor = SystemColors.Control;
                saveToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                saveToolStripMenuItem.ForeColor = SystemColors.Control;
                saveAsToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                saveAsToolStripMenuItem.ForeColor = SystemColors.Control;
                fontToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                fontToolStripMenuItem.ForeColor = SystemColors.Control;
                darkModeToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                darkModeToolStripMenuItem.ForeColor = SystemColors.Control;
                helpToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                helpToolStripMenuItem.ForeColor = SystemColors.Control;
                colorToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                colorToolStripMenuItem.ForeColor = SystemColors.Control;
                aboutToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                aboutToolStripMenuItem.ForeColor = SystemColors.Control;
                webToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
                webToolStripMenuItem.ForeColor = SystemColors.Control;
                Dark = true;
                darkModeToolStripMenuItem.Text = "Light Mode";
            }
            else
            {
                this.BackColor = SystemColors.Control;
                rtxtFile.BackColor = SystemColors.Window;
                rtxtFile.ForeColor = SystemColors.ControlText;
                menuStrip1.BackColor = SystemColors.Control;
                menuStrip1.ForeColor = SystemColors.ControlText;
                fileToolStripMenuItem.BackColor = SystemColors.Control;
                fileToolStripMenuItem.ForeColor = SystemColors.ControlText;
                viewToolStripMenuItem.BackColor = SystemColors.Control;
                viewToolStripMenuItem.ForeColor = SystemColors.ControlText;
                New.BackColor = SystemColors.Control;
                New.ForeColor = SystemColors.ControlText;
                Open.BackColor = SystemColors.Control;
                Open.ForeColor = SystemColors.ControlText;
                saveToolStripMenuItem.BackColor = SystemColors.Control;
                saveToolStripMenuItem.ForeColor = SystemColors.ControlText;
                saveAsToolStripMenuItem.BackColor = SystemColors.Control;
                saveAsToolStripMenuItem.ForeColor = SystemColors.ControlText;
                fontToolStripMenuItem.BackColor = SystemColors.Control;
                fontToolStripMenuItem.ForeColor = SystemColors.ControlText;
                darkModeToolStripMenuItem.BackColor = SystemColors.Control;
                darkModeToolStripMenuItem.ForeColor = SystemColors.ControlText;
                helpToolStripMenuItem.BackColor = SystemColors.Control;
                helpToolStripMenuItem.ForeColor = SystemColors.ControlText;
                colorToolStripMenuItem.BackColor = SystemColors.Control;
                colorToolStripMenuItem.ForeColor = SystemColors.ControlText;
                aboutToolStripMenuItem.BackColor = SystemColors.Control;
                aboutToolStripMenuItem.ForeColor = SystemColors.ControlText;
                webToolStripMenuItem.BackColor = SystemColors.Control;
                webToolStripMenuItem.ForeColor = SystemColors.ControlText;
                Dark = false;
                darkModeToolStripMenuItem.Text = "Dark Mode";
            }

        }


        private void btnSavas_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, rtxtFile.Text);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxtFile.SelectionFont = fontDialog1.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtxtFile.SelectionColor = colorDialog1.Color;
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();
            testDialog.ShowDialog();
            while (true)
            {
                if (testDialog.Word != "")
                {
                    rtxtFile.Text = testDialog.Word;
                    SaveBut = true;
                    break;
                }
            }

 


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtFile.SelectAll();
        }

    }
    
}

