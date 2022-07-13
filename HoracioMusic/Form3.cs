using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoracioMusic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();

        }// fim botao 4

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Todas_Mídias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        WMPLib.IWMPPlaylist playList;

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Abrir Mídia";
            ofd.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            if(ofd.ShowDialog() == DialogResult.OK)
            {

                

            }

        }// Fim botao abrir

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }
    }// fim class

}// fim projeto
