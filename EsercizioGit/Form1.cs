using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioGit
{

    public partial class Form1 : Form
    {
        int[] V = new int[10];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void lbMinimo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bGeneraArray_Click(object sender, EventArgs e)
        {
            for (int i=0; i < 10; i++)
            {
                V[i] = r.Next(50);
            }
            txtb1.Text = V[0].ToString();
            txtb2.Text = V[1].ToString();
            txtb3.Text = V[2].ToString();
            txtb4.Text = V[3].ToString();
            txtb5.Text = V[4].ToString();
            txtb6.Text = V[5].ToString();
            txtb7.Text = V[6].ToString();
            txtb8.Text = V[7].ToString();
            txtb9.Text = V[8].ToString();
            txtb10.Text = V[9].ToString();
            txtbMassimo.Text = "";
            txtbMinimo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbMassimo.Text = V.Max().ToString();
            txtbMinimo.Text = V.Min().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bOrdinamento_Click(object sender, EventArgs e)
        {
            Array.Sort(V);
            txtb1.Text = V[0].ToString();
            txtb2.Text = V[1].ToString();
            txtb3.Text = V[2].ToString();
            txtb4.Text = V[3].ToString();
            txtb5.Text = V[4].ToString();
            txtb6.Text = V[5].ToString();
            txtb7.Text = V[6].ToString();
            txtb8.Text = V[7].ToString();
            txtb9.Text = V[8].ToString();
            txtb10.Text = V[9].ToString();
        }
    }
}
