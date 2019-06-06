namespace FlatRent
{
    partial class RComp
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
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dgv_comp = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residential_ComplexDataSet = new FlatRent.Residential_ComplexDataSet();
            this.r_CompanyTableAdapter = new FlatRent.Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(368, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(187, 40);
            this.button10.TabIndex = 14;
            this.button10.Text = "Видалити ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(64, 11);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 40);
            this.button11.TabIndex = 13;
            this.button11.Text = "Додати ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dgv_comp
            // 
            this.dgv_comp.AllowUserToAddRows = false;
            this.dgv_comp.AllowUserToDeleteRows = false;
            this.dgv_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_comp.AutoGenerateColumns = false;
            this.dgv_comp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rCIDDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.staffDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgv_comp.DataSource = this.rCompanyBindingSource;
            this.dgv_comp.Location = new System.Drawing.Point(3, 57);
            this.dgv_comp.Name = "dgv_comp";
            this.dgv_comp.ReadOnly = true;
            this.dgv_comp.Size = new System.Drawing.Size(795, 307);
            this.dgv_comp.TabIndex = 12;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rCIDDataGridViewTextBoxColumn
            // 
            this.rCIDDataGridViewTextBoxColumn.DataPropertyName = "RC_ID";
            this.rCIDDataGridViewTextBoxColumn.HeaderText = "RC_ID";
            this.rCIDDataGridViewTextBoxColumn.Name = "rCIDDataGridViewTextBoxColumn";
            this.rCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Директор";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffDataGridViewTextBoxColumn
            // 
            this.staffDataGridViewTextBoxColumn.DataPropertyName = "Staff";
            this.staffDataGridViewTextBoxColumn.HeaderText = "Кількість працівників";
            this.staffDataGridViewTextBoxColumn.Name = "staffDataGridViewTextBoxColumn";
            this.staffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rCompanyBindingSource
            // 
            this.rCompanyBindingSource.DataMember = "R_Company";
            this.rCompanyBindingSource.DataSource = this.residential_ComplexDataSet;
            // 
            // residential_ComplexDataSet
            // 
            this.residential_ComplexDataSet.DataSetName = "Residential_ComplexDataSet";
            this.residential_ComplexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r_CompanyTableAdapter
            // 
            this.r_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // RComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dgv_comp);
            this.Name = "RComp";
            this.Text = "Агентство";
            this.Load += new System.EventHandler(this.RComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dgv_comp;
        private Residential_ComplexDataSet residential_ComplexDataSet;
        private System.Windows.Forms.BindingSource rCompanyBindingSource;
        private Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter r_CompanyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}