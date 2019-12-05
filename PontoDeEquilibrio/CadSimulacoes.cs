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
    public partial class CadSimulacoes : Form
    {
        private FormDados FormSimulacoes;
        private FormResultados FormResult;
        private string Razao;
        private string Reason;
        public CadSimulacoes(int index, string razao, FormResultados formResult)
        {
            InitializeComponent();
            FormResult = formResult;
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
            simulacoesBindingSource.Filter = "EMPRESAID = " + index;
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);
            Razao = razao;
        }
        public CadSimulacoes(FormDados formSimulacoes)
        {
            InitializeComponent();
            FormSimulacoes = formSimulacoes;
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
        }

        public CadSimulacoes(FormDados formSimulacoes, int index)
        {
            InitializeComponent();
            FormSimulacoes = formSimulacoes;
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
            simulacoesBindingSource.Position = index;

            var indice = ((simulacoesBindingSource.Current as DataRowView).Row as PONTOEQDBDataSet.SimulacoesRow).EmpresaID;
            empresasBindingSource.Filter = "EMPRESAID = " + indice;
            Reason = ((empresasBindingSource.Current as DataRowView).Row as PONTOEQDBDataSet.EmpresasRow).RazaoSocial;
            empresasBindingSource.Filter = null;
        }
        internal void Novo()
        {
            simulacoesBindingSource.AddNew();
            custoFixoTotalTextBox.Focus();

            ShowDialog();
        }

        private void SimulacoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.simulacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pONTOEQDBDataSet);
            if (FormSimulacoes != null) FormSimulacoes.simulacoesTableAdapter.Fill(FormSimulacoes.pONTOEQDBDataSet.Simulacoes);
            else if (FormResult != null) FormResult.simulacoesTableAdapter.Fill(FormResult.pONTOEQDBDataSet.Simulacoes);
        }

        private void CadSimulacoes_Load(object sender, EventArgs e)
        {
            if(Razao != null)
            {
                empresaIDComboBox.SelectedIndex = empresaIDComboBox.FindString(Razao);
                empresaIDComboBox.Enabled = false;
            } 
            else if(Reason != null)
            {
                empresaIDComboBox.SelectedIndex = empresaIDComboBox.FindString(Reason);
            }
            else if (empresaIDComboBox.Items.Count > 0) empresaIDComboBox.SelectedIndex = 0;
        }

        private void empresaIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
