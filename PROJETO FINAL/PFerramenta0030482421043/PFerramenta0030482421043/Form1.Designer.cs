namespace PFerramenta0030482421043
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lP2DataSet = new PFerramenta0030482421043.LP2DataSet();
            this.lP2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lP2DataSet1 = new PFerramenta0030482421043.LP2DataSet1();
            this.lP2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet2 = new PFerramenta0030482421043.LP2DataSet2();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIATableAdapter = new PFerramenta0030482421043.LP2DataSet2TableAdapters.CATEGORIATableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lP2DataSetBindingSource
            // 
            this.lP2DataSetBindingSource.DataSource = this.lP2DataSet;
            this.lP2DataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 150);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cATEGORIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lP2DataSet1BindingSource
            // 
            this.lP2DataSet1BindingSource.DataSource = this.lP2DataSet1;
            this.lP2DataSet1BindingSource.Position = 0;
            // 
            // lP2DataSet2
            // 
            this.lP2DataSet2.DataSetName = "LP2DataSet2";
            this.lP2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.lP2DataSet2;
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lP2DataSetBindingSource;
        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lP2DataSet1BindingSource;
        private LP2DataSet1 lP2DataSet1;
        private LP2DataSet2 lP2DataSet2;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private LP2DataSet2TableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
    }
}

