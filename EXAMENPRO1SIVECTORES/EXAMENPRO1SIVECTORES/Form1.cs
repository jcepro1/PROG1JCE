using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENPRO1SIVECTORES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        vector v1, v2, v3;
        nent n1, n2, n3;

 
        private void cARGARRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.descargar();
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.descargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new vector();
            v2 = new vector();
            v3 = new vector();
            n1 = new nent();
            n2 = new nent();
            n3 = new nent();
        }

        //PREGUNTA 2
        private void pREGUNTA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text =string.Concat(v1.pregunta2(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            //textBox7.Text = v2.descargar();
            //textBox8.Text = v3.descargar();

        }

    }
}
