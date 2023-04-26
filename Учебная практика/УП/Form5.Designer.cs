namespace УП
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodzayavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodpokupatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodavtomobilyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazayavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zayavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cherepanovavtosalonDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cherepanov_avtosalonDataSet1 = new УП.Cherepanov_avtosalonDataSet1();
            this.zayavkaTableAdapter = new УП.Cherepanov_avtosalonDataSet1TableAdapters.ZayavkaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanov_avtosalonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оформление заявки";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(41, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(433, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить заявку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodzayavkiDataGridViewTextBoxColumn,
            this.kodpokupatelyaDataGridViewTextBoxColumn,
            this.kodavtomobilyaDataGridViewTextBoxColumn,
            this.datazayavkiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zayavkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // kodzayavkiDataGridViewTextBoxColumn
            // 
            this.kodzayavkiDataGridViewTextBoxColumn.DataPropertyName = "kod_zayavki";
            this.kodzayavkiDataGridViewTextBoxColumn.HeaderText = "kod_zayavki";
            this.kodzayavkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodzayavkiDataGridViewTextBoxColumn.Name = "kodzayavkiDataGridViewTextBoxColumn";
            this.kodzayavkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodpokupatelyaDataGridViewTextBoxColumn
            // 
            this.kodpokupatelyaDataGridViewTextBoxColumn.DataPropertyName = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.HeaderText = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodpokupatelyaDataGridViewTextBoxColumn.Name = "kodpokupatelyaDataGridViewTextBoxColumn";
            this.kodpokupatelyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodavtomobilyaDataGridViewTextBoxColumn
            // 
            this.kodavtomobilyaDataGridViewTextBoxColumn.DataPropertyName = "kod_avtomobilya";
            this.kodavtomobilyaDataGridViewTextBoxColumn.HeaderText = "kod_avtomobilya";
            this.kodavtomobilyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodavtomobilyaDataGridViewTextBoxColumn.Name = "kodavtomobilyaDataGridViewTextBoxColumn";
            this.kodavtomobilyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazayavkiDataGridViewTextBoxColumn
            // 
            this.datazayavkiDataGridViewTextBoxColumn.DataPropertyName = "data_zayavki";
            this.datazayavkiDataGridViewTextBoxColumn.HeaderText = "data_zayavki";
            this.datazayavkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazayavkiDataGridViewTextBoxColumn.Name = "datazayavkiDataGridViewTextBoxColumn";
            this.datazayavkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // zayavkaBindingSource
            // 
            this.zayavkaBindingSource.DataMember = "Zayavka";
            this.zayavkaBindingSource.DataSource = this.cherepanovavtosalonDataSet1BindingSource;
            // 
            // cherepanovavtosalonDataSet1BindingSource
            // 
            this.cherepanovavtosalonDataSet1BindingSource.DataSource = this.cherepanov_avtosalonDataSet1;
            this.cherepanovavtosalonDataSet1BindingSource.Position = 0;
            // 
            // cherepanov_avtosalonDataSet1
            // 
            this.cherepanov_avtosalonDataSet1.DataSetName = "Cherepanov_avtosalonDataSet1";
            this.cherepanov_avtosalonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavkaTableAdapter
            // 
            this.zayavkaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.GreenYellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(38, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(551, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "____________________________________________________________________\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "____________________________________________________________________\r\n";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(627, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заявки";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanov_avtosalonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cherepanovavtosalonDataSet1BindingSource;
        private Cherepanov_avtosalonDataSet1 cherepanov_avtosalonDataSet1;
        private System.Windows.Forms.BindingSource zayavkaBindingSource;
        private Cherepanov_avtosalonDataSet1TableAdapters.ZayavkaTableAdapter zayavkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodzayavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpokupatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodavtomobilyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazayavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}