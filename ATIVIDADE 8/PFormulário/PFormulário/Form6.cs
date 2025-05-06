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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            int N = 3; // exemplo: RA termina em 2 → 2 + 1 = 3 (ajuste conforme necessário)
            char[] gabarito = { 'A', 'B', 'C', 'D', 'E', 'A', 'B', 'C', 'D', 'E' };
            char[,] respostas = new char[N, 10];

            for (int aluno = 0; aluno < N; aluno++)
            {
                for (int questao = 0; questao < 10; questao++)
                {
                    bool valida = false;
                    while (!valida)
                    {
                        string entrada = Interaction.InputBox($"Aluno {aluno + 1} - Questão {questao + 1} (A/B/C/D/E):", "Resposta");

                        if (!string.IsNullOrWhiteSpace(entrada))
                        {
                            char resp = Char.ToUpper(entrada[0]);
                            if ("ABCDE".Contains(resp))
                            {
                                respostas[aluno, questao] = resp;
                                valida = true;
                            }
                            else
                            {
                                MessageBox.Show("Digite apenas A, B, C, D ou E.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Resposta inválida.");
                        }
                    }
                }
            }

            listBox1.Items.Clear();

            for (int aluno = 0; aluno < N; aluno++)
            {
                int acertos = 0;
                for (int questao = 0; questao < 10; questao++)
                {
                    if (respostas[aluno, questao] == gabarito[questao])
                        acertos++;
                }

                listBox1.Items.Add($"Aluno {aluno + 1}: {acertos} acertos");
            }
        }
    }
}