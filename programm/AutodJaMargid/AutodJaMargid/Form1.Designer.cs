namespace AutodJaMargid
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewBrands = new DataGridView();
            brandIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandBindingSource = new BindingSource(components);
            dataGridViewCars = new DataGridView();
            carIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carsBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBrands
            // 
            dataGridViewBrands.AutoGenerateColumns = false;
            dataGridViewBrands.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrands.Columns.AddRange(new DataGridViewColumn[] { brandIDDataGridViewTextBoxColumn, brandNameDataGridViewTextBoxColumn });
            dataGridViewBrands.DataSource = brandBindingSource;
            dataGridViewBrands.Location = new Point(12, 12);
            dataGridViewBrands.Name = "dataGridViewBrands";
            dataGridViewBrands.ShowCellErrors = false;
            dataGridViewBrands.Size = new Size(240, 150);
            dataGridViewBrands.TabIndex = 0;
            dataGridViewBrands.SelectionChanged += dataGridViewBrands_SelectionChanged;
            // 
            // brandIDDataGridViewTextBoxColumn
            // 
            brandIDDataGridViewTextBoxColumn.DataPropertyName = "BrandID";
            brandIDDataGridViewTextBoxColumn.HeaderText = "BrandID";
            brandIDDataGridViewTextBoxColumn.Name = "brandIDDataGridViewTextBoxColumn";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Brand);
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { carIDDataGridViewTextBoxColumn, carNameDataGridViewTextBoxColumn, brandIDDataGridViewTextBoxColumn1, brandDataGridViewTextBoxColumn });
            dataGridViewCars.DataSource = carsBindingSource;
            dataGridViewCars.Location = new Point(258, 12);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(240, 150);
            dataGridViewCars.TabIndex = 1;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // brandIDDataGridViewTextBoxColumn1
            // 
            brandIDDataGridViewTextBoxColumn1.DataPropertyName = "BrandID";
            brandIDDataGridViewTextBoxColumn1.HeaderText = "BrandID";
            brandIDDataGridViewTextBoxColumn1.Name = "brandIDDataGridViewTextBoxColumn1";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            carsBindingSource.DataMember = "Cars";
            carsBindingSource.DataSource = brandBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(423, 168);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Salvesta";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 231);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCars);
            Controls.Add(dataGridViewBrands);
            Name = "MainForm";
            Text = "Margid Ja Autod";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrands).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBrands;
        private DataGridView dataGridViewCars;
        private Button buttonSave;
        private BindingSource brandBindingSource1;
        private BindingSource brandBindingSource;
        private BindingSource carsBindingSource;
        private DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource brandBindingSource2;
        private BindingSource brandBindingSource3;
        private BindingSource carsBindingSource1;
    }
}
