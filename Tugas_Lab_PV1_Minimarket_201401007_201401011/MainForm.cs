/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 21/04/2022
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Tugas_Lab_PV1_Minimarket_201401007_201401011
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = minimarket; Uid= root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			Baca();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Baca(){
			try{
				mycommand.Connection=co;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from databarang";
				DataSet ds = new DataSet();
				if(myadapter.Fill(ds,"dftpesan")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void bersihkan(){
			id.Text="";
			nama.Text="";
			jenis.Text="";
			jumlah.Text="";
			harga.Text="";
		}
		
		public void input(){
			co.Open();
			try{
				mycommand.Connection=co;
				mycommand.CommandText="insert into databarang values ('"+id.Text+"','"+nama.Text+"','"+jenis.Text+"','"+jumlah.Text+"','"+harga.Text+"')";
				myadapter.SelectCommand=mycommand;
				if(mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data Berhasil Di Masukkan");
					Baca();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void hapus_data(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="delete from databarang where idbarang='"+id.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data Berhasil Dihapus");
						Baca();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
			
		public void updatedata(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="update databarang set idbarang='"+id.Text+"',namabarang='"+nama.Text+"',jenisbarang='"+jenis.Text+"',jumlahbarang='"+jumlah.Text+"',harga='"+harga.Text+"' where idbarang='"+id.Text+"'";
				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Baca();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
			
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			jenis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			jumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			harga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			
		}
		void ResetClick(object sender, EventArgs e)
		{
			bersihkan();
		}
		void MasukkanClick(object sender, EventArgs e)
		{
			input();
			bersihkan();
		}
		void HapusdataClick(object sender, EventArgs e)
		{
			hapus_data();
			bersihkan();
		}
		void UpdateClick(object sender, EventArgs e)
		{
			updatedata();
			bersihkan();
		}
	}
}
