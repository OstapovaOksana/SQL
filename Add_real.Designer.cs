namespace FlatRent
{
    partial class Add_real
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.realtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residential_ComplexDataSet = new FlatRent.Residential_ComplexDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.flatsTableAdapter = new FlatRent.Residential_ComplexDataSetTableAdapters.FlatsTableAdapter();
            this.realtorsTableAdapter = new FlatRent.Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter();
            this.r_CompanyTableAdapter = new FlatRent.Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.realtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.realtorsBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(219, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 29);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "Realtors_ID";
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
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.flatsBindingSource;
            this.comboBox1.DisplayMember = "Number";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 29);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "Flats_ID";
            // 
            // flatsBindingSource
            // 
            this.flatsBindingSource.DataMember = "Flats";
            this.flatsBindingSource.DataSource = this.residential_ComplexDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Рієлтор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Квартира";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.rCompanyBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(219, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(157, 29);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.ValueMember = "RC_ID";
            // 
            // rCompanyBindingSource
            // 
            this.rCompanyBindingSource.DataMember = "R_Company";
            this.rCompanyBindingSource.DataSource = this.residential_ComplexDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Агентство";
            // 
            // flatsTableAdapter
            // 
            this.flatsTableAdapter.ClearBeforeFill = true;
            // 
            // realtorsTableAdapter
            // 
            this.realtorsTableAdapter.ClearBeforeFill = true;
            // 
            // r_CompanyTableAdapter
            // 
            this.r_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // Add_real
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 243);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_real";
            this.Text = "Додати";
            this.Load += new System.EventHandler(this.Add_real_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residential_ComplexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private Residential_ComplexDataSet residential_ComplexDataSet;
        private System.Windows.Forms.BindingSource flatsBindingSource;
        private Residential_ComplexDataSetTableAdapters.FlatsTableAdapter flatsTableAdapter;
        private System.Windows.Forms.BindingSource realtorsBindingSource;
        private Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter realtorsTableAdapter;
        private System.Windows.Forms.BindingSource rCompanyBindingSource;
        private Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter r_CompanyTableAdapter;
    }
}