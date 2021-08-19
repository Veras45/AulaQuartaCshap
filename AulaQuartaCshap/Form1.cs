using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaQuartaCshap
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

        private void btExe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola " + txtBox.Text + ", Sinta-se acolhido(a)! :))) ");
            btsaida.Text = txtBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            btlimpa.Text = " ";
            btsaida.Text = " ";

        }

         }
}
