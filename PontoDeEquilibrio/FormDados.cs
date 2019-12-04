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
        private void AtualizarGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Simulacoes'. Você pode movê-la ou removê-la conforme necessário.
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);
        }
        private void FormDados_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadSimulacoes(this);
            form.Novo();
        }

        // atualizar campos conforme nova edição (alterando os campos em tela, o grid deve ser atualizado)
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (simulacoesDataGridView.CurrentRow != null)
            {
                var registro = simulacoesDataGridView.CurrentRow;

                if (MessageBox.Show("Deseja excluir esta simulação?", "Atenção",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var adp = new PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter();
                    adp.DeleteQuery(int.Parse(registro.Cells[0].Value.ToString()));
                    simulacoesBindingSource.Position = simulacoesDataGridView.CurrentCell.RowIndex;
                    simulacoesBindingSource.Remove(simulacoesBindingSource.Current);
                }
            }
        }
        private void simulacoesBindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            var index = simulacoesDataGridView.CurrentCell.RowIndex;
            var form = new CadSimulacoes(this, index);
            form.ShowDialog();
            AtualizarGrid();
        }
    }
}
