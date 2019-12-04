namespace PontoDeEquilibrio
{
    partial class CadSimulacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empresaIDLabel;
            System.Windows.Forms.Label simulacaoIDLabel;
            System.Windows.Forms.Label custoFixoTotalLabel;
            System.Windows.Forms.Label custoVarUnitLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label qtdeVendaInicialLabel;
            System.Windows.Forms.Label qtdeVendaFinalLabel;
            System.Windows.Forms.Label incrementoUnitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadSimulacoes));
            this.pONTOEQDBDataSet = new PontoDeEquilibrio.PONTOEQDBDataSet();
            this.simulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulacoesTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter();
            this.tableAdapterManager = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager();
            this.empresasTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter();
            this.simulacoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.simulacoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empresaIDComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulacaoIDTextBox = new System.Windows.Forms.TextBox();
            this.custoFixoTotalTextBox = new System.Windows.Forms.TextBox();
            this.custoVarUnitTextBox = new System.Windows.Forms.TextBox();
            this.precoUnitTextBox = new System.Windows.Forms.TextBox();
            this.qtdeVendaInicialTextBox = new System.Windows.Forms.TextBox();
            this.qtdeVendaFinalTextBox = new System.Windows.Forms.TextBox();
            this.incrementoUnitTextBox = new System.Windows.Forms.TextBox();
            empresaIDLabel = new System.Windows.Forms.Label();
            simulacaoIDLabel = new System.Windows.Forms.Label();
            custoFixoTotalLabel = new System.Windows.Forms.Label();
            custoVarUnitLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            qtdeVendaInicialLabel = new System.Windows.Forms.Label();
            qtdeVendaFinalLabel = new System.Windows.Forms.Label();
            incrementoUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).BeginInit();
            this.simulacoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empresaIDLabel
            // 
            empresaIDLabel.AutoSize = true;
            empresaIDLabel.Location = new System.Drawing.Point(8, 40);
            empresaIDLabel.Name = "empresaIDLabel";
            empresaIDLabel.Size = new System.Drawing.Size(51, 13);
            empresaIDLabel.TabIndex = 1;
            empresaIDLabel.Text = "Empresa:";
            // 
            // simulacaoIDLabel
            // 
            simulacaoIDLabel.AutoSize = true;
            simulacaoIDLabel.Location = new System.Drawing.Point(8, 67);
            simulacaoIDLabel.Name = "simulacaoIDLabel";
            simulacaoIDLabel.Size = new System.Drawing.Size(114, 13);
            simulacaoIDLabel.TabIndex = 3;
            simulacaoIDLabel.Text = "Número da Simulação:";
            // 
            // custoFixoTotalLabel
            // 
            custoFixoTotalLabel.AutoSize = true;
            custoFixoTotalLabel.Location = new System.Drawing.Point(8, 93);
            custoFixoTotalLabel.Name = "custoFixoTotalLabel";
            custoFixoTotalLabel.Size = new System.Drawing.Size(86, 13);
            custoFixoTotalLabel.TabIndex = 5;
            custoFixoTotalLabel.Text = "Custo Fixo Total:";
            // 
            // custoVarUnitLabel
            // 
            custoVarUnitLabel.AutoSize = true;
            custoVarUnitLabel.Location = new System.Drawing.Point(8, 119);
            custoVarUnitLabel.Name = "custoVarUnitLabel";
            custoVarUnitLabel.Size = new System.Drawing.Size(177, 13);
            custoVarUnitLabel.TabIndex = 7;
            custoVarUnitLabel.Text = "Custo variável por unidade vendida:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(8, 145);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(145, 13);
            precoUnitLabel.TabIndex = 9;
            precoUnitLabel.Text = "Preço de venda por unidade:";
            // 
            // qtdeVendaInicialLabel
            // 
            qtdeVendaInicialLabel.AutoSize = true;
            qtdeVendaInicialLabel.Location = new System.Drawing.Point(8, 171);
            qtdeVendaInicialLabel.Name = "qtdeVendaInicialLabel";
            qtdeVendaInicialLabel.Size = new System.Drawing.Size(187, 13);
            qtdeVendaInicialLabel.TabIndex = 11;
            qtdeVendaInicialLabel.Text = "Quantidade de venda inicial estimada:";
            // 
            // qtdeVendaFinalLabel
            // 
            qtdeVendaFinalLabel.AutoSize = true;
            qtdeVendaFinalLabel.Location = new System.Drawing.Point(8, 197);
            qtdeVendaFinalLabel.Name = "qtdeVendaFinalLabel";
            qtdeVendaFinalLabel.Size = new System.Drawing.Size(180, 13);
            qtdeVendaFinalLabel.TabIndex = 13;
            qtdeVendaFinalLabel.Text = "Quantidade de venda final estimada:";
            // 
            // incrementoUnitLabel
            // 
            incrementoUnitLabel.AutoSize = true;
            incrementoUnitLabel.Location = new System.Drawing.Point(8, 223);
            incrementoUnitLabel.Name = "incrementoUnitLabel";
            incrementoUnitLabel.Size = new System.Drawing.Size(241, 13);
            incrementoUnitLabel.TabIndex = 15;
            incrementoUnitLabel.Text = "Incremento de unidades a apresentar no relatório:";
            // 
            // pONTOEQDBDataSet
            // 
            this.pONTOEQDBDataSet.DataSetName = "PONTOEQDBDataSet";
            this.pONTOEQDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simulacoesBindingSource
            // 
            this.simulacoesBindingSource.DataMember = "Simulacoes";
            this.simulacoesBindingSource.DataSource = this.pONTOEQDBDataSet;
            // 
            // simulacoesTableAdapter
            // 
            this.simulacoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.SimulacoesTableAdapter = this.simulacoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // simulacoesBindingNavigator
            // 
            this.simulacoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.simulacoesBindingNavigator.BindingSource = this.simulacoesBindingSource;
            this.simulacoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.simulacoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.simulacoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.simulacoesBindingNavigatorSaveItem});
            this.simulacoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.simulacoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.simulacoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.simulacoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.simulacoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.simulacoesBindingNavigator.Name = "simulacoesBindingNavigator";
            this.simulacoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.simulacoesBindingNavigator.Size = new System.Drawing.Size(390, 25);
            this.simulacoesBindingNavigator.TabIndex = 0;
            this.simulacoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // simulacoesBindingNavigatorSaveItem
            // 
            this.simulacoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.simulacoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("simulacoesBindingNavigatorSaveItem.Image")));
            this.simulacoesBindingNavigatorSaveItem.Name = "simulacoesBindingNavigatorSaveItem";
            this.simulacoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.simulacoesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.simulacoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.SimulacoesBindingNavigatorSaveItem_Click);
            // 
            // empresaIDComboBox
            // 
            this.empresaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simulacoesBindingSource, "EmpresaID", true));
            this.empresaIDComboBox.DataSource = this.empresasBindingSource;
            this.empresaIDComboBox.DisplayMember = "RazaoSocial";
            this.empresaIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaIDComboBox.FormattingEnabled = true;
            this.empresaIDComboBox.Location = new System.Drawing.Point(251, 37);
            this.empresaIDComboBox.Name = "empresaIDComboBox";
            this.empresaIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaIDComboBox.TabIndex = 2;
            this.empresaIDComboBox.ValueMember = "EmpresaID";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.pONTOEQDBDataSet;
            // 
            // simulacaoIDTextBox
            // 
            this.simulacaoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "SimulacaoID", true));
            this.simulacaoIDTextBox.Location = new System.Drawing.Point(251, 64);
            this.simulacaoIDTextBox.Name = "simulacaoIDTextBox";
            this.simulacaoIDTextBox.ReadOnly = true;
            this.simulacaoIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.simulacaoIDTextBox.TabIndex = 4;
            // 
            // custoFixoTotalTextBox
            // 
            this.custoFixoTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "CustoFixoTotal", true));
            this.custoFixoTotalTextBox.Location = new System.Drawing.Point(251, 90);
            this.custoFixoTotalTextBox.Name = "custoFixoTotalTextBox";
            this.custoFixoTotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.custoFixoTotalTextBox.TabIndex = 6;
            // 
            // custoVarUnitTextBox
            // 
            this.custoVarUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "CustoVarUnit", true));
            this.custoVarUnitTextBox.Location = new System.Drawing.Point(251, 116);
            this.custoVarUnitTextBox.Name = "custoVarUnitTextBox";
            this.custoVarUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.custoVarUnitTextBox.TabIndex = 8;
            // 
            // precoUnitTextBox
            // 
            this.precoUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "PrecoUnit", true));
            this.precoUnitTextBox.Location = new System.Drawing.Point(251, 142);
            this.precoUnitTextBox.Name = "precoUnitTextBox";
            this.precoUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.precoUnitTextBox.TabIndex = 10;
            // 
            // qtdeVendaInicialTextBox
            // 
            this.qtdeVendaInicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "QtdeVendaInicial", true));
            this.qtdeVendaInicialTextBox.Location = new System.Drawing.Point(251, 168);
            this.qtdeVendaInicialTextBox.Name = "qtdeVendaInicialTextBox";
            this.qtdeVendaInicialTextBox.Size = new System.Drawing.Size(121, 20);
            this.qtdeVendaInicialTextBox.TabIndex = 12;
            // 
            // qtdeVendaFinalTextBox
            // 
            this.qtdeVendaFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "QtdeVendaFinal", true));
            this.qtdeVendaFinalTextBox.Location = new System.Drawing.Point(251, 194);
            this.qtdeVendaFinalTextBox.Name = "qtdeVendaFinalTextBox";
            this.qtdeVendaFinalTextBox.Size = new System.Drawing.Size(121, 20);
            this.qtdeVendaFinalTextBox.TabIndex = 14;
            // 
            // incrementoUnitTextBox
            // 
            this.incrementoUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "IncrementoUnit", true));
            this.incrementoUnitTextBox.Location = new System.Drawing.Point(251, 220);
            this.incrementoUnitTextBox.Name = "incrementoUnitTextBox";
            this.incrementoUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.incrementoUnitTextBox.TabIndex = 16;
            // 
            // CadSimulacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 254);
            this.Controls.Add(empresaIDLabel);
            this.Controls.Add(this.empresaIDComboBox);
            this.Controls.Add(simulacaoIDLabel);
            this.Controls.Add(this.simulacaoIDTextBox);
            this.Controls.Add(custoFixoTotalLabel);
            this.Controls.Add(this.custoFixoTotalTextBox);
            this.Controls.Add(custoVarUnitLabel);
            this.Controls.Add(this.custoVarUnitTextBox);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.precoUnitTextBox);
            this.Controls.Add(qtdeVendaInicialLabel);
            this.Controls.Add(this.qtdeVendaInicialTextBox);
            this.Controls.Add(qtdeVendaFinalLabel);
            this.Controls.Add(this.qtdeVendaFinalTextBox);
            this.Controls.Add(incrementoUnitLabel);
            this.Controls.Add(this.incrementoUnitTextBox);
            this.Controls.Add(this.simulacoesBindingNavigator);
            this.Name = "CadSimulacoes";
            this.Text = "Cadastro de Simulações";
            this.Load += new System.EventHandler(this.CadSimulacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).EndInit();
            this.simulacoesBindingNavigator.ResumeLayout(false);
            this.simulacoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PONTOEQDBDataSet pONTOEQDBDataSet;
        private System.Windows.Forms.BindingSource simulacoesBindingSource;
        private PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter simulacoesTableAdapter;
        private PONTOEQDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator simulacoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton simulacoesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox empresaIDComboBox;
        private System.Windows.Forms.TextBox simulacaoIDTextBox;
        private System.Windows.Forms.TextBox custoFixoTotalTextBox;
        private System.Windows.Forms.TextBox custoVarUnitTextBox;
        private System.Windows.Forms.TextBox precoUnitTextBox;
        private System.Windows.Forms.TextBox qtdeVendaInicialTextBox;
        private System.Windows.Forms.TextBox qtdeVendaFinalTextBox;
        private System.Windows.Forms.TextBox incrementoUnitTextBox;
        private PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.BindingSource empresasBindingSource;
    }
}