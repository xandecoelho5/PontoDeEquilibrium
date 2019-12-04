namespace PontoDeEquilibrio
{
    partial class FormDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDados));
            this.pONTOEQDBDataSet = new PontoDeEquilibrio.PONTOEQDBDataSet();
            this.simulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulacoesTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter();
            this.tableAdapterManager = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager();
            this.simulacoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.simulacoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.simulacoesBindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.simulacoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).BeginInit();
            this.simulacoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.SimulacoesTableAdapter = this.simulacoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // simulacoesBindingNavigator
            // 
            this.simulacoesBindingNavigator.AddNewItem = null;
            this.simulacoesBindingNavigator.BindingSource = this.simulacoesBindingSource;
            this.simulacoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.simulacoesBindingNavigator.DeleteItem = null;
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
            this.simulacoesBindingNavigatorSaveItem,
            this.simulacoesBindingNavigatorEditItem});
            this.simulacoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.simulacoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.simulacoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.simulacoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.simulacoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.simulacoesBindingNavigator.Name = "simulacoesBindingNavigator";
            this.simulacoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.simulacoesBindingNavigator.Size = new System.Drawing.Size(851, 25);
            this.simulacoesBindingNavigator.TabIndex = 0;
            this.simulacoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // simulacoesBindingNavigatorEditItem
            // 
            this.simulacoesBindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.simulacoesBindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("simulacoesBindingNavigatorEditItem.Image")));
            this.simulacoesBindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.simulacoesBindingNavigatorEditItem.Name = "simulacoesBindingNavigatorEditItem";
            this.simulacoesBindingNavigatorEditItem.Size = new System.Drawing.Size(23, 22);
            this.simulacoesBindingNavigatorEditItem.Text = "Editar Arquivo";
            this.simulacoesBindingNavigatorEditItem.Click += new System.EventHandler(this.simulacoesBindingNavigatorEditItem_Click);
            // 
            // simulacoesDataGridView
            // 
            this.simulacoesDataGridView.AllowUserToAddRows = false;
            this.simulacoesDataGridView.AllowUserToDeleteRows = false;
            this.simulacoesDataGridView.AutoGenerateColumns = false;
            this.simulacoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simulacoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.simulacoesDataGridView.DataSource = this.simulacoesBindingSource;
            this.simulacoesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulacoesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.simulacoesDataGridView.Name = "simulacoesDataGridView";
            this.simulacoesDataGridView.ReadOnly = true;
            this.simulacoesDataGridView.Size = new System.Drawing.Size(851, 411);
            this.simulacoesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpresaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmpresaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SimulacaoID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SimulacaoID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustoFixoTotal";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustoFixoTotal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustoVarUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "CustoVarUnit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecoUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrecoUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QtdeVendaInicial";
            this.dataGridViewTextBoxColumn6.HeaderText = "QtdeVendaInicial";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QtdeVendaFinal";
            this.dataGridViewTextBoxColumn7.HeaderText = "QtdeVendaFinal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IncrementoUnit";
            this.dataGridViewTextBoxColumn8.HeaderText = "IncrementoUnit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 436);
            this.Controls.Add(this.simulacoesDataGridView);
            this.Controls.Add(this.simulacoesBindingNavigator);
            this.Name = "FormDados";
            this.Text = "FormSimulacoes";
            this.Load += new System.EventHandler(this.FormDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).EndInit();
            this.simulacoesBindingNavigator.ResumeLayout(false);
            this.simulacoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PONTOEQDBDataSet pONTOEQDBDataSet;
        private System.Windows.Forms.BindingSource simulacoesBindingSource;
        public PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter simulacoesTableAdapter;
        public PONTOEQDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView simulacoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton simulacoesBindingNavigatorEditItem;
    }
}