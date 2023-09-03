namespace EntityProjeUygulaması
{
    partial class frmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTURUNAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTMARKA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTSTOK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTFIYAT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTDURUM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNLISTELE = new System.Windows.Forms.Button();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.BTNSIL = new System.Windows.Forms.Button();
            this.BTNGUNCELLE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CMBKATEGORI = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İD:";
            // 
            // TXTID
            // 
            this.TXTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTID.Location = new System.Drawing.Point(213, 40);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(153, 31);
            this.TXTID.TabIndex = 1;
            this.TXTID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTURUNAD
            // 
            this.TXTURUNAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTURUNAD.Location = new System.Drawing.Point(213, 72);
            this.TXTURUNAD.Name = "TXTURUNAD";
            this.TXTURUNAD.Size = new System.Drawing.Size(153, 31);
            this.TXTURUNAD.TabIndex = 3;
            this.TXTURUNAD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // TXTMARKA
            // 
            this.TXTMARKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTMARKA.Location = new System.Drawing.Point(213, 104);
            this.TXTMARKA.Name = "TXTMARKA";
            this.TXTMARKA.Size = new System.Drawing.Size(153, 31);
            this.TXTMARKA.TabIndex = 5;
            this.TXTMARKA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARKA:";
            // 
            // TXTSTOK
            // 
            this.TXTSTOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTSTOK.Location = new System.Drawing.Point(213, 136);
            this.TXTSTOK.Name = "TXTSTOK";
            this.TXTSTOK.Size = new System.Drawing.Size(153, 31);
            this.TXTSTOK.TabIndex = 7;
            this.TXTSTOK.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(146, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "STOK:";
            // 
            // TXTFIYAT
            // 
            this.TXTFIYAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTFIYAT.Location = new System.Drawing.Point(213, 168);
            this.TXTFIYAT.Name = "TXTFIYAT";
            this.TXTFIYAT.Size = new System.Drawing.Size(153, 31);
            this.TXTFIYAT.TabIndex = 9;
            this.TXTFIYAT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(143, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "FİYAT:";
            // 
            // TXTDURUM
            // 
            this.TXTDURUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTDURUM.Location = new System.Drawing.Point(213, 200);
            this.TXTDURUM.Name = "TXTDURUM";
            this.TXTDURUM.Size = new System.Drawing.Size(153, 31);
            this.TXTDURUM.TabIndex = 11;
            this.TXTDURUM.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(125, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "DURUM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "KATEGORİ:";
            // 
            // BTNLISTELE
            // 
            this.BTNLISTELE.Location = new System.Drawing.Point(395, 40);
            this.BTNLISTELE.Name = "BTNLISTELE";
            this.BTNLISTELE.Size = new System.Drawing.Size(151, 51);
            this.BTNLISTELE.TabIndex = 14;
            this.BTNLISTELE.Text = "LİSTELE";
            this.BTNLISTELE.UseVisualStyleBackColor = true;
            this.BTNLISTELE.Click += new System.EventHandler(this.BTNLISTELE_Click);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(395, 96);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(151, 51);
            this.BTNEKLE.TabIndex = 15;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // BTNSIL
            // 
            this.BTNSIL.Location = new System.Drawing.Point(395, 146);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(151, 51);
            this.BTNSIL.TabIndex = 16;
            this.BTNSIL.Text = "SİL";
            this.BTNSIL.UseVisualStyleBackColor = true;
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Location = new System.Drawing.Point(395, 196);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(151, 51);
            this.BTNGUNCELLE.TabIndex = 17;
            this.BTNGUNCELLE.Text = "GÜNCELLE";
            this.BTNGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 219);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CMBKATEGORI
            // 
            this.CMBKATEGORI.FormattingEnabled = true;
            this.CMBKATEGORI.Location = new System.Drawing.Point(213, 235);
            this.CMBKATEGORI.Name = "CMBKATEGORI";
            this.CMBKATEGORI.Size = new System.Drawing.Size(153, 28);
            this.CMBKATEGORI.TabIndex = 19;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 499);
            this.Controls.Add(this.CMBKATEGORI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNGUNCELLE);
            this.Controls.Add(this.BTNSIL);
            this.Controls.Add(this.BTNEKLE);
            this.Controls.Add(this.BTNLISTELE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTDURUM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTFIYAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTSTOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTMARKA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTURUNAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTURUNAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTMARKA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTSTOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTFIYAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTDURUM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNLISTELE;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Button BTNSIL;
        private System.Windows.Forms.Button BTNGUNCELLE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CMBKATEGORI;
    }
}