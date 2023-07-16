namespace ExchangeApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lblAlis = new Label();
            lblSatis = new Label();
            groupBox1 = new GroupBox();
            btnHesapla2 = new Button();
            btnHesapla1 = new Button();
            tbxKalan = new TextBox();
            tbxMiktar = new TextBox();
            tbxTutar = new TextBox();
            tbxKur = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnAlis = new Button();
            btnSatis = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ParaBirimi = new DataGridViewTextBoxColumn();
            AlisFiyati = new DataGridViewTextBoxColumn();
            SatisFiyati = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Alış :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 80);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Satış :";
            // 
            // lblAlis
            // 
            lblAlis.AutoSize = true;
            lblAlis.Location = new Point(484, 48);
            lblAlis.Name = "lblAlis";
            lblAlis.Size = new Size(17, 20);
            lblAlis.TabIndex = 0;
            lblAlis.Text = "0";
            // 
            // lblSatis
            // 
            lblSatis.AutoSize = true;
            lblSatis.Location = new Point(484, 80);
            lblSatis.Name = "lblSatis";
            lblSatis.Size = new Size(17, 20);
            lblSatis.TabIndex = 0;
            lblSatis.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapla2);
            groupBox1.Controls.Add(btnHesapla1);
            groupBox1.Controls.Add(tbxKalan);
            groupBox1.Controls.Add(tbxMiktar);
            groupBox1.Controls.Add(tbxTutar);
            groupBox1.Controls.Add(tbxKur);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(390, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnHesapla2
            // 
            btnHesapla2.Location = new Point(90, 216);
            btnHesapla2.Name = "btnHesapla2";
            btnHesapla2.Size = new Size(179, 29);
            btnHesapla2.TabIndex = 3;
            btnHesapla2.Text = "Tutara Göre Hesapla";
            btnHesapla2.UseVisualStyleBackColor = true;
            btnHesapla2.Click += btnHesapla2_Click;
            // 
            // btnHesapla1
            // 
            btnHesapla1.Location = new Point(89, 181);
            btnHesapla1.Name = "btnHesapla1";
            btnHesapla1.Size = new Size(180, 29);
            btnHesapla1.TabIndex = 3;
            btnHesapla1.Text = "Miktara Göre Hesapla";
            btnHesapla1.UseVisualStyleBackColor = true;
            btnHesapla1.Click += btnHesapla1_Click;
            // 
            // tbxKalan
            // 
            tbxKalan.Location = new Point(90, 133);
            tbxKalan.Name = "tbxKalan";
            tbxKalan.Size = new Size(179, 27);
            tbxKalan.TabIndex = 2;
            // 
            // tbxMiktar
            // 
            tbxMiktar.Location = new Point(90, 67);
            tbxMiktar.Name = "tbxMiktar";
            tbxMiktar.Size = new Size(179, 27);
            tbxMiktar.TabIndex = 2;
            // 
            // tbxTutar
            // 
            tbxTutar.Location = new Point(90, 100);
            tbxTutar.Name = "tbxTutar";
            tbxTutar.Size = new Size(179, 27);
            tbxTutar.TabIndex = 1;
            // 
            // tbxKur
            // 
            tbxKur.Enabled = false;
            tbxKur.Location = new Point(90, 34);
            tbxKur.Name = "tbxKur";
            tbxKur.Size = new Size(179, 27);
            tbxKur.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 41);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 0;
            label5.Text = "KUR :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 103);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 0;
            label6.Text = "TUTAR :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 136);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 0;
            label8.Text = "KALAN :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 70);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "MİKTAR :";
            // 
            // btnAlis
            // 
            btnAlis.Location = new Point(562, 48);
            btnAlis.Name = "btnAlis";
            btnAlis.Size = new Size(34, 24);
            btnAlis.TabIndex = 2;
            btnAlis.Text = "...";
            btnAlis.TextAlign = ContentAlignment.TopCenter;
            btnAlis.UseVisualStyleBackColor = true;
            btnAlis.Click += btnAlis_Click;
            // 
            // btnSatis
            // 
            btnSatis.Location = new Point(562, 78);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(34, 24);
            btnSatis.TabIndex = 2;
            btnSatis.Text = "...";
            btnSatis.TextAlign = ContentAlignment.TopCenter;
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Click += btnSatis_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(484, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 20);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Seçili Kur :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ParaBirimi, AlisFiyati, SatisFiyati });
            dataGridView1.Location = new Point(0, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(381, 438);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ParaBirimi
            // 
            ParaBirimi.HeaderText = "Para Birimi";
            ParaBirimi.MinimumWidth = 6;
            ParaBirimi.Name = "ParaBirimi";
            ParaBirimi.Width = 125;
            // 
            // AlisFiyati
            // 
            AlisFiyati.HeaderText = "Alış";
            AlisFiyati.MinimumWidth = 6;
            AlisFiyati.Name = "AlisFiyati";
            AlisFiyati.Width = 80;
            // 
            // SatisFiyati
            // 
            SatisFiyati.HeaderText = "Satış";
            SatisFiyati.MinimumWidth = 6;
            SatisFiyati.Name = "SatisFiyati";
            SatisFiyati.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(btnSatis);
            Controls.Add(btnAlis);
            Controls.Add(groupBox1);
            Controls.Add(lblSatis);
            Controls.Add(label2);
            Controls.Add(lblAlis);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblAlis;
        private Label lblSatis;
        private GroupBox groupBox1;
        private Button btnHesapla1;
        private TextBox tbxKalan;
        private TextBox tbxMiktar;
        private TextBox tbxTutar;
        private TextBox tbxKur;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Button btnAlis;
        private Button btnSatis;
        private Button btnHesapla2;
        private ComboBox comboBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ParaBirimi;
        private DataGridViewTextBoxColumn AlisFiyati;
        private DataGridViewTextBoxColumn SatisFiyati;
    }
}