namespace DatabaseForm
{
    partial class DatabaseFormOphalen
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
            this.Pgebied = new System.Windows.Forms.Label();
            this.Pplaats = new System.Windows.Forms.Label();
            this.Padres = new System.Windows.Forms.Label();
            this.aantal_zitplaatsen = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.Label();
            this.naam = new System.Windows.Forms.Label();
            this.annuleren = new System.Windows.Forms.Button();
            this.ophalen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataset_RotterdamDataSet = new DatabaseForm.Dataset_RotterdamDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new DatabaseForm.Dataset_RotterdamDataSetTableAdapters.parkingTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aANTALPLEKKENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEBIEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pgebied
            // 
            this.Pgebied.AutoSize = true;
            this.Pgebied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgebied.Location = new System.Drawing.Point(916, 21);
            this.Pgebied.Name = "Pgebied";
            this.Pgebied.Size = new System.Drawing.Size(59, 16);
            this.Pgebied.TabIndex = 38;
            this.Pgebied.Text = "Gebied";
            // 
            // Pplaats
            // 
            this.Pplaats.AutoSize = true;
            this.Pplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplaats.Location = new System.Drawing.Point(782, 21);
            this.Pplaats.Name = "Pplaats";
            this.Pplaats.Size = new System.Drawing.Size(52, 16);
            this.Pplaats.TabIndex = 37;
            this.Pplaats.Text = "Plaats";
            // 
            // Padres
            // 
            this.Padres.AutoSize = true;
            this.Padres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padres.Location = new System.Drawing.Point(568, 21);
            this.Padres.Name = "Padres";
            this.Padres.Size = new System.Drawing.Size(49, 16);
            this.Padres.TabIndex = 36;
            this.Padres.Text = "Adres";
            // 
            // aantal_zitplaatsen
            // 
            this.aantal_zitplaatsen.AutoSize = true;
            this.aantal_zitplaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_zitplaatsen.Location = new System.Drawing.Point(382, 21);
            this.aantal_zitplaatsen.Name = "aantal_zitplaatsen";
            this.aantal_zitplaatsen.Size = new System.Drawing.Size(116, 16);
            this.aantal_zitplaatsen.TabIndex = 35;
            this.aantal_zitplaatsen.Text = "Aantal plaatsen";
            // 
            // Ptype
            // 
            this.Ptype.AutoSize = true;
            this.Ptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptype.Location = new System.Drawing.Point(292, 21);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(44, 16);
            this.Ptype.TabIndex = 34;
            this.Ptype.Text = "Type";
            // 
            // naam
            // 
            this.naam.AutoSize = true;
            this.naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam.Location = new System.Drawing.Point(101, 21);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(49, 16);
            this.naam.TabIndex = 32;
            this.naam.Text = "Naam";
            // 
            // annuleren
            // 
            this.annuleren.Location = new System.Drawing.Point(584, 362);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(75, 23);
            this.annuleren.TabIndex = 30;
            this.annuleren.Text = "annuleren";
            this.annuleren.UseVisualStyleBackColor = true;
            // 
            // ophalen
            // 
            this.ophalen.Location = new System.Drawing.Point(439, 362);
            this.ophalen.Name = "ophalen";
            this.ophalen.Size = new System.Drawing.Size(75, 23);
            this.ophalen.TabIndex = 29;
            this.ophalen.Text = "ophalen";
            this.ophalen.UseVisualStyleBackColor = true;
            this.ophalen.Click += new System.EventHandler(this.ophalen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn,
            this.aANTALPLEKKENDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.pLAATSDataGridViewTextBoxColumn,
            this.gEBIEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 232);
            this.dataGridView1.TabIndex = 47;
            // 
            // dataset_RotterdamDataSet
            // 
            this.dataset_RotterdamDataSet.DataSetName = "Dataset_RotterdamDataSet";
            this.dataset_RotterdamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "parking";
            this.parkingBindingSource.DataSource = this.dataset_RotterdamDataSet;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.parkingBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            // 
            // aANTALPLEKKENDataGridViewTextBoxColumn
            // 
            this.aANTALPLEKKENDataGridViewTextBoxColumn.DataPropertyName = "AANTAL_PLEKKEN";
            this.aANTALPLEKKENDataGridViewTextBoxColumn.HeaderText = "AANTAL_PLEKKEN";
            this.aANTALPLEKKENDataGridViewTextBoxColumn.Name = "aANTALPLEKKENDataGridViewTextBoxColumn";
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            // 
            // pLAATSDataGridViewTextBoxColumn
            // 
            this.pLAATSDataGridViewTextBoxColumn.DataPropertyName = "PLAATS";
            this.pLAATSDataGridViewTextBoxColumn.HeaderText = "PLAATS";
            this.pLAATSDataGridViewTextBoxColumn.Name = "pLAATSDataGridViewTextBoxColumn";
            // 
            // gEBIEDDataGridViewTextBoxColumn
            // 
            this.gEBIEDDataGridViewTextBoxColumn.DataPropertyName = "GEBIED";
            this.gEBIEDDataGridViewTextBoxColumn.HeaderText = "GEBIED";
            this.gEBIEDDataGridViewTextBoxColumn.Name = "gEBIEDDataGridViewTextBoxColumn";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.parkingBindingSource;
            this.comboBox2.DisplayMember = "TYPE";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 50;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.parkingBindingSource;
            this.comboBox3.DisplayMember = "AANTAL_PLEKKEN";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(405, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 21);
            this.comboBox3.TabIndex = 51;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.parkingBindingSource;
            this.comboBox4.DisplayMember = "ADRES";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(466, 40);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(262, 21);
            this.comboBox4.TabIndex = 52;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.parkingBindingSource;
            this.comboBox5.DisplayMember = "PLAATS";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(734, 40);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(138, 21);
            this.comboBox5.TabIndex = 53;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.parkingBindingSource;
            this.comboBox6.DisplayMember = "GEBIED";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(878, 40);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(131, 21);
            this.comboBox6.TabIndex = 54;
            // 
            // DatabaseFormOphalen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 414);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pgebied);
            this.Controls.Add(this.Pplaats);
            this.Controls.Add(this.Padres);
            this.Controls.Add(this.aantal_zitplaatsen);
            this.Controls.Add(this.Ptype);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.annuleren);
            this.Controls.Add(this.ophalen);
            this.Name = "DatabaseFormOphalen";
            this.Text = "DatabaseFormOphalen";
            this.Load += new System.EventHandler(this.DatabaseFormOphalen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Pgebied;
        private System.Windows.Forms.Label Pplaats;
        private System.Windows.Forms.Label Padres;
        private System.Windows.Forms.Label aantal_zitplaatsen;
        private System.Windows.Forms.Label Ptype;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Button annuleren;
        private System.Windows.Forms.Button ophalen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Dataset_RotterdamDataSet dataset_RotterdamDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private Dataset_RotterdamDataSetTableAdapters.parkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aANTALPLEKKENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEBIEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}