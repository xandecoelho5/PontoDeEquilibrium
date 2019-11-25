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
    public partial class FormDados : Form
    {
        public FormDados()
        {
            InitializeComponent();
        }

        private void SimulacoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.simulacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);

        }

        private void FormDados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Simulacoes'. Você pode movê-la ou removê-la conforme necessário.
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadSimulacoes(this);
            form.Novo();
        }
    }
}
