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

        private void EmpresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*
                this.Validate();
                this.empresasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);
            */
        }

        private void EmpresasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            /*
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);
            */
        }

        private void FormEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadEmpresas(this);
            form.Novo();
        }
    }
}
