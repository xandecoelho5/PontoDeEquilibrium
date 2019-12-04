namespace PontoDeEquilibrio
{
    partial class CadEmpresas
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
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label foneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEmpresas));
            this.pONTOEQDBDataSet = new PontoDeEquilibrio.PONTOEQDBDataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager();
            this.empresasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.empresasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empresaIDTextBox = new System.Windows.Forms.TextBox();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            empresaIDLabel = new System.Windows.Forms.Label();
            razaoSocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingNavigator)).BeginInit();
            this.empresasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // empresaIDLabel
            // 
            empresaIDLabel.AutoSize = true;
            empresaIDLabel.Location = new System.Drawing.Point(12, 47);
            empresaIDLabel.Name = "empresaIDLabel";
            empresaIDLabel.Size = new System.Drawing.Size(65, 13);
            empresaIDLabel.TabIndex = 1;
            empresaIDLabel.Text = "Empresa ID:";
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(12, 73);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(73, 13);
            razaoSocialLabel.TabIndex = 3;
            razaoSocialLabel.Text = "Razao Social:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(12, 99);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 5;
            cNPJLabel.Text = "CNPJ:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(12, 125);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(34, 13);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Fone:";
            // 
            // pONTOEQDBDataSet
            // 
            this.pONTOEQDBDataSet.DataSetName = "PONTOEQDBDataSet";
            this.pONTOEQDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.pONTOEQDBDataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.SimulacoesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresasBindingNavigator
            // 
            this.empresasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empresasBindingNavigator.BindingSource = this.empresasBindingSource;
            this.empresasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empresasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empresasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empresasBindingNavigatorSaveItem});
            this.empresasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empresasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empresasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empresasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empresasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empresasBindingNavigator.Name = "empresasBindingNavigator";
            this.empresasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empresasBindingNavigator.Size = new System.Drawing.Size(304, 25);
            this.empresasBindingNavigator.TabIndex = 0;
            this.empresasBindingNavigator.Text = "bindingNavigator1";
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
            // empresasBindingNavigatorSaveItem
            // 
            this.empresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empresasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empresasBindingNavigatorSaveItem.Image")));
            this.empresasBindingNavigatorSaveItem.Name = "empresasBindingNavigatorSaveItem";
            this.empresasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empresasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.empresasBindingNavigatorSaveItem.Click += new System.EventHandler(this.EmpresasBindingNavigatorSaveItem_Click);
            // 
            // empresaIDTextBox
            // 
            this.empresaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "EmpresaID", true));
            this.empresaIDTextBox.Location = new System.Drawing.Point(91, 44);
            this.empresaIDTextBox.Name = "empresaIDTextBox";
            this.empresaIDTextBox.ReadOnly = true;
            this.empresaIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaIDTextBox.TabIndex = 2;
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "RazaoSocial", true));
            this.razaoSocialTextBox.Location = new System.Drawing.Point(91, 70);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razaoSocialTextBox.TabIndex = 4;
            // 
            // cNPJTextBox
            // 
            this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "CNPJ", true));
            this.cNPJTextBox.Location = new System.Drawing.Point(91, 96);
            this.cNPJTextBox.Name = "cNPJTextBox";
            this.cNPJTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNPJTextBox.TabIndex = 6;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(91, 122);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(100, 20);
            this.foneTextBox.TabIndex = 8;
            // 
            // CadEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 157);
            this.Controls.Add(empresaIDLabel);
            this.Controls.Add(this.empresaIDTextBox);
            this.Controls.Add(razaoSocialLabel);
            this.Controls.Add(this.razaoSocialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(this.empresasBindingNavigator);
            this.Name = "CadEmpresas";
            this.Text = "Cadastro de Empresas";
            this.Load += new System.EventHandler(this.CadEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingNavigator)).EndInit();
            this.empresasBindingNavigator.ResumeLayout(false);
            this.empresasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PONTOEQDBDataSet pONTOEQDBDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private PONTOEQDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empresasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empresasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empresaIDTextBox;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
    }
}