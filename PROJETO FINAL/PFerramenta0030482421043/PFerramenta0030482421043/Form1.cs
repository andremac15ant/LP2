using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFerramenta0030482421043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cATEGORIATableAdapter.Update(this.lP2DataSet2.CATEGORIA);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet2.CATEGORIA'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIATableAdapter.Fill(this.lP2DataSet2.CATEGORIA);

        }
    }
}
