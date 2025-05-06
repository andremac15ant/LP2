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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            string resultado = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bool notaValida = false;

                    while (!notaValida)
                    {
                        string entrada = Interaction.InputBox(
                            $"Digite a nota {j + 1} do aluno {i + 1} (0 a 10):",
                            "Entrada de Notas"
                        );

                        if (double.TryParse(entrada, out double nota) && nota >= 0 && nota <= 10)
                        {
                            notas[i, j] = nota;
                            notaValida = true;
                        }
                        else
                        {
                            MessageBox.Show("Nota inválida! Digite um número entre 0 e 10.");
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                double media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                resultado += "Aluno " + (i + 1) + ": média: " + media.ToString("F1") + "\n";
            }

            MessageBox.Show(resultado);
        }
    }
    }

