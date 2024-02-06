using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metot_Gişe
{
    public partial class Form1 : Form
    {

        Queue<string> musteri = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void musteriCagir(Label lbl)
        {
            if(musteri.Count > 0)
            {
                 lbl.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("YOK");
            }
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("RAVZA");
            musteri.Enqueue("YEZDA");
            musteri.Enqueue("NURSEVİM");
            musteri.Enqueue("HİLAL");

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtİsim.Text);
        }

        private void btnGetir1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGetir1);
        }

        private void btnGetir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGetir2);
        }

        private void btnGetir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGetir3);
        }
    }
}
