
namespace Projektki
{
    partial class FizioCentarKopett
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
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label brojLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pacjentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Projektki.Database1DataSet1();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.brojTextBox = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anamnezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakljucakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nalaz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Imee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povjestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pacjentiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.povjestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacjentiTableAdapter = new Projektki.Database1DataSet1TableAdapters.PacjentiTableAdapter();
            this.tableAdapterManager = new Projektki.Database1DataSet1TableAdapters.TableAdapterManager();
            this.povjestTableAdapter = new Projektki.Database1DataSet1TableAdapters.povjestTableAdapter();
            this.database1DataSet11 = new Projektki.Database1DataSet1();
            this.DatumTextBox = new System.Windows.Forms.TextBox();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            mobLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            brojLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacjentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povjestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjentiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povjestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(41, 180);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(31, 13);
            mobLabel.TabIndex = 5;
            mobLabel.Text = "Mob:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(29, 155);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 7;
            adresaLabel.Text = "Adresa:";
            // 
            // brojLabel
            // 
            brojLabel.AutoSize = true;
            brojLabel.Location = new System.Drawing.Point(249, 102);
            brojLabel.Name = "brojLabel";
            brojLabel.Size = new System.Drawing.Size(85, 13);
            brojLabel.TabIndex = 9;
            brojLabel.Text = "Datum Rođenja:";
            brojLabel.Click += new System.EventHandler(this.brojLabel_Click);
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(37, 206);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(34, 13);
            oIBLabel.TabIndex = 11;
            oIBLabel.Text = "MBO:";
            oIBLabel.Click += new System.EventHandler(this.oIBLabel_Click);
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(0, 102);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(72, 13);
            imeLabel.TabIndex = 13;
            imeLabel.Text = "Ime i Prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 23;
            label2.Text = "Spol:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(296, 129);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 25;
            label1.Text = "E-mail:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pacjentiBindingSource, "Ime", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pacjentiBindingSource, "Ime", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // pacjentiBindingSource
            // 
            this.pacjentiBindingSource.DataMember = "Pacjenti";
            this.pacjentiBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjentiBindingSource, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(77, 177);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(113, 20);
            this.mobTextBox.TabIndex = 6;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjentiBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(77, 152);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(113, 20);
            this.adresaTextBox.TabIndex = 8;
            // 
            // brojTextBox
            // 
            this.brojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjentiBindingSource, "Broj", true));
            this.brojTextBox.Location = new System.Drawing.Point(77, 126);
            this.brojTextBox.Name = "brojTextBox";
            this.brojTextBox.Size = new System.Drawing.Size(113, 20);
            this.brojTextBox.TabIndex = 10;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjentiBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(77, 203);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(113, 20);
            this.oIBTextBox.TabIndex = 12;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjentiBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(77, 99);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(162, 20);
            this.imeTextBox.TabIndex = 14;
            this.imeTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.anamnezaDataGridViewTextBoxColumn,
            this.terapijaDataGridViewTextBoxColumn,
            this.zakljucakDataGridViewTextBoxColumn,
            this.datmDataGridViewTextBoxColumn,
            this.Nalaz,
            this.Imee});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.povjestBindingSource1, "Imee", true));
            this.dataGridView1.DataSource = this.povjestBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(24, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 330);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.Frozen = true;
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // anamnezaDataGridViewTextBoxColumn
            // 
            this.anamnezaDataGridViewTextBoxColumn.DataPropertyName = "Anamneza";
            this.anamnezaDataGridViewTextBoxColumn.FillWeight = 95.01827F;
            this.anamnezaDataGridViewTextBoxColumn.HeaderText = "Anamneza";
            this.anamnezaDataGridViewTextBoxColumn.Name = "anamnezaDataGridViewTextBoxColumn";
            // 
            // terapijaDataGridViewTextBoxColumn
            // 
            this.terapijaDataGridViewTextBoxColumn.DataPropertyName = "Terapija";
            this.terapijaDataGridViewTextBoxColumn.FillWeight = 95.01827F;
            this.terapijaDataGridViewTextBoxColumn.HeaderText = "Terapija";
            this.terapijaDataGridViewTextBoxColumn.Name = "terapijaDataGridViewTextBoxColumn";
            // 
            // zakljucakDataGridViewTextBoxColumn
            // 
            this.zakljucakDataGridViewTextBoxColumn.DataPropertyName = "Zakljucak";
            this.zakljucakDataGridViewTextBoxColumn.FillWeight = 95.01827F;
            this.zakljucakDataGridViewTextBoxColumn.HeaderText = "Zakljucak";
            this.zakljucakDataGridViewTextBoxColumn.Name = "zakljucakDataGridViewTextBoxColumn";
            // 
            // datmDataGridViewTextBoxColumn
            // 
            this.datmDataGridViewTextBoxColumn.DataPropertyName = "Datm";
            this.datmDataGridViewTextBoxColumn.FillWeight = 30F;
            this.datmDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datmDataGridViewTextBoxColumn.Name = "datmDataGridViewTextBoxColumn";
            // 
            // Nalaz
            // 
            this.Nalaz.FillWeight = 20F;
            this.Nalaz.HeaderText = "Nalaz";
            this.Nalaz.Name = "Nalaz";
            this.Nalaz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nalaz.Text = "Nalaz";
            // 
            // Imee
            // 
            this.Imee.DataPropertyName = "Imee";
            this.Imee.HeaderText = "Imee";
            this.Imee.Name = "Imee";
            this.Imee.Visible = false;
            // 
            // povjestBindingSource1
            // 
            this.povjestBindingSource1.DataMember = "povjest";
            this.povjestBindingSource1.DataSource = this.database1DataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodavanje Pacjenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 61);
            this.button2.TabIndex = 18;
            this.button2.Text = "Dodavanje detalja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 60);
            this.button3.TabIndex = 19;
            this.button3.Text = "Izmjena detalja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 47);
            this.button4.TabIndex = 20;
            this.button4.Text = "Update Pacjenta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pacjentiBindingSource1
            // 
            this.pacjentiBindingSource1.DataMember = "Pacjenti";
            this.pacjentiBindingSource1.DataSource = this.database1DataSet1;
            // 
            // povjestBindingSource
            // 
            this.povjestBindingSource.DataMember = "povjest";
            this.povjestBindingSource.DataSource = this.database1DataSet1;
            // 
            // pacjentiTableAdapter
            // 
            this.pacjentiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pacjenti1TableAdapter = null;
            this.tableAdapterManager.PacjentiTableAdapter = this.pacjentiTableAdapter;
            this.tableAdapterManager.povjest1TableAdapter = null;
            this.tableAdapterManager.povjestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projektki.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // povjestTableAdapter
            // 
            this.povjestTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "data";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatumTextBox
            // 
            this.DatumTextBox.Location = new System.Drawing.Point(340, 99);
            this.DatumTextBox.Name = "DatumTextBox";
            this.DatumTextBox.Size = new System.Drawing.Size(126, 20);
            this.DatumTextBox.TabIndex = 21;
            // 
            // MailtextBox
            // 
            this.MailtextBox.Location = new System.Drawing.Point(340, 125);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(126, 20);
            this.MailtextBox.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(922, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 60);
            this.button5.TabIndex = 26;
            this.button5.Text = "Brisanje detalja";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(448, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 47);
            this.button6.TabIndex = 27;
            this.button6.Text = "Brisanje Pacjenta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FizioCentarKopett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 617);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(label1);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.DatumTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.oIBTextBox);
            this.Controls.Add(brojLabel);
            this.Controls.Add(this.brojTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(mobLabel);
            this.Controls.Add(this.mobTextBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "FizioCentarKopett";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacjentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povjestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjentiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povjestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource pacjentiBindingSource;
        private Database1DataSet1TableAdapters.PacjentiTableAdapter pacjentiTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox brojTextBox;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.BindingSource pacjentiBindingSource1;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.BindingSource povjestBindingSource;
        private Database1DataSet1TableAdapters.povjestTableAdapter povjestTableAdapter;
        private Database1DataSet1 database1DataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource povjestBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox DatumTextBox;
        private System.Windows.Forms.TextBox MailtextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anamnezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakljucakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Nalaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imee;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}