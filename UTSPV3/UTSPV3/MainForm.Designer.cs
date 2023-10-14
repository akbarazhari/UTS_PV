/*
 * Created by SharpDevelop.
 * User: altaha
 * Date: 4/26/2020
 * Time: 2:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTSPV3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.namaHewan = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nis = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.kelas = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.jurusan = new System.Windows.Forms.TextBox();
			this.usia = new System.Windows.Forms.TextBox();
			this.btntes = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.mSpp = new System.Windows.Forms.CheckBox();
			this.mSrgm = new System.Windows.Forms.CheckBox();
			this.jenisbrg = new System.Windows.Forms.ComboBox();
			this.jlhbrg = new System.Windows.Forms.TextBox();
			this.pGuru = new System.Windows.Forms.CheckBox();
			this.pUmum = new System.Windows.Forms.CheckBox();
			this.transfer = new System.Windows.Forms.RadioButton();
			this.cash = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.jumlah = new System.Windows.Forms.TextBox();
			this.hitung = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// namaHewan
			// 
			this.namaHewan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namaHewan.ForeColor = System.Drawing.Color.Black;
			this.namaHewan.Location = new System.Drawing.Point(32, 336);
			this.namaHewan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.namaHewan.Name = "namaHewan";
			this.namaHewan.Size = new System.Drawing.Size(253, 34);
			this.namaHewan.TabIndex = 0;
			this.namaHewan.Text = "Nama";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(32, 282);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "NIS";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(32, 388);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(253, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kelas";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(32, 441);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 34);
			this.label3.TabIndex = 3;
			this.label3.Text = "Alamat";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(32, 490);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(253, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "Jurusan";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(32, 539);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(253, 34);
			this.label5.TabIndex = 5;
			this.label5.Text = "Usia";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(32, 41);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(891, 208);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// nis
			// 
			this.nis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nis.Location = new System.Drawing.Point(220, 282);
			this.nis.Margin = new System.Windows.Forms.Padding(4);
			this.nis.Name = "nis";
			this.nis.Size = new System.Drawing.Size(355, 25);
			this.nis.TabIndex = 7;
			this.nis.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// nama
			// 
			this.nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(220, 336);
			this.nama.Margin = new System.Windows.Forms.Padding(4);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(355, 25);
			this.nama.TabIndex = 8;
			// 
			// kelas
			// 
			this.kelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.kelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.kelas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kelas.Location = new System.Drawing.Point(220, 388);
			this.kelas.Margin = new System.Windows.Forms.Padding(4);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(355, 25);
			this.kelas.TabIndex = 9;
			// 
			// alamat
			// 
			this.alamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.alamat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alamat.Location = new System.Drawing.Point(220, 441);
			this.alamat.Margin = new System.Windows.Forms.Padding(4);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(355, 25);
			this.alamat.TabIndex = 10;
			// 
			// jurusan
			// 
			this.jurusan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.jurusan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.jurusan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jurusan.Location = new System.Drawing.Point(220, 490);
			this.jurusan.Margin = new System.Windows.Forms.Padding(4);
			this.jurusan.Name = "jurusan";
			this.jurusan.Size = new System.Drawing.Size(355, 25);
			this.jurusan.TabIndex = 11;
			// 
			// usia
			// 
			this.usia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.usia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usia.Location = new System.Drawing.Point(220, 539);
			this.usia.Margin = new System.Windows.Forms.Padding(4);
			this.usia.Name = "usia";
			this.usia.Size = new System.Drawing.Size(355, 25);
			this.usia.TabIndex = 12;
			// 
			// btntes
			// 
			this.btntes.BackColor = System.Drawing.Color.Turquoise;
			this.btntes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntes.Location = new System.Drawing.Point(615, 282);
			this.btntes.Margin = new System.Windows.Forms.Padding(4);
			this.btntes.Name = "btntes";
			this.btntes.Size = new System.Drawing.Size(308, 55);
			this.btntes.TabIndex = 13;
			this.btntes.Text = "Cek Koneksi";
			this.btntes.UseVisualStyleBackColor = false;
			this.btntes.Click += new System.EventHandler(this.BtntesClick);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.Color.Turquoise;
			this.insert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(615, 357);
			this.insert.Margin = new System.Windows.Forms.Padding(4);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(308, 55);
			this.insert.TabIndex = 14;
			this.insert.Text = "insert";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.Color.Turquoise;
			this.delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(615, 508);
			this.delete.Margin = new System.Windows.Forms.Padding(4);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(308, 55);
			this.delete.TabIndex = 15;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.Color.Turquoise;
			this.update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(615, 433);
			this.update.Margin = new System.Windows.Forms.Padding(4);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(308, 55);
			this.update.TabIndex = 16;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(152, 783);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 28);
			this.label6.TabIndex = 17;
			this.label6.Text = "item";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(152, 819);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 28);
			this.label7.TabIndex = 18;
			this.label7.Text = "jenjang";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(152, 855);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 28);
			this.label8.TabIndex = 19;
			this.label8.Text = "jumlah bulan";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(152, 883);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(155, 28);
			this.label9.TabIndex = 20;
			this.label9.Text = "Pekerjaan orang tua";
			this.label9.Click += new System.EventHandler(this.Label9Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(152, 996);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(133, 28);
			this.label10.TabIndex = 21;
			this.label10.Text = "total";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(152, 940);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(133, 28);
			this.label12.TabIndex = 23;
			this.label12.Text = "tanggal pembelian";
			this.label12.Click += new System.EventHandler(this.Label12Click);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(152, 911);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(144, 28);
			this.label13.TabIndex = 24;
			this.label13.Text = "metode pembayaran";
			this.label13.Click += new System.EventHandler(this.Label13Click);
			// 
			// mSpp
			// 
			this.mSpp.Location = new System.Drawing.Point(340, 777);
			this.mSpp.Margin = new System.Windows.Forms.Padding(4);
			this.mSpp.Name = "mSpp";
			this.mSpp.Size = new System.Drawing.Size(139, 30);
			this.mSpp.TabIndex = 25;
			this.mSpp.Text = "SPP";
			this.mSpp.UseVisualStyleBackColor = true;
			this.mSpp.CheckedChanged += new System.EventHandler(this.MSppCheckedChanged);
			// 
			// mSrgm
			// 
			this.mSrgm.Location = new System.Drawing.Point(556, 777);
			this.mSrgm.Margin = new System.Windows.Forms.Padding(4);
			this.mSrgm.Name = "mSrgm";
			this.mSrgm.Size = new System.Drawing.Size(139, 30);
			this.mSrgm.TabIndex = 26;
			this.mSrgm.Text = "Seragam";
			this.mSrgm.UseVisualStyleBackColor = true;
			this.mSrgm.CheckedChanged += new System.EventHandler(this.MSrgmCheckedChanged);
			// 
			// jenisbrg
			// 
			this.jenisbrg.FormattingEnabled = true;
			this.jenisbrg.Items.AddRange(new object[] {
									"SMP",
									"SMA"});
			this.jenisbrg.Location = new System.Drawing.Point(340, 815);
			this.jenisbrg.Margin = new System.Windows.Forms.Padding(4);
			this.jenisbrg.Name = "jenisbrg";
			this.jenisbrg.Size = new System.Drawing.Size(353, 24);
			this.jenisbrg.TabIndex = 27;
			this.jenisbrg.SelectedIndexChanged += new System.EventHandler(this.JenisbrgSelectedIndexChanged);
			// 
			// jlhbrg
			// 
			this.jlhbrg.Location = new System.Drawing.Point(340, 850);
			this.jlhbrg.Margin = new System.Windows.Forms.Padding(4);
			this.jlhbrg.Name = "jlhbrg";
			this.jlhbrg.Size = new System.Drawing.Size(353, 22);
			this.jlhbrg.TabIndex = 28;
			this.jlhbrg.TextChanged += new System.EventHandler(this.JlhbrgTextChanged);
			// 
			// pGuru
			// 
			this.pGuru.Location = new System.Drawing.Point(340, 878);
			this.pGuru.Margin = new System.Windows.Forms.Padding(4);
			this.pGuru.Name = "pGuru";
			this.pGuru.Size = new System.Drawing.Size(139, 30);
			this.pGuru.TabIndex = 29;
			this.pGuru.Text = "Guru";
			this.pGuru.UseVisualStyleBackColor = true;
			this.pGuru.CheckedChanged += new System.EventHandler(this.PGuruCheckedChanged);
			// 
			// pUmum
			// 
			this.pUmum.Location = new System.Drawing.Point(556, 878);
			this.pUmum.Margin = new System.Windows.Forms.Padding(4);
			this.pUmum.Name = "pUmum";
			this.pUmum.Size = new System.Drawing.Size(139, 30);
			this.pUmum.TabIndex = 30;
			this.pUmum.Text = "lainnya";
			this.pUmum.UseVisualStyleBackColor = true;
			this.pUmum.CheckedChanged += new System.EventHandler(this.PUmumCheckedChanged);
			// 
			// transfer
			// 
			this.transfer.Location = new System.Drawing.Point(340, 904);
			this.transfer.Margin = new System.Windows.Forms.Padding(4);
			this.transfer.Name = "transfer";
			this.transfer.Size = new System.Drawing.Size(139, 30);
			this.transfer.TabIndex = 31;
			this.transfer.TabStop = true;
			this.transfer.Text = "transfer bank";
			this.transfer.UseVisualStyleBackColor = true;
			this.transfer.CheckedChanged += new System.EventHandler(this.TransferCheckedChanged);
			// 
			// cash
			// 
			this.cash.Location = new System.Drawing.Point(556, 904);
			this.cash.Margin = new System.Windows.Forms.Padding(4);
			this.cash.Name = "cash";
			this.cash.Size = new System.Drawing.Size(139, 30);
			this.cash.TabIndex = 32;
			this.cash.TabStop = true;
			this.cash.Text = "cash";
			this.cash.UseVisualStyleBackColor = true;
			this.cash.CheckedChanged += new System.EventHandler(this.CashCheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(340, 932);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(353, 22);
			this.dateTimePicker1.TabIndex = 33;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// jumlah
			// 
			this.jumlah.Location = new System.Drawing.Point(340, 993);
			this.jumlah.Margin = new System.Windows.Forms.Padding(4);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(353, 22);
			this.jumlah.TabIndex = 34;
			this.jumlah.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// hitung
			// 
			this.hitung.Location = new System.Drawing.Point(756, 990);
			this.hitung.Margin = new System.Windows.Forms.Padding(4);
			this.hitung.Name = "hitung";
			this.hitung.Size = new System.Drawing.Size(100, 28);
			this.hitung.TabIndex = 35;
			this.hitung.Text = "Hitung";
			this.hitung.UseVisualStyleBackColor = true;
			this.hitung.Click += new System.EventHandler(this.HitungClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(1040, 1055);
			this.Controls.Add(this.hitung);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cash);
			this.Controls.Add(this.transfer);
			this.Controls.Add(this.pUmum);
			this.Controls.Add(this.pGuru);
			this.Controls.Add(this.jlhbrg);
			this.Controls.Add(this.jenisbrg);
			this.Controls.Add(this.mSrgm);
			this.Controls.Add(this.mSpp);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.btntes);
			this.Controls.Add(this.usia);
			this.Controls.Add(this.jurusan);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.nis);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.namaHewan);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Data Sekolah";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button btntes;
		private System.Windows.Forms.TextBox usia;
		private System.Windows.Forms.TextBox jurusan;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.TextBox kelas;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox nis;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label namaHewan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox mSpp;
		private System.Windows.Forms.CheckBox mSrgm;
		private System.Windows.Forms.ComboBox jenisbrg;
		private System.Windows.Forms.TextBox jlhbrg;
		private System.Windows.Forms.CheckBox pGuru;
		private System.Windows.Forms.CheckBox pUmum;
		private System.Windows.Forms.RadioButton transfer;
		private System.Windows.Forms.RadioButton cash;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox jumlah;
		private System.Windows.Forms.Button hitung;
	}
}
