namespace FlatRent
{
    partial class Realtors
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
            this.button9 = new System.Windows.Forms.Button();
            this.dgv_realtor = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realtorsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residential_ComplexDataSet = new FlatRent.Residential_ComplexDataSet();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.realtorsTableAdapter = new FlatRent.Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_realtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(431, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(187, 40);
            this.button9.TabIndex = 18;
            this.button9.Text = "Агенство";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgv_realtor
            // 
            this.dgv_realtor.AllowUserToAddRows = false;
            this.dgv_realtor.AllowUserToDeleteRows = false;
            this.dgv_realtor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_realtor.AutoGenerateColumns = false;
            this.dgv_realtor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_realtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_realtor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.realtorsIDDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgv_realtor.DataSource = this.realtorsBindingSource;
            this.dgv_realtor.Location = new System.Drawing.Point(3, 68);
            this.dgv_realtor.Name = "dgv_realtor";
            this.dgv_realtor.ReadOnly = true;
            this.dgv_realtor.Size = new System.Drawing.Size(795, 304);
            this.dgv_realtor.TabIndex = 17;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realtorsIDDataGridViewTextBoxColumn
            // 
            this.realtorsIDDataGridViewTextBoxColumn.DataPropertyName = "Realtors_ID";
            this.realtorsIDDataGridViewTextBoxColumn.HeaderText = "Realtors_ID";
            this.realtorsIDDataGridViewTextBoxColumn.Name = "realtorsIDDataGridViewTextBoxColumn";
            this.realtorsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.realtorsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realtorsBindingSource
            // 
            this.realtorsBindingSource.DataMember = "Realtors";
            this.realtorsBindingSource.DataSource = this.residential_ComplexDataSet;
            // 
            // residential_ComplexDataSet
            // 
            this.residential_ComplexDataSet.DataSetName = "Residential_ComplexDataSet";
            this.residential_ComplexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(221, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(187, 40);
            this.button10.TabIndex = 16;
            this.button10.Text = "Видалити ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(12, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 40);
            this.button11.TabIndex = 15;
            this.button11.Text = "Додати ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(639, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // realtorsTableAdapter
            // 
            this.realtorsTableAdapter.ClearBeforeFill = true;
            // 
            // Realtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dgv_realtor);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Name = "Realtors";
            this.Text = "Рієлтори";
            this.Load += new System.EventHandler(this.Realtors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_realtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dgv_realtor;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private Residential_ComplexDataSet residential_ComplexDataSet;
        private System.Windows.Forms.BindingSource realtorsBindingSource;
        private Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter realtorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realtorsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}