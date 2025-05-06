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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] tamanhos = new int[10];

            for (int i = 0; i < 10; i++)
            {
                bool nomeValido = false;

                while (!nomeValido)
                {
                    string entrada = Interaction.InputBox($"Digite o nome completo da pessoa {i + 1}:", "Entrada de Nome");

                    if (!string.IsNullOrWhiteSpace(entrada))
                    {
                        nomes[i] = entrada;
                        tamanhos[i] = entrada.Replace(" ", "").Length;
                        nomeValido = true;
                    }
                    else
                    {
                        MessageBox.Show("O nome não pode estar em branco ou ser apenas espaços!", "Erro");
                    }
                }
            }

            listBox1.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add($"o nome: {nomes[i]} tem {tamanhos[i]} caracteres");
            }
        }
    }
}

