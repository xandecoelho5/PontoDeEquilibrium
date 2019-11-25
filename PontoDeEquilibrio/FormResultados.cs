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
    public partial class FormResultados : Form
    {
        //passar a Empresa e a Simulação por parâmetro;
        //buscar no banco ou no dataset, os dados referentes à esse combo;
        // realizar os calczera;
        private int SelectedValue;
        private string Razao;
        public FormResultados(int selectedValue, string razao)
        {
            InitializeComponent();
            SelectedValue = selectedValue;
            Razao = razao;
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            this.empresasTableAdapter.Fill(this.pONTOEQDBDataSet.Empresas);    
            simulacoesBindingSource.Filter = "EMPRESAID = " + SelectedValue;
            this.simulacoesTableAdapter.Fill(this.pONTOEQDBDataSet.Simulacoes);

            if(this.simulacoesBindingSource.Count > 0)
            {
                FillRows();
                colorRows();
            }
            comboEmpresas.Text = Razao;
        }

        private void FillRows()
        {
            var fieldValues = (this.simulacoesBindingSource.Current as DataRowView).Row.ItemArray;
            //var fieldValues = this.pONTOEQDBDataSet.Simulacoes.Rows[int.Parse(bindingNavigator1.PositionItem.Text) - 1].ItemArray;
            TB_CustoTotal.Text = fieldValues[2].ToString();
            TB_CustoVariavel.Text = fieldValues[3].ToString();
            TB_VendaPorUnidade.Text = fieldValues[4].ToString();

            var ini = int.Parse(fieldValues[5].ToString());
            var fim = int.Parse(fieldValues[6].ToString());
            var increment = int.Parse(fieldValues[7].ToString());

            var aux = ini;

            gridResultados.Rows.Clear();

            while (ini <= fim)
            {
                gridResultados.Rows.Add();
                ini += increment;
            }

            ini = aux;

            int i = 0;
            while (ini <= fim)
            {
                gridResultados.Rows[i].Cells[0].Value = ini;
                gridResultados.Rows[i].Cells[1].Value = Double.Parse(TB_CustoTotal.Text) + (Double.Parse(TB_CustoVariavel.Text) * ini);
                gridResultados.Rows[i].Cells[2].Value = Double.Parse(TB_VendaPorUnidade.Text) * ini;
                gridResultados.Rows[i].Cells[3].Value = Double.Parse(gridResultados.Rows[i].Cells[2].Value.ToString()) - Double.Parse(gridResultados.Rows[i].Cells[1].Value.ToString());
                gridResultados.Rows[i].Cells[4].Value = Double.Parse(gridResultados.Rows[i].Cells[1].Value.ToString()) / ini;          
                ini += increment;
                i++;
            }

            TB_Equilibrio.Text = (Double.Parse(TB_CustoTotal.Text) / (Double.Parse(TB_VendaPorUnidade.Text) - Double.Parse(TB_CustoVariavel.Text))).ToString();
            TB_Receita_Equilibrio.Text = (Double.Parse(TB_VendaPorUnidade.Text) * Double.Parse(TB_Equilibrio.Text)).ToString();
            TB_Custo_Equilibrio.Text = (Double.Parse(TB_CustoTotal.Text) + (Double.Parse(TB_CustoVariavel.Text) * Double.Parse(TB_Equilibrio.Text))).ToString();
        }

        private void colorRows()
        {
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            cellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));

            var least = Double.MaxValue;
            int index = 0;

            for(int i=0; i<gridResultados.Rows.Count-1; i++)
            {
                var gp = Math.Abs(Double.Parse(gridResultados.Rows[i].Cells[3].Value.ToString()));
                if (gp < least)
                {
                    least = gp;
                    index = i; 
                }
            }
            gridResultados.Rows[index].DefaultCellStyle = cellStyle;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadSimulacoes(SelectedValue, Razao);
            form.Novo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            if(bindingNavigator1.PositionItem.Text != "0")
            {
                FillRows();
                colorRows();
            }      
        }
    }
}
