using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menuk_12B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void újDokumentumToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (szoveg.Text != string.Empty)
            {
                DialogResult figyelmeztetes = MessageBox.Show("Az ablak nem üres!\n\n Biztos törli?",
                    "Kérdés",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (figyelmeztetes == DialogResult.OK)
                {
                    szoveg.Clear();
                }
            }
           
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kilepes = MessageBox.Show("Biztosan kilép?",
    "Üzenet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kilepes == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader olvas = new System.IO.StreamReader(opf.FileName);
                szoveg.Text = olvas.ReadToEnd();
                olvas.Close();
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (szoveg.Text != string.Empty)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Egyszerű szöveg (*.txt |*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter iras = new System.IO.StreamWriter(sfd.FileName);
                    iras.Write(szoveg.Text);
                    iras.Flush();
                    iras.Close();
                }
            }
            else 
            {
                MessageBox.Show("figyeljé má oda te kutya");
            }
            
        }

        private void visszavonásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Undo();
        }

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Cut();
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Copy();
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Paste();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.SelectedText= "";
        }

        private void azÖsszesKijelölésaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.SelectAll();
        }

        private void időDátumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.SelectionLength = 0;
            szoveg.SelectedText = DateTime.Now.ToString("F") + " ";
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA CSICSKAAACASFAAAAAAAAAAAAAAAAAAAAAAAA \n AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Karekterek száma:" + szoveg.Text.Length;
        }

        private void szoveg_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Karekterek száma:" + szoveg.Text.Length;
        }

        private void szoveg_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Karekterek száma:" + szoveg.Text.Length;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var kilep2 = MessageBox.Show("Biztosan kilep?","Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kilep2 == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void másolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Copy();
        }

        private void beillesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szoveg.Paste();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void súgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
