namespace УП
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodavtomobilyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompliktaciyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshchnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavypuskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtomobilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cherepanov_avtosalonDataSet = new УП.Cherepanov_avtosalonDataSet();
            this.avtomobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cherepanovavtosalonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cherepanovavtosalonDataSet = new УП.CherepanovavtosalonDataSet();
            this.avtomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.avtomobilTableAdapter = new УП.Cherepanov_avtosalonDataSetTableAdapters.AvtomobilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.avtomobilTableAdapter1 = new УП.CherepanovavtosalonDataSetTableAdapters.AvtomobilTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.avtomobilBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanov_avtosalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodavtomobilyaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kompliktaciyaDataGridViewTextBoxColumn,
            this.kolichestvoDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.moshchnostDataGridViewTextBoxColumn,
            this.datavypuskaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avtomobilBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // kodavtomobilyaDataGridViewTextBoxColumn
            // 
            this.kodavtomobilyaDataGridViewTextBoxColumn.DataPropertyName = "kod_avtomobilya";
            this.kodavtomobilyaDataGridViewTextBoxColumn.HeaderText = "kod_avtomobilya";
            this.kodavtomobilyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodavtomobilyaDataGridViewTextBoxColumn.Name = "kodavtomobilyaDataGridViewTextBoxColumn";
            this.kodavtomobilyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kompliktaciyaDataGridViewTextBoxColumn
            // 
            this.kompliktaciyaDataGridViewTextBoxColumn.DataPropertyName = "kompliktaciya";
            this.kompliktaciyaDataGridViewTextBoxColumn.HeaderText = "kompliktaciya";
            this.kompliktaciyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kompliktaciyaDataGridViewTextBoxColumn.Name = "kompliktaciyaDataGridViewTextBoxColumn";
            this.kompliktaciyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolichestvoDataGridViewTextBoxColumn
            // 
            this.kolichestvoDataGridViewTextBoxColumn.DataPropertyName = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.HeaderText = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolichestvoDataGridViewTextBoxColumn.Name = "kolichestvoDataGridViewTextBoxColumn";
            this.kolichestvoDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // moshchnostDataGridViewTextBoxColumn
            // 
            this.moshchnostDataGridViewTextBoxColumn.DataPropertyName = "Moshchnost";
            this.moshchnostDataGridViewTextBoxColumn.HeaderText = "Moshchnost";
            this.moshchnostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moshchnostDataGridViewTextBoxColumn.Name = "moshchnostDataGridViewTextBoxColumn";
            this.moshchnostDataGridViewTextBoxColumn.Width = 125;
            // 
            // datavypuskaDataGridViewTextBoxColumn
            // 
            this.datavypuskaDataGridViewTextBoxColumn.DataPropertyName = "Data_vypuska";
            this.datavypuskaDataGridViewTextBoxColumn.HeaderText = "Data_vypuska";
            this.datavypuskaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datavypuskaDataGridViewTextBoxColumn.Name = "datavypuskaDataGridViewTextBoxColumn";
            this.datavypuskaDataGridViewTextBoxColumn.Width = 125;
            // 
            // avtomobilBindingSource2
            // 
            this.avtomobilBindingSource2.DataMember = "Avtomobil";
            this.avtomobilBindingSource2.DataSource = this.cherepanov_avtosalonDataSet;
            // 
            // cherepanov_avtosalonDataSet
            // 
            this.cherepanov_avtosalonDataSet.DataSetName = "Cherepanov_avtosalonDataSet";
            this.cherepanov_avtosalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtomobilBindingSource1
            // 
            this.avtomobilBindingSource1.DataMember = "Avtomobil";
            this.avtomobilBindingSource1.DataSource = this.cherepanovavtosalonDataSetBindingSource;
            // 
            // cherepanovavtosalonDataSetBindingSource
            // 
            this.cherepanovavtosalonDataSetBindingSource.DataSource = this.cherepanovavtosalonDataSet;
            this.cherepanovavtosalonDataSetBindingSource.Position = 0;
            // 
            // cherepanovavtosalonDataSet
            // 
            this.cherepanovavtosalonDataSet.DataSetName = "CherepanovavtosalonDataSet";
            this.cherepanovavtosalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtomobilBindingSource
            // 
            this.avtomobilBindingSource.DataMember = "Avtomobil";
            this.avtomobilBindingSource.DataSource = this.cherepanov_avtosalonDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Location = new System.Drawing.Point(367, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.textBox1.Location = new System.Drawing.Point(188, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = " ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.textBox2.Location = new System.Drawing.Point(188, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // avtomobilTableAdapter
            // 
            this.avtomobilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название компликтации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Динамический поиск";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Location = new System.Drawing.Point(15, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Location = new System.Drawing.Point(276, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить автомобиль";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.Location = new System.Drawing.Point(463, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button5.Location = new System.Drawing.Point(958, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // avtomobilTableAdapter1
            // 
            this.avtomobilTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button6.Location = new System.Drawing.Point(958, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 26);
            this.button6.TabIndex = 12;
            this.button6.Text = "Обновление";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button7.Location = new System.Drawing.Point(694, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 26);
            this.button7.TabIndex = 13;
            this.button7.Text = "Сортировка по автомобилем";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button8.Location = new System.Drawing.Point(105, 422);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 26);
            this.button8.TabIndex = 14;
            this.button8.Text = "Добавить заявку";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // avtomobilBindingSource3
            // 
            this.avtomobilBindingSource3.DataMember = "Avtomobil";
            this.avtomobilBindingSource3.DataSource = this.cherepanovavtosalonDataSetBindingSource;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button9.Location = new System.Drawing.Point(694, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(216, 26);
            this.button9.TabIndex = 15;
            this.button9.Text = "Сортировка по цветам";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button10.Location = new System.Drawing.Point(694, 383);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(216, 26);
            this.button10.TabIndex = 16;
            this.button10.Text = "Сортировка по ценам";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(9, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(616, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Location = new System.Drawing.Point(12, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(616, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1080, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avtomobil";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanov_avtosalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherepanovavtosalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Cherepanov_avtosalonDataSet cherepanov_avtosalonDataSet;
        private System.Windows.Forms.BindingSource avtomobilBindingSource;
        private Cherepanov_avtosalonDataSetTableAdapters.AvtomobilTableAdapter avtomobilTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource cherepanovavtosalonDataSetBindingSource;
        private CherepanovavtosalonDataSet cherepanovavtosalonDataSet;
        private System.Windows.Forms.BindingSource avtomobilBindingSource1;
        private CherepanovavtosalonDataSetTableAdapters.AvtomobilTableAdapter avtomobilTableAdapter1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodavtomobilyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompliktaciyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshchnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavypuskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource avtomobilBindingSource2;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource avtomobilBindingSource3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}