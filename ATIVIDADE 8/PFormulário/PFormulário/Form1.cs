using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFormulário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2();
            novoForm.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList()
            {
              "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            alunos.Remove("Otávio");
            string auxiliar = string.Join("\n", alunos.ToArray());

            MessageBox.Show(auxiliar);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 novoForm = new Form4();
            novoForm.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form5 novoForm = new Form5();
            novoForm.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form6 novoForm = new Form6();
            novoForm.Show();
        }
    }
}
