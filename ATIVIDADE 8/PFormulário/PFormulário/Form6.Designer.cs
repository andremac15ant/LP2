namespace PFormulário
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Location = new System.Drawing.Point(68, 66);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(199, 178);
            this.btnCorrigir.TabIndex = 0;
            this.btnCorrigir.Text = "button1";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(421, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 329);
            this.listBox1.TabIndex = 1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCorrigir);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.ListBox listBox1;
    }
}