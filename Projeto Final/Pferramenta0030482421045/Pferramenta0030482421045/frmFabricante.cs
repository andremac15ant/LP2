using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferramenta0030482421045
{
    public partial class frmFabricante : Form
    {
        private BindingSource bnFabricante = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsFabricante = new DataSet();
        public frmFabricante()
        {
            InitializeComponent();
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            try
            {
                Fabricante regCat = new Fabricante();
                dsFabricante.Tables.Add(regCat.listar());
                bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                dgvFabricante.DataSource = bnFabricante;
                bnvFabricante.BindingSource = bnFabricante;

                txtId.DataBindings.Add("TEXT", bnFabricante, "id");
                txtNome.DataBindings.Add("TEXT", bnFabricante, "nomeFantasia");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnvFabricante_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            bnFabricante.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (txtNome.Text.Replace(" ", "").Length < 2))
            {
                MessageBox.Show("Fabricante Inválido");
            }
            else
            {
                Fabricante RegCat = new Fabricante();

                RegCat.IdFabricante = Convert.ToInt16(txtId.Text);
                RegCat.NomeFantasia = txtNome.Text;


                if (bInclusao)
                {
                    if (RegCat.Salvar() > 0)
                    {
                        MessageBox.Show("Fabricante adicionado com sucesso!");

                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;


                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegCat.listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar fabricante!");
                    }

                }
                else
                {
                    if (RegCat.Alterar() > 0)
                    {
                        MessageBox.Show("Categoria alterada com sucesso!");

                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegCat.listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                    }
                }
            }       
    }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

      
            txtNome.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFabricante.CancelEdit();

            txtNome.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        
    }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Fabricante RegFabricante = new Fabricante();
                RegFabricante.IdFabricante = Convert.ToInt16(txtId.Text);

                if (RegFabricante.excluir() > 0)
                {
                    MessageBox.Show("Fabricante excluido com sucesso");

                    Fabricante R = new Fabricante();
                    dsFabricante.Tables.Clear();
                    dsFabricante.Tables.Add(R.listar());
                    bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir fabricante!");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close ();
        }
    }
    }
