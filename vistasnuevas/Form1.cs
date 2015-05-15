using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistasnuevas
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

        private void button3_Click(object sender, EventArgs e)
        {
            EventoCelebraciones celebracion = new EventoCelebraciones();
            celebracion.Show();
            this.Hide();
      

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventosReunion reunion = new EventosReunion();
            reunion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventoBautizo bautizo = new EventoBautizo();
            bautizo.Show();
            this.Hide();
        }
    }
}
