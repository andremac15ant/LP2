using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferramenta0030482421045
{
    public partial class frmCategoria : Form
    {
        private BindingSource bnCategoria = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCategoria = new DataSet();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                Categoria regCat = new Categoria();
                dsCategoria.Tables.Add(regCat.listar());
                bnCategoria.DataSource = dsCategoria.Tables["CATEGORIA"];
                dgvCategoria.DataSource = bnCategoria;
                bnvCategoria.BindingSource = bnCategoria;

                txtId.DataBindings.Add("TEXT", bnCategoria, "id");
                txtDescricao.DataBindings.Add("TEXT", bnCategoria, "descricao");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbCategoria.SelectedIndex == 0)
            {
                tbCategoria.SelectTab(1);
            }

            bnCategoria.AddNew();
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || (txtDescricao.Text.Replace(" ", "").Length < 5))
            {
                MessageBox.Show("Categoria Inválida");
            }
            else
            {
                Categoria RegCat = new Categoria();

                RegCat.IdCategoria = Convert.ToInt16(txtId.Text);
                RegCat.Descricao = txtDescricao.Text;


                if (bInclusao)
                {
                    if (RegCat.Salvar() > 0)
                    {
                        MessageBox.Show("Categoria adicionada com sucesso!");

                        txtId.Enabled = false;
                        txtDescricao.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsCategoria.Tables.Clear();
                        dsCategoria.Tables.Add(RegCat.listar());
                        bnCategoria.DataSource = dsCategoria.Tables["CATEGORIA"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar categoria!");
                    }

                }
                else
                {
                    if (RegCat.Alterar() > 0)
                    {
                        MessageBox.Show("Categoria alterada com sucesso!");

                        txtId.Enabled = false;
                        txtDescricao.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsCategoria.Tables.Clear();
                        dsCategoria.Tables.Add(RegCat.listar());
                        bnCategoria.DataSource = dsCategoria.Tables["CATEGORIA"];
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCategoria.SelectedIndex == 0)
            {
                tbCategoria.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Categoria RegCat = new Categoria();
                RegCat.IdCategoria = Convert.ToInt16(txtId.Text);

                if (RegCat.excluir() > 0)
                {
                    MessageBox.Show("Categoria excluida com sucesso");

                    Categoria R = new Categoria();
                    dsCategoria.Tables.Clear();
                    dsCategoria.Tables.Add(R.listar());
                    bnCategoria.DataSource = dsCategoria.Tables["CATEGORIA"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir categoria!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCategoria.SelectedIndex == 0)
            {
                tbCategoria.SelectTab(1);
            }

            txtDescricao.Focus();
            txtDescricao.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCategoria.CancelEdit();

            txtDescricao.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
