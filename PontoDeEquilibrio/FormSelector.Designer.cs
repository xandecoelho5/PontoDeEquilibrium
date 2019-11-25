namespace PontoDeEquilibrio
{
    partial class FormSelector
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
            this.CBEmpresas = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pONTOEQDBDataSet = new PontoDeEquilibrio.PONTOEQDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.simulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empresasTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter();
            this.simulacoesTableAdapter = new PontoDeEquilibrio.PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CBEmpresas
            // 
            this.CBEmpresas.DataSource = this.empresasBindingSource;
            this.CBEmpresas.DisplayMember = "RazaoSocial";
            this.CBEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEmpresas.FormattingEnabled = true;
            this.CBEmpresas.Location = new System.Drawing.Point(136, 20);
            this.CBEmpresas.Name = "CBEmpresas";
            this.CBEmpresas.Size = new System.Drawing.Size(118, 21);
            this.CBEmpresas.TabIndex = 0;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.pONTOEQDBDataSet;
            // 
            // pONTOEQDBDataSet
            // 
            this.pONTOEQDBDataSet.DataSetName = "PONTOEQDBDataSet";
            this.pONTOEQDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Empresa:";
            // 
            // simulacoesBindingSource
            // 
            this.simulacoesBindingSource.DataMember = "Simulacoes";
            this.simulacoesBindingSource.DataSource = this.pONTOEQDBDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // simulacoesTableAdapter
            // 
            this.simulacoesTableAdapter.ClearBeforeFill = true;
            // 
            // FormSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 87);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBEmpresas);
            this.Name = "FormSelector";
            this.Text = "Selecionar Empresa";
            this.Load += new System.EventHandler(this.FormSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOEQDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PONTOEQDBDataSet pONTOEQDBDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private PONTOEQDBDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.BindingSource simulacoesBindingSource;
        private PONTOEQDBDataSetTableAdapters.SimulacoesTableAdapter simulacoesTableAdapter;
    }
}