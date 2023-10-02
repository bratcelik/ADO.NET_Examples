namespace ADO.NET_ile_Veritabani_Programlama
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
            txtId = new TextBox();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnList = new Button();
            button1 = new Button();
            label4 = new Label();
            txtById = new TextBox();
            northwindTabs = new TabControl();
            sirketTab = new TabPage();
            kategoriTab = new TabPage();
            lblStokAdet = new Label();
            label12 = new Label();
            lblBirimFiyat = new Label();
            label14 = new Label();
            lblUrunAd = new Label();
            label10 = new Label();
            lblUrunNo = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmbProduct = new ComboBox();
            label5 = new Label();
            cmbCategory = new ComboBox();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            northwindTabs.SuspendLayout();
            sirketTab.SuspendLayout();
            kategoriTab.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(866, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(80, 27);
            txtId.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(776, 82);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(170, 27);
            txtAd.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(776, 149);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(170, 27);
            txtTelefon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 19);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Şirket ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 82);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Şirket Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 152);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Şirket Telefonu";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(601, 207);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Veri Ekle";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(714, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Veri Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(849, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Veri Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(557, 276);
            dataGridView1.TabIndex = 9;
            // 
            // btnList
            // 
            btnList.Location = new Point(29, 319);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 10;
            btnList.Text = "Get List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(183, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "GetByID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 367);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 13;
            label4.Text = "Şirket ID";
            // 
            // txtById
            // 
            txtById.Location = new Point(197, 364);
            txtById.Name = "txtById";
            txtById.Size = new Size(80, 27);
            txtById.TabIndex = 12;
            // 
            // northwindTabs
            // 
            northwindTabs.Controls.Add(sirketTab);
            northwindTabs.Controls.Add(kategoriTab);
            northwindTabs.Controls.Add(tabPage3);
            northwindTabs.Location = new Point(15, 22);
            northwindTabs.Name = "northwindTabs";
            northwindTabs.SelectedIndex = 0;
            northwindTabs.Size = new Size(1011, 520);
            northwindTabs.TabIndex = 14;
            northwindTabs.Selected += northwindTabs_Selected;
            // 
            // sirketTab
            // 
            sirketTab.Controls.Add(txtId);
            sirketTab.Controls.Add(label4);
            sirketTab.Controls.Add(txtAd);
            sirketTab.Controls.Add(txtById);
            sirketTab.Controls.Add(txtTelefon);
            sirketTab.Controls.Add(button1);
            sirketTab.Controls.Add(label1);
            sirketTab.Controls.Add(btnList);
            sirketTab.Controls.Add(label2);
            sirketTab.Controls.Add(dataGridView1);
            sirketTab.Controls.Add(label3);
            sirketTab.Controls.Add(btnDelete);
            sirketTab.Controls.Add(btnInsert);
            sirketTab.Controls.Add(btnUpdate);
            sirketTab.Location = new Point(4, 29);
            sirketTab.Name = "sirketTab";
            sirketTab.Padding = new Padding(3);
            sirketTab.Size = new Size(1003, 487);
            sirketTab.TabIndex = 0;
            sirketTab.Text = "Şirketler";
            sirketTab.UseVisualStyleBackColor = true;
            // 
            // kategoriTab
            // 
            kategoriTab.Controls.Add(lblStokAdet);
            kategoriTab.Controls.Add(label12);
            kategoriTab.Controls.Add(lblBirimFiyat);
            kategoriTab.Controls.Add(label14);
            kategoriTab.Controls.Add(lblUrunAd);
            kategoriTab.Controls.Add(label10);
            kategoriTab.Controls.Add(lblUrunNo);
            kategoriTab.Controls.Add(label9);
            kategoriTab.Controls.Add(label7);
            kategoriTab.Controls.Add(label6);
            kategoriTab.Controls.Add(cmbProduct);
            kategoriTab.Controls.Add(label5);
            kategoriTab.Controls.Add(cmbCategory);
            kategoriTab.Location = new Point(4, 29);
            kategoriTab.Name = "kategoriTab";
            kategoriTab.Padding = new Padding(3);
            kategoriTab.Size = new Size(1003, 487);
            kategoriTab.TabIndex = 1;
            kategoriTab.Text = "Kategoriler";
            kategoriTab.UseVisualStyleBackColor = true;
            // 
            // lblStokAdet
            // 
            lblStokAdet.AutoSize = true;
            lblStokAdet.Location = new Point(753, 155);
            lblStokAdet.Name = "lblStokAdet";
            lblStokAdet.Size = new Size(0, 20);
            lblStokAdet.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImageAlign = ContentAlignment.MiddleRight;
            label12.Location = new Point(651, 155);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 13;
            label12.Text = "Stok Adet:";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Location = new Point(753, 124);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(0, 20);
            lblBirimFiyat.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImageAlign = ContentAlignment.MiddleRight;
            label14.Location = new Point(646, 124);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 11;
            label14.Text = "Birim Fiyat:";
            // 
            // lblUrunAd
            // 
            lblUrunAd.AutoSize = true;
            lblUrunAd.Location = new Point(753, 95);
            lblUrunAd.Name = "lblUrunAd";
            lblUrunAd.Size = new Size(0, 20);
            lblUrunAd.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(659, 95);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 9;
            label10.Text = "Ürün Ad: ";
            // 
            // lblUrunNo
            // 
            lblUrunNo.AutoSize = true;
            lblUrunNo.Location = new Point(753, 64);
            lblUrunNo.Name = "lblUrunNo";
            lblUrunNo.Size = new Size(0, 20);
            lblUrunNo.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(659, 64);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 7;
            label9.Text = "Ürün ID: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(658, 29);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 5;
            label7.Text = "Ürün Detayları";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 97);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 4;
            label6.Text = "Ürünler";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(30, 124);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 3;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 29);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 2;
            label5.Text = "Kategori";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(30, 56);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1003, 487);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 554);
            Controls.Add(northwindTabs);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            northwindTabs.ResumeLayout(false);
            sirketTab.ResumeLayout(false);
            sirketTab.PerformLayout();
            kategoriTab.ResumeLayout(false);
            kategoriTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtId;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnList;
        private Button button1;
        private Label label4;
        private TextBox txtById;
        private TabControl northwindTabs;
        private TabPage sirketTab;
        private TabPage kategoriTab;
        private TabPage tabPage3;
        private Label label9;
        private Label label7;
        private Label label6;
        private ComboBox cmbProduct;
        private Label label5;
        private ComboBox cmbCategory;
        private Label lblStokAdet;
        private Label label12;
        private Label lblBirimFiyat;
        private Label label14;
        private Label lblUrunAd;
        private Label label10;
        private Label lblUrunNo;
    }
}