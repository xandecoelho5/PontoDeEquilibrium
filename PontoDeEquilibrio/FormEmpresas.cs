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
    public partial class FormEmpresas : Form
    {
        public FormEmpresas()
        {
            InitializeComponent();
        }
        private void AtualizarGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
        }
        private void FormEmpresas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadEmpresas(this);
            form.Novo();
        }

        private void empresasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (empresasDataGridView.CurrentRow != null)
            {
                var registro = empresasDataGridView.CurrentRow;

                if (MessageBox.Show("Deseja excluir esta empresa?", "Atenção",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var adp = new PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter();
                    adp.DeleteQuery(int.Parse(registro.Cells[0].Value.ToString()));
                    empresasBindingSource.Position = empresasDataGridView.CurrentCell.RowIndex;
                    empresasBindingSource.Remove(empresasBindingSource.Current);
                }
            }
        }

        private void empresasBindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            var index = empresasDataGridView.CurrentCell.RowIndex;
            var form = new CadEmpresas(this, index);
            form.ShowDialog();
            AtualizarGrid();
        }
    }
}
