using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNEKERS
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();

       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void PanelCambio(object formpieza)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = formpieza as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void btnarrelgo_Click(object sender, EventArgs e)
        {
            PanelCambio(new arreglosForms());
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            PanelCambio(new listasForm());

        }

        private void butnpila_Click(object sender, EventArgs e)
        {
            PanelCambio(new pilaForm());
        }

        private void btncola_Click(object sender, EventArgs e)
        {
            PanelCambio(new colaForm());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            PanelCambio(new Form1());
        }
   
    }
}
