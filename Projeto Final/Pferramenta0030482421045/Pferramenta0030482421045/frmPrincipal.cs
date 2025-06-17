using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pferramenta0030482421045
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=APOLO;Initial Catalog=LP2;Persist Security Info=True;User ID=BD2421043;Password = EA_2105fcia");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados = /" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros = /" + ex.Message);
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCategoria>().Count() > 0)
            {
                Application.OpenForms["frmCategoria"].BringToFront();
            }
            else
            {
                frmCategoria FrmCategoria = new frmCategoria();
                FrmCategoria.MdiParent = this;
                FrmCategoria.WindowState = FormWindowState.Maximized;
                FrmCategoria.Show();
            }

        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFabricante>().Count() > 0)
            {
                Application.OpenForms["frmFabricante"].BringToFront();
            }
            else
            {
                frmFabricante frmFabricante = new frmFabricante();
                frmFabricante.MdiParent = this;
                frmFabricante.WindowState = FormWindowState.Maximized;
                frmFabricante.Show();
            }
        }

        private void ferramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFerramenta>().Count() > 0)
            {
                Application.OpenForms["frmFerramenta"].BringToFront();
            }
            else
            {
                frmFerramenta FrmFerramenta = new frmFerramenta();
                FrmFerramenta.MdiParent = this;
                FrmFerramenta.WindowState = FormWindowState.Maximized;
                FrmFerramenta.Show();
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms["frmSobre"].BringToFront();
            }
            else
            {
                frmSobre FrmSobre = new frmSobre();
                FrmSobre.MdiParent = this;
                FrmSobre.WindowState = FormWindowState.Maximized;
                FrmSobre.Show();
            }
        }
    }
}