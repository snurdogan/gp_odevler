using System;
using System.Windows.Forms;

namespace Multiple_Forms
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();


        }


        private void çIKIŞYAPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 cıkısyap = new Form1();
            cıkısyap.Show();
            this.Close();

        }


        private void bilgilendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Bilgilendirme 2022-2023 Güz Döneminde 8 Adet Onaylanmış ders kaydınız mevcut.";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void dersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void genelİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
