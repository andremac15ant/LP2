using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PFormulário
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            for (int i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i + 1} número", "Entrada de Dados");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }
            Array.Reverse(vetor);
            auxiliar = "";
            foreach (int x in vetor)
            {
                auxiliar += x + "\n";
            }
            MessageBox.Show(auxiliar);
        }
    }
}