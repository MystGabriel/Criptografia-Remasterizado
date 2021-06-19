using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_Remasterizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void Encriptar_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                int txtUsuario = (int)textBox1.Text[i];
                int txtCifrado = txtUsuario + Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                textBox2.Text += Char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void Decriptar_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;

            for(int i = 0; i < textBox2.Text.Length; i++)
            {
                int txtCifrado = (int)textBox2.Text[i];
                int txtOriginal = txtCifrado - Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                textBox3.Text += Char.ConvertFromUtf32(txtOriginal);
            }
        }
    }
}
