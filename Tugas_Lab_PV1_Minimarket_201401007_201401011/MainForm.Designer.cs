/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 21/04/2022
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_Lab_PV1_Minimarket_201401007_201401011
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox jumlah;
		private System.Windows.Forms.TextBox harga;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button masukkan;
		private System.Windows.Forms.Button hapus;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox jenis;
		private System.Windows.Forms.Button hapusdata;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.jumlah = new System.Windows.Forms.TextBox();
			this.harga = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.masukkan = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.jenis = new System.Windows.Forms.TextBox();
			this.hapusdata = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label1.Location = new System.Drawing.Point(325, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "MINI MARKET RR";
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(172, 458);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(255, 26);
			this.id.TabIndex = 2;
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(172, 500);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(255, 26);
			this.nama.TabIndex = 3;
			// 
			// jumlah
			// 
			this.jumlah.Location = new System.Drawing.Point(172, 588);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(255, 26);
			this.jumlah.TabIndex = 4;
			// 
			// harga
			// 
			this.harga.Location = new System.Drawing.Point(172, 634);
			this.harga.Name = "harga";
			this.harga.Size = new System.Drawing.Size(255, 26);
			this.harga.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 461);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "ID Barang :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 502);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nama Barang :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 545);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Jenis Barang :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 590);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Jumlah Barang :";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 636);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Harga :";
			// 
			// masukkan
			// 
			this.masukkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.masukkan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.masukkan.Location = new System.Drawing.Point(552, 487);
			this.masukkan.Name = "masukkan";
			this.masukkan.Size = new System.Drawing.Size(151, 53);
			this.masukkan.TabIndex = 12;
			this.masukkan.Text = "Input Data";
			this.masukkan.UseVisualStyleBackColor = false;
			this.masukkan.Click += new System.EventHandler(this.MasukkanClick);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.update.Location = new System.Drawing.Point(552, 575);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(151, 53);
			this.update.TabIndex = 14;
			this.update.Text = "Update Data";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// reset
			// 
			this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.reset.Location = new System.Drawing.Point(719, 574);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(151, 53);
			this.reset.TabIndex = 15;
			this.reset.Text = "Reset Data";
			this.reset.UseVisualStyleBackColor = false;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(35, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(812, 369);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// jenis
			// 
			this.jenis.Location = new System.Drawing.Point(172, 545);
			this.jenis.Name = "jenis";
			this.jenis.Size = new System.Drawing.Size(255, 26);
			this.jenis.TabIndex = 17;
			// 
			// hapusdata
			// 
			this.hapusdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.hapusdata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.hapusdata.Location = new System.Drawing.Point(719, 487);
			this.hapusdata.Name = "hapusdata";
			this.hapusdata.Size = new System.Drawing.Size(151, 53);
			this.hapusdata.TabIndex = 18;
			this.hapusdata.Text = "Hapus Data";
			this.hapusdata.UseVisualStyleBackColor = false;
			this.hapusdata.Click += new System.EventHandler(this.HapusdataClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(882, 692);
			this.Controls.Add(this.hapusdata);
			this.Controls.Add(this.jenis);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.update);
			this.Controls.Add(this.masukkan);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.harga);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas_Lab_PV1_Minimarket_201401007_201401011";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
