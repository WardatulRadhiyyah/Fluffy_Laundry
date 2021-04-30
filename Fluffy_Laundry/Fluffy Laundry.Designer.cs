
namespace Fluffy_Laundry
{
    partial class Data_Pemesanan
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
            this.Judul = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbltglPemesanan = new System.Windows.Forms.Label();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.lblnohp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbjenispaket = new System.Windows.Forms.ComboBox();
            this.tbhargatotal = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.tbberat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.lbltgl = new System.Windows.Forms.Label();
            this.lblhrgT = new System.Windows.Forms.Label();
            this.lblharga = new System.Windows.Forms.Label();
            this.lbljenis = new System.Windows.Forms.Label();
            this.lblberat = new System.Windows.Forms.Label();
            this.lblnama = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.BackColor = System.Drawing.Color.Plum;
            this.Judul.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Judul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Judul.Location = new System.Drawing.Point(273, 23);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(363, 28);
            this.Judul.TabIndex = 0;
            this.Judul.Text = "FLUFFY LAUNDRY";
            this.Judul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Judul.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lbltglPemesanan);
            this.groupBox1.Controls.Add(this.tbnohp);
            this.groupBox1.Controls.Add(this.lblnohp);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tbjenispaket);
            this.groupBox1.Controls.Add(this.tbhargatotal);
            this.groupBox1.Controls.Add(this.tbharga);
            this.groupBox1.Controls.Add(this.tbberat);
            this.groupBox1.Controls.Add(this.tbnama);
            this.groupBox1.Controls.Add(this.lbltgl);
            this.groupBox1.Controls.Add(this.lblhrgT);
            this.groupBox1.Controls.Add(this.lblharga);
            this.groupBox1.Controls.Add(this.lbljenis);
            this.groupBox1.Controls.Add(this.lblberat);
            this.groupBox1.Controls.Add(this.lblnama);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 445);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pemesanan";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 348);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 31);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lbltglPemesanan
            // 
            this.lbltglPemesanan.AutoSize = true;
            this.lbltglPemesanan.Location = new System.Drawing.Point(17, 348);
            this.lbltglPemesanan.Name = "lbltglPemesanan";
            this.lbltglPemesanan.Size = new System.Drawing.Size(175, 25);
            this.lbltglPemesanan.TabIndex = 16;
            this.lbltglPemesanan.Text = "Tanggal Pemesanan";
            this.lbltglPemesanan.Click += new System.EventHandler(this.lbltglPemesanan_Click);
            // 
            // tbnohp
            // 
            this.tbnohp.Location = new System.Drawing.Point(264, 91);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(220, 31);
            this.tbnohp.TabIndex = 15;
            this.tbnohp.TextChanged += new System.EventHandler(this.tbnohp_TextChanged);
            // 
            // lblnohp
            // 
            this.lblnohp.AutoSize = true;
            this.lblnohp.Location = new System.Drawing.Point(16, 97);
            this.lblnohp.Name = "lblnohp";
            this.lblnohp.Size = new System.Drawing.Size(100, 25);
            this.lblnohp.TabIndex = 14;
            this.lblnohp.Text = "Nomor Hp";
            this.lblnohp.Click += new System.EventHandler(this.lblnohp_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 399);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 31);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tbjenispaket
            // 
            this.tbjenispaket.FormattingEnabled = true;
            this.tbjenispaket.Items.AddRange(new object[] {
            "Paket A",
            "Paket B",
            "Paket C"});
            this.tbjenispaket.Location = new System.Drawing.Point(264, 191);
            this.tbjenispaket.Name = "tbjenispaket";
            this.tbjenispaket.Size = new System.Drawing.Size(220, 33);
            this.tbjenispaket.TabIndex = 12;
            this.tbjenispaket.SelectedIndexChanged += new System.EventHandler(this.tbjenispaket_SelectedIndexChanged);
            // 
            // tbhargatotal
            // 
            this.tbhargatotal.Enabled = false;
            this.tbhargatotal.Location = new System.Drawing.Point(264, 301);
            this.tbhargatotal.Name = "tbhargatotal";
            this.tbhargatotal.Size = new System.Drawing.Size(220, 31);
            this.tbhargatotal.TabIndex = 10;
            this.tbhargatotal.TextChanged += new System.EventHandler(this.tbhargatotal_TextChanged);
            // 
            // tbharga
            // 
            this.tbharga.Enabled = false;
            this.tbharga.Location = new System.Drawing.Point(264, 248);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(220, 31);
            this.tbharga.TabIndex = 9;
            this.tbharga.TextChanged += new System.EventHandler(this.tbharga_TextChanged);
            // 
            // tbberat
            // 
            this.tbberat.Location = new System.Drawing.Point(264, 141);
            this.tbberat.Name = "tbberat";
            this.tbberat.Size = new System.Drawing.Size(150, 31);
            this.tbberat.TabIndex = 7;
            this.tbberat.TextChanged += new System.EventHandler(this.tbberat_TextChanged);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(264, 39);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(381, 31);
            this.tbnama.TabIndex = 6;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged_1);
            // 
            // lbltgl
            // 
            this.lbltgl.AutoSize = true;
            this.lbltgl.Location = new System.Drawing.Point(17, 404);
            this.lbltgl.Name = "lbltgl";
            this.lbltgl.Size = new System.Drawing.Size(189, 25);
            this.lbltgl.TabIndex = 5;
            this.lbltgl.Text = "Tanggal Pengambilan";
            this.lbltgl.Click += new System.EventHandler(this.lbltgl_Click);
            // 
            // lblhrgT
            // 
            this.lblhrgT.AutoSize = true;
            this.lblhrgT.Location = new System.Drawing.Point(16, 301);
            this.lblhrgT.Name = "lblhrgT";
            this.lblhrgT.Size = new System.Drawing.Size(106, 25);
            this.lblhrgT.TabIndex = 4;
            this.lblhrgT.Text = "Harga Total";
            this.lblhrgT.Click += new System.EventHandler(this.lblhrgT_Click);
            // 
            // lblharga
            // 
            this.lblharga.AutoSize = true;
            this.lblharga.Location = new System.Drawing.Point(17, 248);
            this.lblharga.Name = "lblharga";
            this.lblharga.Size = new System.Drawing.Size(111, 25);
            this.lblharga.TabIndex = 3;
            this.lblharga.Text = "Harga Paket";
            this.lblharga.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbljenis
            // 
            this.lbljenis.AutoSize = true;
            this.lbljenis.Location = new System.Drawing.Point(16, 194);
            this.lbljenis.Name = "lbljenis";
            this.lbljenis.Size = new System.Drawing.Size(163, 25);
            this.lbljenis.TabIndex = 2;
            this.lbljenis.Text = "Jenis Paket Cucian";
            this.lbljenis.Click += new System.EventHandler(this.lbljenis_Click);
            // 
            // lblberat
            // 
            this.lblberat.AutoSize = true;
            this.lblberat.Location = new System.Drawing.Point(14, 144);
            this.lblberat.Name = "lblberat";
            this.lblberat.Size = new System.Drawing.Size(116, 25);
            this.lblberat.TabIndex = 1;
            this.lblberat.Text = "Berat Cucian";
            this.lblberat.Click += new System.EventHandler(this.lblberat_Click);
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(17, 45);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(60, 25);
            this.lblnama.TabIndex = 0;
            this.lblnama.Text = "Nama";
            this.lblnama.Click += new System.EventHandler(this.lblnama_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsimpan.Location = new System.Drawing.Point(759, 532);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(112, 34);
            this.btnsimpan.TabIndex = 2;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreset.Location = new System.Drawing.Point(558, 532);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(112, 34);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // Data_Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(915, 578);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Judul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Data_Pemesanan";
            this.Text = "Data Pemesanan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Judul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.ComboBox tbjenispaket;
        private System.Windows.Forms.TextBox tbhargatotal;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.TextBox tbberat;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label lbltgl;
        private System.Windows.Forms.Label lblhrgT;
        private System.Windows.Forms.Label lblharga;
        private System.Windows.Forms.Label lbljenis;
        private System.Windows.Forms.Label lblberat;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.Label lblnohp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbltglPemesanan;
    }
}

