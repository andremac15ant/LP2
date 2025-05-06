using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFormulário
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList()
            {
              "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            alunos.Remove("Otávio");
            string auxiliar = string.Join("\n", alunos.ToArray());
            
             MessageBox.Show(auxiliar); 
            
        }
    }
}
