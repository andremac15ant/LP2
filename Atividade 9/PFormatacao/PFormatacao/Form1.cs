using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFormatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo  = DateTime.Now;
            MessageBox.Show(dataExemplo.ToString(""));
            MessageBox.Show(dataExemplo.ToString("d"));
            MessageBox.Show(dataExemplo.ToString("D"));
            MessageBox.Show(dataExemplo.ToString("dd/MM/yyyy"));
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casas decimais " + valor.ToString("C3"));
            MessageBox.Show("Fixo 2 casas decimais " + valor.ToString("F2"));
            MessageBox.Show("Número 2 casas decimais " + valor.ToString("N2"));
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo = DateTime.Now;
            MessageBox.Show("ToShortDAteString: " + dataExemplo.ToShortDateString());
            MessageBox.Show("ToShortTimeString: " + dataExemplo.ToShortTimeString());
            MessageBox.Show("ToLongDateString: " + dataExemplo.ToLongDateString());
            MessageBox.Show("ToLongTimeString: " + dataExemplo.ToLongTimeString());

        }

        private void btnFormatData_Click(object sender, EventArgs e)
        {
            string dataHoje = String.Format("Hoje é {0:d} às {0:t}", DateTime.Now);

            MessageBox.Show(dataHoje);
        }

        private void btnFormatValor_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casa decimais " + String.Format("{0:C3}", valor));
            MessageBox.Show("Fixo 2 casa decimais " + String.Format("{0:F2}", valor));
            MessageBox.Show("Número 2 casa decimais " + String.Format("{0:N2}", valor));
        }

        private void btnOperação_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MessageBox.Show("Soma 2 dias: " + dt.AddDays(2).ToShortDateString());
            MessageBox.Show("Soma 2 horas: " + dt.AddDays(2).ToLongTimeString());
            MessageBox.Show("Dia da Semana: " + dt.DayOfWeek.ToString());
            MessageBox.Show("Dias no mês 2/2000: " + DateTime.DaysInMonth(2000, 2));

            DateTime dt2 = Convert.ToDateTime("01/02/2023");
            DateTime dt1 = Convert.ToDateTime("06/05/2025");
            double dias = dt1.Subtract(dt2).TotalDays;
            MessageBox.Show("Diferença entre hoje e 01/02/2023 " + dias);
            //Para saber se é bissexto:

            if (DateTime.IsLeapYear(2024))
            {
                MessageBox.Show("É bissexto");
            }
            else
            {
                MessageBox.Show("Não é bissexto");
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dtEscolhida = monthCalendar1.SelectionStart;

            MessageBox.Show(dtEscolhida.ToString("d"));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtEscolhida = dateTimePicker1.Value;
            MessageBox.Show(dtEscolhida.ToString("d"));
        }
    }
}
