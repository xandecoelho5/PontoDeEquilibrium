using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeEquilibrio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEmpresas().Show();
        }

        private void DadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDados().Show();
        }

        private void ResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //new FormResultados().Show();
        }

        private void seletorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSelector().ShowDialog();
        }
    }
}
