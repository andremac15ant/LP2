namespace PFormatacao
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
            this.btnData = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFormatData = new System.Windows.Forms.Button();
            this.btnFormatValor = new System.Windows.Forms.Button();
            this.btnOperação = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(49, 56);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(140, 45);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "TOString - Datas";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(234, 56);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(140, 45);
            this.btnValores.TabIndex = 1;
            this.btnValores.Text = "TOString - Valores";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(416, 56);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(140, 45);
            this.btnMetodo.TabIndex = 2;
            this.btnMetodo.Text = "Método do Date Time";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFormatData
            // 
            this.btnFormatData.Location = new System.Drawing.Point(608, 56);
            this.btnFormatData.Name = "btnFormatData";
            this.btnFormatData.Size = new System.Drawing.Size(140, 45);
            this.btnFormatData.TabIndex = 3;
            this.btnFormatData.Text = "String.FORMAT - Datas ";
            this.btnFormatData.UseVisualStyleBackColor = true;
            this.btnFormatData.Click += new System.EventHandler(this.btnFormatData_Click);
            // 
            // btnFormatValor
            // 
            this.btnFormatValor.Location = new System.Drawing.Point(130, 137);
            this.btnFormatValor.Name = "btnFormatValor";
            this.btnFormatValor.Size = new System.Drawing.Size(140, 45);
            this.btnFormatValor.TabIndex = 4;
            this.btnFormatValor.Text = "String FORMAT - Valores";
            this.btnFormatValor.UseVisualStyleBackColor = true;
            this.btnFormatValor.Click += new System.EventHandler(this.btnFormatValor_Click);
            // 
            // btnOperação
            // 
            this.btnOperação.Location = new System.Drawing.Point(519, 137);
            this.btnOperação.Name = "btnOperação";
            this.btnOperação.Size = new System.Drawing.Size(140, 45);
            this.btnOperação.TabIndex = 5;
            this.btnOperação.Text = "Operção com Datas";
            this.btnOperação.UseVisualStyleBackColor = true;
            this.btnOperação.Click += new System.EventHandler(this.btnOperação_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(280, 194);
            this.monthCalendar1.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnOperação);
            this.Controls.Add(this.btnFormatValor);
            this.Controls.Add(this.btnFormatData);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.btnData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFormatData;
        private System.Windows.Forms.Button btnFormatValor;
        private System.Windows.Forms.Button btnOperação;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

