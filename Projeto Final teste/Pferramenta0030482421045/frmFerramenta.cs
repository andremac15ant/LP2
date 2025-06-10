using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferramenta0030482421045
{
    public partial class frmFerramenta : Form
    {
        private BindingSource bnFerramenta = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsFerramenta = new DataSet();
        private DataSet dsCategoria = new DataSet();
        private DataSet dsFabricante = new DataSet();
        public frmFerramenta()
        {
            InitializeComponent();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }
            bnFerramenta.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            txtSiteOficial.Enabled = true;
            cbDistribuicao.Enabled = true;
            dtpCadastro.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxFabricante.Enabled = true;

            cbxCategoria.SelectedIndex = 0;
            cbxFabricante.SelectedIndex = 0;
            cbDistribuicao.SelectedIndex = 0;

            btnNovoRegistro.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (txtNome.Text.Replace(" ", "").Length < 1))
            {
                MessageBox.Show("Nome inválido");
            }
            else if (cbDistribuicao.SelectedIndex == -1)
            {
                MessageBox.Show("Distribuição inválida");
            }
            else if (txtSiteOficial.Text.Replace(" ", "").Length < 8)
            {
                MessageBox.Show("SIte oficial Inválido");
            }
            else if (Convert.ToDateTime(dtpCadastro.Value) < DateTime.Today)
            {
                MessageBox.Show("Data Inválida");
            }
            else if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Categoria inválida!");
            }
            else if (cbxFabricante.SelectedIndex == -1)
                MessageBox.Show("Fabricante Inválido!");
            else
                Ferramenta RegFerr = new Ferramenta();
            RegFerr.Nome = txtNome.Text;
            RegFerr.Distribuicao = Convert.ToChar(cbDistribuicao.SelectedItem);
            RegFerr.DtCadastro = dtpCadastro.Value;
            RegFerr.SiteOficial = txtSiteOficial.Text;
            RegFerr.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
            RegFerr.IdFabricante = Convert.ToInt32(cbxFabricante.SelectedValue.ToString());

            if (bInclusao)
            { MessageBox.Show("Ferramenta adicionada com sucesso");

                txtNome.Enabled = false;
                txtSiteOficial.Enabled = false;
                cbDistribuicao.Enabled = false;
                dtpCadastro.Enabled = false;
                cbxCategoria.Enabled = false;
                cbxFabricante.Enabled = false;


                btnNovoRegistro.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                bInclusao = false;

                dsFerramenta.Tables.Clear();
                dsFerramenta.Tables.Add(RegFerr.Listen());
                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
            }
            else
            {
                MessageBox.Show("Erro ao Gravar Ferramenta!");
            }
        } 
        else 
        {
        RegFerr.IdFerramenta = Convert.ToInt32(txtIdFerramenta.Text);

            if (RegFerr.Alterar() > 0)
            {

            MessageBox.Show("Ferramenta alterada com sucesso!");
            

            txtNome.Enabled = false;
                txtSiteOficial.Enabled = false;
                cbDistribuicao.Enabled = false;
                dtpCadastro.Enabled = false;
                cbxCategoria.Enabled = false;
                cbxFabricante.Enabled = false;


                btnNovoRegistro.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                bInclusao = false;

                dsFerramenta.Tables.Clear();
                dsFerramenta.Tables.Add(RegFerr.Listen());
                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
            }
       


        

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoRegistro_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dtCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmFerramenta_Load(object sender, EventArgs e)
        {
            try
            {
                Ferramenta RegFerr = new Ferramenta();
                dsFerramenta.Tables.Add(RegFerr.listar());
                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                dgvFerramenta.DataSource = bnFerramenta;
                bnvFerramenta.BindingSource = bnFerramenta;

                txtId.DataBindings.Add("TEXT", bnFerramenta, "id");
                txtNome.DataBindings.Add("TEXT", bnFerramenta, "nome");
                cbDistribuicao.DataBindings.Add("TEXT", bnFerramenta, "descricao");
                dtpCadastro.DataBindings.Add("TEXT", bnFerramenta, "dtcadastro");
                txtSiteOficial.DataBindings.Add("TEXT", bnFerramenta, "siteoficial");

                Categoria RegCat = new Categoria();
                dsCategoria.Tables.Add(RegCat.listar());
                cbxCategoria.DataSource = dsCategoria.Tables["Categoria"];
                cbxCategoria.DisplayMember = "descricao";
                cbxCategoria.ValueMember = "id";
                cbxCategoria.DataBindings.Add("SelectedValue", bnFerramenta, "idCategoria");

                Fabricante Regfab = new Fabricante();
                dsFabricante.Tables.Add(RegCat.listar());
                cbxFabricante.DataSource = dsCategoria.Tables["Fabricante"];
                cbxFabricante.DisplayMember = "nomefantasia";
                cbxFabricante.ValueMember = "id";
                cbxFabricante.DataBindings.Add("SelectedValue", bnFerramenta, "idFabricante");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
