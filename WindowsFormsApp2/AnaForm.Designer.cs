namespace WindowsFormsApp2
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meslek = new System.Windows.Forms.TextBox();
            this.meslekl = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.duruml = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.MaskedTextBox();
            this.maasl = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.TextBox();
            this.sehirl = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.persoyadl = new System.Windows.Forms.Label();
            this.perad = new System.Windows.Forms.TextBox();
            this.peradl = new System.Windows.Forms.Label();
            this.perid = new System.Windows.Forms.TextBox();
            this.peridl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafikbtn = new System.Windows.Forms.Button();
            this.istatistikbtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_DatabaseDataSet = new WindowsFormsApp2.Personel_DatabaseDataSet();
            this.perTable1TableAdapter = new WindowsFormsApp2.Personel_DatabaseDataSetTableAdapters.PerTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meslek);
            this.groupBox1.Controls.Add(this.meslekl);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.duruml);
            this.groupBox1.Controls.Add(this.maas);
            this.groupBox1.Controls.Add(this.maasl);
            this.groupBox1.Controls.Add(this.sehir);
            this.groupBox1.Controls.Add(this.sehirl);
            this.groupBox1.Controls.Add(this.soyad);
            this.groupBox1.Controls.Add(this.persoyadl);
            this.groupBox1.Controls.Add(this.perad);
            this.groupBox1.Controls.Add(this.peradl);
            this.groupBox1.Controls.Add(this.perid);
            this.groupBox1.Controls.Add(this.peridl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // meslek
            // 
            this.meslek.Location = new System.Drawing.Point(147, 189);
            this.meslek.Name = "meslek";
            this.meslek.Size = new System.Drawing.Size(115, 20);
            this.meslek.TabIndex = 14;
            // 
            // meslekl
            // 
            this.meslekl.AutoSize = true;
            this.meslekl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.meslekl.Location = new System.Drawing.Point(70, 184);
            this.meslekl.Name = "meslekl";
            this.meslekl.Size = new System.Drawing.Size(70, 24);
            this.meslekl.TabIndex = 13;
            this.meslekl.Text = "Meslek";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(195, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(147, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // duruml
            // 
            this.duruml.AutoSize = true;
            this.duruml.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.duruml.Location = new System.Drawing.Point(58, 158);
            this.duruml.Name = "duruml";
            this.duruml.Size = new System.Drawing.Size(82, 24);
            this.duruml.TabIndex = 10;
            this.duruml.Text = "Durum . ";
            // 
            // maas
            // 
            this.maas.Location = new System.Drawing.Point(146, 139);
            this.maas.Mask = "0000";
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(115, 20);
            this.maas.TabIndex = 9;
            this.maas.ValidatingType = typeof(int);
            // 
            // maasl
            // 
            this.maasl.AutoSize = true;
            this.maasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maasl.Location = new System.Drawing.Point(75, 134);
            this.maasl.Name = "maasl";
            this.maasl.Size = new System.Drawing.Size(65, 24);
            this.maasl.TabIndex = 8;
            this.maasl.Text = "Maas :";
            // 
            // sehir
            // 
            this.sehir.Location = new System.Drawing.Point(146, 115);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(115, 20);
            this.sehir.TabIndex = 7;
            // 
            // sehirl
            // 
            this.sehirl.AutoSize = true;
            this.sehirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sehirl.Location = new System.Drawing.Point(76, 110);
            this.sehirl.Name = "sehirl";
            this.sehirl.Size = new System.Drawing.Size(64, 24);
            this.sehirl.TabIndex = 6;
            this.sehirl.Text = "Sehir :";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(146, 89);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(115, 20);
            this.soyad.TabIndex = 5;
            // 
            // persoyadl
            // 
            this.persoyadl.AutoSize = true;
            this.persoyadl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.persoyadl.Location = new System.Drawing.Point(67, 84);
            this.persoyadl.Name = "persoyadl";
            this.persoyadl.Size = new System.Drawing.Size(73, 24);
            this.persoyadl.TabIndex = 4;
            this.persoyadl.Text = "Soyad :";
            // 
            // perad
            // 
            this.perad.Location = new System.Drawing.Point(146, 63);
            this.perad.Name = "perad";
            this.perad.Size = new System.Drawing.Size(115, 20);
            this.perad.TabIndex = 1;
            // 
            // peradl
            // 
            this.peradl.AutoSize = true;
            this.peradl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.peradl.Location = new System.Drawing.Point(16, 58);
            this.peradl.Name = "peradl";
            this.peradl.Size = new System.Drawing.Size(124, 24);
            this.peradl.TabIndex = 2;
            this.peradl.Text = "Personel Ad :";
            // 
            // perid
            // 
            this.perid.Location = new System.Drawing.Point(146, 37);
            this.perid.Name = "perid";
            this.perid.Size = new System.Drawing.Size(115, 20);
            this.perid.TabIndex = 222;
            // 
            // peridl
            // 
            this.peridl.AutoSize = true;
            this.peridl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.peridl.Location = new System.Drawing.Point(25, 32);
            this.peridl.Name = "peridl";
            this.peridl.Size = new System.Drawing.Size(115, 24);
            this.peridl.TabIndex = 0;
            this.peridl.Text = "Personel İd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grafikbtn);
            this.groupBox2.Controls.Add(this.istatistikbtn);
            this.groupBox2.Controls.Add(this.temizlebtn);
            this.groupBox2.Controls.Add(this.guncellebtn);
            this.groupBox2.Controls.Add(this.silbtn);
            this.groupBox2.Controls.Add(this.kaydetbtn);
            this.groupBox2.Controls.Add(this.listelebtn);
            this.groupBox2.Location = new System.Drawing.Point(347, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // grafikbtn
            // 
            this.grafikbtn.Location = new System.Drawing.Point(65, 240);
            this.grafikbtn.Name = "grafikbtn";
            this.grafikbtn.Size = new System.Drawing.Size(126, 31);
            this.grafikbtn.TabIndex = 6;
            this.grafikbtn.Text = "Grafikler";
            this.grafikbtn.UseVisualStyleBackColor = true;
            this.grafikbtn.Click += new System.EventHandler(this.grafikbtn_Click);
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.Location = new System.Drawing.Point(65, 203);
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.Size = new System.Drawing.Size(126, 31);
            this.istatistikbtn.TabIndex = 5;
            this.istatistikbtn.Text = "İstatistik";
            this.istatistikbtn.UseVisualStyleBackColor = true;
            this.istatistikbtn.Click += new System.EventHandler(this.istatistikbtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(65, 166);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(126, 31);
            this.temizlebtn.TabIndex = 4;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(65, 129);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(126, 31);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(65, 92);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(126, 31);
            this.silbtn.TabIndex = 2;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(65, 56);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(126, 31);
            this.kaydetbtn.TabIndex = 1;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(65, 19);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(126, 31);
            this.listelebtn.TabIndex = 0;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaaşDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 130);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaaşDataGridViewTextBoxColumn
            // 
            this.perMaaşDataGridViewTextBoxColumn.DataPropertyName = "PerMaaş";
            this.perMaaşDataGridViewTextBoxColumn.HeaderText = "PerMaaş";
            this.perMaaşDataGridViewTextBoxColumn.Name = "perMaaşDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // perTable1BindingSource
            // 
            this.perTable1BindingSource.DataMember = "PerTable1";
            this.perTable1BindingSource.DataSource = this.personel_DatabaseDataSet;
            // 
            // personel_DatabaseDataSet
            // 
            this.personel_DatabaseDataSet.DataSetName = "Personel_DatabaseDataSet";
            this.personel_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perTable1TableAdapter
            // 
            this.perTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(659, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox meslek;
        private System.Windows.Forms.Label meslekl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label duruml;
        private System.Windows.Forms.MaskedTextBox maas;
        private System.Windows.Forms.Label maasl;
        private System.Windows.Forms.TextBox sehir;
        private System.Windows.Forms.Label sehirl;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label persoyadl;
        private System.Windows.Forms.TextBox perad;
        private System.Windows.Forms.Label peradl;
        private System.Windows.Forms.TextBox perid;
        private System.Windows.Forms.Label peridl;
        private System.Windows.Forms.Button grafikbtn;
        private System.Windows.Forms.Button istatistikbtn;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_DatabaseDataSet personel_DatabaseDataSet;
        private System.Windows.Forms.BindingSource perTable1BindingSource;
        private Personel_DatabaseDataSetTableAdapters.PerTable1TableAdapter perTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

