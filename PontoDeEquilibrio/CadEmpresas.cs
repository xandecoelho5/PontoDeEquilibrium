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
    public partial class CadEmpresas : Form
    {
        private FormEmpresas FormPai;
        public CadEmpresas(FormEmpresas formPai)
        {
            InitializeComponent();
            FormPai = formPai;
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
        }
        internal void Novo()
        {
            empresasBindingSource.AddNew();
            //razaoSocialTextBox.Focus();
            ShowDialog();
        }
        private void EmpresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);
            FormPai.empresasTableAdapter.Fill(FormPai.pONTOEQDBDataSet.Empresas);
        }

        private void CadEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
          //  this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
