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
    public partial class FormSelector : Form
    {
        public FormSelector()
        {
            InitializeComponent();
        }

        private void FormSelector_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pONTOEQDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(CBEmpresas.SelectedIndex != -1)
            {
                var razao = CBEmpresas.Text;

                var adp = new PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter();
                var res = adp.GetIDByRazao(razao);
                int EmpresaID = 1;

                foreach (var item in res) EmpresaID = item.EmpresaID;

                new FormResultados(EmpresaID, razao).Show();
                //PONTOEQDBDataSet.EmpresasRow
                //Filtrar dataset para apenas cuja empresa = value of selected;
            }
            //validar se foram selecionados os 2 comboBox
            // new FormResultados().Show();
        }
    }
}
